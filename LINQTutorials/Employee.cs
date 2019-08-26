using System.Collections.Generic;

namespace LINQTutorials
{
    public class Manager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }

        public static List<Manager> GetManagers()
        {
            List<Manager> managers = new List<Manager>();
            managers.Add(new Manager { Id = 1, Gender = Gender.male, Name = "Bob" });
            managers.Add(new Manager { Id =4, Gender = Gender.male, Name = "NewManger" });
            return managers;
        }


    }


    public class OfficeEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public List<string> Departments { get; set; }

        public int ManagerId { get; set; }

        private static List<OfficeEmployee> _officeEmployees = new List<OfficeEmployee>();

        public static List<OfficeEmployee> GetEmployeeDetails()
        {
            _officeEmployees.Add(new OfficeEmployee { Id = 101, Name = "Alex", Age = 23, Gender = Gender.male, Salary = 33000.00M, Departments = new List<string> { "IT" }, ManagerId = 1 });
            _officeEmployees.Add(new OfficeEmployee { Id = 102, Name = "Ramsey", Age = 23, Gender = Gender.male, Salary = 35000.00M, Departments = new List<string> { "IT" }, ManagerId = 1 });
            _officeEmployees.Add(new OfficeEmployee { Id = 103, Name = "Jenny", Age = 29, Gender = Gender.female, Salary = 43000.00M, Departments = new List<string> { "IT" }, ManagerId = 2 });

            _officeEmployees.Add(new OfficeEmployee { Id = 104, Name = "Nile", Age = 59, Gender = Gender.male, Salary = 143000.055M, Departments = new List<string> { "Finance", "Accounting" }, ManagerId = 2 });
            _officeEmployees.Add(new OfficeEmployee { Id = 105, Name = "Julia", Age = 39, Gender = Gender.female, Salary = 83000.00M, Departments = new List<string> { "HR" } });
            _officeEmployees.Add(new OfficeEmployee { Id = 106, Name = "Donald", Age = 19, Gender = Gender.male, Salary = 23000.00M, Departments = new List<string> { "Administration" } });
            return _officeEmployees;
        }

        public static void AddEmployee(OfficeEmployee officeEmployee)
        {
            _officeEmployees.Add(officeEmployee);
        }

        public static OfficeEmployee GetEmployeeById(int id)
        {
            return _officeEmployees.Find(x=>x.Id.Equals(id));
        }
        public static OfficeEmployee GetEmployeeBySalary(decimal salary)
        {
            return _officeEmployees.Find(x => x.Salary.Equals(salary));
        }

        public static List<OfficeEmployee> GetEmployeeDetailsNew()
        {
            List<OfficeEmployee> empCollection = new List<OfficeEmployee>();
            empCollection.Add(new OfficeEmployee { Id = 101, Name = "Alex", Age = 24, Gender = Gender.male, Salary = 33000.00M, Departments = new List<string> { "IT" } });
            empCollection.Add(new OfficeEmployee { Id = 102, Name = "Ramsey", Age = 23, Gender = Gender.male, Salary = 35000.00M, Departments = new List<string> { "IT" } });
            empCollection.Add(new OfficeEmployee { Id = 103, Name = "Jenny", Age = 29, Gender = Gender.female, Salary = 43000.00M, Departments = new List<string> { "IT" } });

            empCollection.Add(new OfficeEmployee { Id = 104, Name = "Nile", Age = 59, Gender = Gender.male, Salary = 143000.055M, Departments = new List<string> { "Finance", "Accounting" } });
            empCollection.Add(new OfficeEmployee { Id = 105, Name = "Julia", Age = 39, Gender = Gender.female, Salary = 83000.00M, Departments = new List<string> { "HR" } });
            empCollection.Add(new OfficeEmployee { Id = 106, Name = "Donald", Age = 19, Gender = Gender.male, Salary = 23000.00M, Departments = new List<string> { "Administration" } });
            return empCollection;
        }
    }

    public enum Gender
    {
        male,
        female
    }
}