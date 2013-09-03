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
    public partial class EmployeeDetail
    {
        partial void Employee_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Employee);
        }

        partial void Employee_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Employee);
        }

        partial void EmployeeDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Employee);
        }

        partial void RegisterCourse_CanExecute(ref bool result)
        {
            // Write your code here.
            result = Employee != null;

        }

        partial void RegisterCourse_Execute()
        {
            // Write your code here.
            Application.ShowRegisterCourse(Employee.Id, null);
        }

        partial void DropCourse_CanExecute(ref bool result)
        {
            // Write your code here.
            result = Enrollments.SelectedItem != null;

        }

        partial void DropCourse_Execute()
        {
            // Write your code here.
            if (this.ShowMessageBox("Are you sure you want to drop this course?", "Drop Course", MessageBoxOption.YesNo) == System.Windows.MessageBoxResult.Yes)
            {
                Enrollments.SelectedItem.Delete();
            }
        }

    }
}