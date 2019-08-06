using System;
using System.Collections.Generic;


namespace LINQTutorials
{
    class EmployeeComparer : IEqualityComparer<OfficeEmployee>
    {
        public bool Equals(OfficeEmployee x, OfficeEmployee y)
        {
            if(x!=null && y != null)
            {
                if (x.Name.Equals(y.Name, StringComparison.InvariantCultureIgnoreCase) && x.Gender.Equals(y.Gender) && x.Age.Equals(y.Age))
                    return true;
                return false;
            }
            return false;
        }

        public int GetHashCode(OfficeEmployee obj)
        {
            int hashSalt = 1234564789;

            hashSalt = hashSalt ^ obj.Age.GetHashCode();
            hashSalt = hashSalt ^ obj.Name.GetHashCode();
            hashSalt = hashSalt ^ obj.Gender.GetHashCode();

            return hashSalt;
        }
    }
}
