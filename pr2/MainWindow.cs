using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr2
{
    public partial class MainWindow : Form
    {
        private BuyerRegistDatabase buyerRegist;
        public MainWindow()
        {
            InitializeComponent();
            buyerRegist = new BuyerRegistDatabase();
            buyerRegist.Initialize();
            entries.DataSource = buyerRegist.Entry.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            entries.DataSource = buyerRegist.Entry.OrderByDescending(i => i.FilmTitle).ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            search.Clear();
            comboBox1.SelectedIndex = -1;
            entries.DataSource = buyerRegist.Entry.ToList();
        }

        private void search_TextChanged_1(object sender, EventArgs e)
        {
            entries.DataSource = buyerRegist.Entry.Where(i => i.BuyerName.ToLower().Contains(search.Text.ToLower())).ToList();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    entries.DataSource = buyerRegist.Entry.Where(i => i.Status == BuyerRegist.Statuses.Возвращено).ToList();
                    break;
                case 1:
                    entries.DataSource = buyerRegist.Entry.Where(i => i.Status == BuyerRegist.Statuses.Невозвращено).ToList();
                    break;
            }

        }
    }
}
