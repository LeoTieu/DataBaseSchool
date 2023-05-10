using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddData f = new AddData();
            f.ShowDialog();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowData f = new ShowData();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteData f = new DeleteData();
            f.ShowDialog();
        }
    }
}
