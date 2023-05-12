using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class Film
    {
        public string Title { get; private set; }
        public ushort Year { get; set; }
        public Film(string title, ushort year)
        {
            Title = title;
            Year = year;
        }
    }
}
