using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseLEDs
{
    public partial class Form1 : Form
    {
        private Leds meusLeds;
        public Form1()
        {
            InitializeComponent();
            meusLeds = new Leds();
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //

        //ON
        private void bntLED1_ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(1);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLED2_ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(2);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLED3_ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(3);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLED4_ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(4);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLED5_ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(5);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLED6_ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(6);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLED7_ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(7);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLED8_ON_Click(object sender, EventArgs e)
        {
            meusLeds.acender(8);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        //OFF
        private void btnLED1_OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(1);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLED2_OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(2);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLED3_OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(3);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLED4_OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(4);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLED5_OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(5);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLED6_OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(6);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLED7_OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(7);
            txtDado.Text = meusLeds.getDado().ToString();
        }

        private void btnLED8_OFF_Click(object sender, EventArgs e)
        {
            meusLeds.apagar(8);
            txtDado.Text = meusLeds.getDado().ToString();
        }
    }
}
