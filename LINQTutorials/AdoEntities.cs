using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTutorials
{
    class AdoEntities
    {
        public void GroupJoin()
        {
            var employees = Employee.GetEmployees();

            tutorialDataContext tcontext = new tutorialDataContext();


        }
    }
}
