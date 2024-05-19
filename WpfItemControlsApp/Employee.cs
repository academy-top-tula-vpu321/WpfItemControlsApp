using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfItemControlsApp
{
    public class Employee
    {
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string Company { get; set; } = null!;

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
