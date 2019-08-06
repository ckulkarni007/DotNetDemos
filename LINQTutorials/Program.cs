using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace LINQTutorials
{

    class Program
    {

        static void Main(string[] args)
        {
            var employeeCollection = OfficeEmployee.GetEmployeeDetails();

            IEnumerable<OfficeEmployee> maleEmployee = employeeCollection.Where(emp => emp.Gender.Equals(Gender.male));

            foreach (var item in maleEmployee)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }

        private static void LinqToSql()
        {
            using (tutorialDataContext tutorialDataContext = new tutorialDataContext())
            {
                foreach (var emp in tutorialDataContext.Employees)
                {
                    Console.WriteLine($"{emp.FirstName} \t {emp.LastName}");
                }

                Employee employee = new Employee() { FirstName = "Chaitanya", LastName = "Kulkarni" };

                tutorialDataContext.Employees.InsertOnSubmit(employee);
                tutorialDataContext.SubmitChanges();

            }
        }

        private static void GroupJoinAndInnerJoin()
        {
            var employees = OfficeEmployee.GetEmployeeDetails();
            var managers = Manager.GetManagers();

            var linqEmpBob = from emp in employees
                             join manager in managers
                             on emp.ManagerId equals manager.Id into grp
                             select grp;


            var bobEmployees = employees.Join(managers, emp => emp.ManagerId, manager => manager.Id, (emp, manager) => manager).Where(x => x.Id == 1);

            var groupEmployees = employees.GroupJoin(managers, emp => emp.ManagerId, manager => manager.Id, (emp, manager) => manager);
        }

        private static void UnionAndIntersect()
        {
            var employees = OfficeEmployee.GetEmployeeDetails();
            var newEmployees = OfficeEmployee.GetEmployeeDetailsNew();

            var emp = employees.Union(newEmployees, new EmployeeComparer()).ToList();

            var intersetct = employees.Intersect(newEmployees, new EmployeeComparer());
        }


        private static void GroupOperation()
        {
            var employees = OfficeEmployee.GetEmployeeDetails();

            var grpLambda = employees.GroupBy(x => new { x.Gender, x.Salary }).OrderBy(x => x.Key.Salary).ThenByDescending(x => x.Key.Gender)
            .Select(x => new { Employees = x, Gender = x.Key.Gender, Salary = x.Key.Salary });


            var grpQuery = from emp in employees
                           group emp by new { emp.Gender, emp.Salary } into empGroup
                           orderby empGroup.Key.Salary ascending, empGroup.Key.Gender descending
                           select new { Salary = empGroup.Key.Salary, Gender = empGroup.Key.Gender, Emp = empGroup };
        }

        private static void CastOperation()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(123);
            arrayList.Add("ABC");
            arrayList.Add("Chaitanya");

            IEnumerable<int> castO = arrayList.OfType<int>();
        }

        public void Aggregation(List<OfficeEmployee> employees)
        {
            var result = employees.Aggregate((e1, e2) => new OfficeEmployee { Name = e1.Name + e2.Name });

            Console.WriteLine(result);
        }

        public void MultipleProjection(List<OfficeEmployee> employees)
        {
            //for select 2 loops will be required, which is achieved only by single loop in selectmany

            var youngEmployees = employees.SelectMany(e => e.Departments);

            var youngEmp = from emp in employees
                           from dep in emp.Departments
                           select dep;
        }

        public void Partitioning(List<OfficeEmployee> employees)
        {
            IEnumerable<OfficeEmployee> chosenEmployee = employees.Take(3);

        }

        public void GroupList(List<OfficeEmployee> employees)
        {
            var groupQuery = employees.GroupBy(emp => new { emp.Gender, emp.Salary }).OrderBy(x => x.Key.Gender).ThenBy(x => x.Key.Salary).Select(x => new { Gender = x.Key.Gender, Salary = x.Key.Salary, Employees = x });

            var sqlQuery = from empGrp in employees
                           group empGrp by new { empGrp.Gender, empGrp.Age } into empQueryGroup
                           orderby empQueryGroup.Key.Age ascending, empQueryGroup.Key.Gender descending
                           select new { };
        }
        public static void HashSetTut()
        {
            //Load factor - number of elementss stored/ capacity
            //Hashset - 0.75
            //Arraylist - 1

            HashSet<string> set = new HashSet<string>();
            set.Add("first");
            set.Add("second");
            set.Add("first"); // No exception at compile or runtime.
            HashSet<string> newset = new HashSet<string>();
            newset.Add("first");// It will not aadd duplicate items. Add returns false
            // Insertion order is not maintained
            var test = newset.Intersect(set);
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
            // Union
        }

    }
}
