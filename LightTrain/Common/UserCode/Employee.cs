using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Employee
    {
        partial void EmployeeName_Compute(ref string result)
        {
            result = FirstName.Trim() + " " + LastName.Trim();
        }
    }
}
