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
    public partial class RegisterCourse
    {
        partial void RegisterCourse_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            this.EnrollmentProperty = new Enrollment();
            this.Text_Title = "Add Course to Training Plan";

            if (EmployeeId.HasValue)
            {
                this.EnrollmentProperty.Employee = DataWorkspace.ApplicationData.Employees_Single(EmployeeId);
            }

            if (ProgramID.HasValue)
            {
                this.EnrollmentProperty.Course = DataWorkspace.ApplicationData.Courses_Single(ProgramID);
            }
        }

        partial void RegisterCourse_Saved()
        {
            // Write your code here.
            this.Close(false);
        }
    }
}