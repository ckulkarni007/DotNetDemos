using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Net
{
    public class LINQTOSQLEntities
    {
        public static void RetrieveEmployeeDetails()
        {
            using (TutorialsDataContext tutorialContext = new TutorialsDataContext())
            {
                foreach (var emp in tutorialContext.Employees)
                {
                    Console.WriteLine(emp.FirstName + emp.Salary);

                    var updatedEmployee = tutorialContext.Employees.FirstOrDefault(x => x.ID == 6);

                    updatedEmployee.FirstName = "This is new olneff afa Linq name";

                    tutorialContext.SubmitChanges();
                }
            }
            Console.ReadLine();
        }
      
    }
}
