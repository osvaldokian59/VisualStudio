using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class Home
    {
        partial void SearchEmployees_Execute()
        {
            // Write your code here.
            Application.ShowSearchEmployees();

        }

        partial void CourseCatalog_Execute()
        {
            // Write your code here.
            Application.ShowCourseCatalog();
        }

        partial void EnrollInCourse_Execute()
        {
            // Write your code here.
            Application.ShowRegisterCourse(null, null);

        }

        partial void HowTo_Execute()
        {
            // Write your code here.
            Application.ShowDocumentationLink();

        }


    }
}
