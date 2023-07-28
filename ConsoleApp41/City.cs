using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    public class Base
    {
        public string Title { get; set; }
    }
    public class City:Base
    {
        public string Name { get; set; }
    }

    public class Region
    {
        public string Name { get; set; }
    }
}
