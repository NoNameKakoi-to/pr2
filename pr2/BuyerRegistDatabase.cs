using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class BuyerRegistDatabase
    {
        internal List<BuyerRegist> Entry { get; private set; }
        public void Initialize()
        {
            Entry = new List<BuyerRegist>()
            {
                new BuyerRegist(new Buyer("Name1", "Phone1"), new Film("Title1", 2023), DateTime.Parse("01/01/2023"), DateTime.Parse("01/04/2023"), BuyerRegist.Statuses.Возвращено),
                new BuyerRegist(new Buyer("Name2", "Phone2"), new Film("Title2", 2022), DateTime.Parse("09/05/2023"), DateTime.Parse("09/08/2023"), BuyerRegist.Statuses.Невозвращено),
                new BuyerRegist(new Buyer("Name3", "Phone3"), new Film("Title3", 2020), DateTime.Parse("12/05/2023"), DateTime.Parse("12/08/2023"), BuyerRegist.Statuses.Невозвращено)
            };
        }
    }
}
