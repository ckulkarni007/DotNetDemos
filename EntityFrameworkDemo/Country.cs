using System.Collections.Generic;

namespace EntityFrameworkDemo
{
    public class Country
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int Population { get; set; }
        public string Currency { get; set; }
        public string Capital { get; set; }
        public List<State> States  { get; set; }
    }
}
