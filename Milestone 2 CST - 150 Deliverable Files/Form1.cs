using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Milestone_2_CST_150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public InventoryItems inventoryItems;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InventoryItems items = new InventoryItems();
            listView1.Items.Add(items.item1.ToString());
        }
    
    }
}
