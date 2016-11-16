using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Momentum_GUI3
{
    public partial class GUI : Form
    {
        public string eemail = "";
        public GUI()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tilbage_tilføj_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            
        }

        private void tilbage_vis_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void accepter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("er alle data korrekte?");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            /*string theDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            MessageBox.Show(theDate);*/
        }
      

        private void email_TextChanged(object sender, EventArgs e)
        {
            eemail = email.Text;
        }
    }
}
