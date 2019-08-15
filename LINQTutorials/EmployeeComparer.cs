using System;
using System.Collections.Generic;


namespace LINQTutorials
{
    class EmployeeComparer : IEqualityComparer<OfficeEmployee>
    {
        public bool Equals(OfficeEmployee x, OfficeEmployee y)
        {
            if (x != null && y != null)
            {
                if (x.Name.Equals(y.Name, StringComparison.InvariantCultureIgnoreCase) && x.Gender.Equals(y.Gender) && x.Age.Equals(y.Age))
                    return true;
                return false;
            }
            return false;
        }

        public int GetHashCode(OfficeEmployee obj)
        {
           
            int x = 1234564789;

            x = x ^ obj.Age.GetHashCode();
            x = x ^ obj.Name.GetHashCode();
            x = x ^ obj.Gender.GetHashCode();

            return x;
        }
    }
}
