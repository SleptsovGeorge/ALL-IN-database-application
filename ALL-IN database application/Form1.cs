using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALL_IN_database_application
{
    public partial class Form1 : Form
    {
        Toernooi toernooi = new Toernooi();

        public string kosten;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toernooi.KrijgDingen();
            kosten = txt_kosten.Text;
        }
    }
}
