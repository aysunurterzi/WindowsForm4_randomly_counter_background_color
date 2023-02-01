using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormlarıcalısma4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi1 = rnd.Next(1, 50);
            int sayi2 = rnd.Next(1, 50);
            int sayi3 = rnd.Next(1, 50);
            int sayi4 = rnd.Next(1, 50);
            int sayi5 = rnd.Next(1, 50);
            int sayi6 = rnd.Next(1, 50);

            label1.Text = Convert.ToString(sayi1);
            label2.Text = Convert.ToString(sayi2);
            label3.Text = Convert.ToString(sayi3);
            label4.Text = Convert.ToString(sayi4);
            label5.Text = Convert.ToString(sayi5);
            label6.Text = Convert.ToString(sayi6);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color[] renkler = new Color[8] {Color.Red, Color.Blue, Color.Pink, Color.Brown, Color.Green,
               Color.Purple, Color.Orange, Color.Gray};
            Random renk = new Random();
            int dizi_elemani = renk.Next(0, 7);
            this.BackColor = renkler[dizi_elemani];



        }
    }
}
