using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using System.Runtime.InteropServices.Automation;
using System.Windows.Browser;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Threading;

namespace LightSwitchApplication
{
    public partial class Application
    {
        partial void ManageEmployees_CanRun(ref bool result)
        {
            // All User to view admin screen
            result = User.HasPermission(Permissions.ViewAdminScreen);

        }

        partial void DocumentationLink_Run(ref bool handled)
        {
            //change this to launch the page you want
            var uri = new Uri("http://inetdev01/traintrack_webapp/help/TrainTrackTraining.htm", UriKind.RelativeOrAbsolute);
            //var uri = new Uri("http://inetdev01/traintrack_webapp/help/TrainTrackTraining.pdf", UriKind.RelativeOrAbsolute);

            Dispatchers.Main.BeginInvoke(() =>
            {
                try
                {
                    if (AutomationFactory.IsAvailable)
                    {
                        var shell = AutomationFactory.CreateObject("Shell.Application");
                        shell.ShellExecute(uri.ToString());
                    }
                    else if (!System.Windows.Application.Current.IsRunningOutOfBrowser)
                    {
                        HtmlPage.Window.Navigate(uri, "_blank");
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                }
                catch (Exception ex)
                {
                    //handle the exception however you want
                    //throw new Exception("Didn't work.", ex);
                    Console.WriteLine("{0} Exception caught.", ex);
                }
            });

            //Set handler to 'true' to stop further processing
            handled = true;

        }
    }
}
