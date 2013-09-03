using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void AvailableCourses_PreprocessQuery(int? EmployeeID, ref IQueryable<Course> query)
        {
            if (EmployeeID.HasValue)
            {
                //Return only sections which the employee has not registered
                query = from Course c in query
                        where (!(c.Enrollments.Any(f => f.Employee.Id == EmployeeID)))
                        select c;
            }
        }

        partial void CoursesByResource_PreprocessQuery(int? ProgramID, ref IQueryable<Course> query)
        {
                
            if(ProgramID.HasValue)
            {
                //Return only courses which fall into the resource (Lynda, Pluralsight, etc...)
                query = from Course c in query
                        where c.Resource.Courses.Any(f => f.Resource.Id == ProgramID)
                        select c;
            }
        }
    }
}
