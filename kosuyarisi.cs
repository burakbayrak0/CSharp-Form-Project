using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atyarisi
{
    public partial class kosuyarisi : Form
    {
        public kosuyarisi()
        {
            InitializeComponent();
        }
        int birinciinsansolauzaklık, ikinciinsansolauzaklık, ucuncuinsansolauzaklık;
        Random rastgele=new Random();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            int birinciinsangenisligi = pictureBox1.Width;
            int ikinciinsangenisligi= pictureBox2.Width;
            int ucuncuinsangenisligi=pictureBox3.Width;

            int bitisuzakligi=label6.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if(pictureBox1.Left>pictureBox2.Left+5 && pictureBox1.Left>pictureBox3.Left+5)
            {
                label5.Text = ("Bir Numaralı Yarışmacı Yarışı Önde Götürüyor.");
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label5.Text = ("İki Numaralı Yarışmacı İyi Bir Atakla Öne Geçti.");
            }

            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label5.Text = ("Üç Numaralı Yarışmacı Liderliği Ele Geçirdi.");
            }








            if ( birinciinsangenisligi + pictureBox1.Left >= bitisuzakligi )
            {
                timer1.Enabled = false;
                label5.Text = ("Bir Numaralı Yarışmacı Kazandı.");
            }

            if(ikinciinsangenisligi + pictureBox2.Left >=bitisuzakligi)
            {
                timer1.Enabled=false;
                label5.Text = ("İki Numaralı Yarışmacı Kazandı.");
            }

            if (ucuncuinsangenisligi + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label5.Text = ("Üç Numaralı Yarışmacı Kazandı.");
            }






        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            pictureBox1.Left = 0;
            pictureBox2.Left= 0;
            pictureBox3.Left= 0;
            timer1.Enabled = true;
        
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciinsansolauzaklık = pictureBox1.Left;
            ikinciinsansolauzaklık=pictureBox2.Left;
            ucuncuinsansolauzaklık=pictureBox3.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }
    }
}
