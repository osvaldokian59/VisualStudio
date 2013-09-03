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
    public partial class CourseDetail
    {
        partial void Course_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Course);
        }

        partial void Course_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Course);
        }

        partial void CourseDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Course);
        }

        partial void RegisterCourse_Execute()
        {
            // Write your code here.
            Application.ShowRegisterCourse(null, Course.Id);

        }
    }
}