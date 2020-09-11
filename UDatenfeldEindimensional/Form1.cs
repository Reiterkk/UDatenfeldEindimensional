using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDatenfeldEindimensional
{
    public partial class Form1 : Form
    {
        private readonly Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] zahlen = new int[10];
            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = r.Next(20, 31);
                LstZahlen.Items.Add(zahlen[i]);
            }
        }
    }
}
