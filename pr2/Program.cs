using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());

            Buyer buyer4 = new Buyer("Name4", "Phone4");
            Buyer buyer5 = new Buyer("Name5", "Phone5");
            Buyer buyer6 = new Buyer("Name6", "Phone6");
            Buyer buyer7 = new Buyer("Name7", "Phone7");
            Film film4 = new Film("Title4", 2004);
            Film film5 = new Film("Title5", 1998);
            Film film6 = new Film("Title6", 2001);
            Film film7 = new Film("Title7", 2019);
        }
    }
}
