using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba7
{
    public partial class BMI : Form
    {
        float index;
        float r, v;
        public BMI()
        {
            InitializeComponent();
            //Form form1 = new Form();
            //form1.AcceptButton = Расчитать;
        }

        
       
        private void Отмена_Click(object sender, EventArgs e)
        {
            rost.Text = null;
            ves.Text = null;
            x.Text = null;
            zn.Text = null;
            trackBar1.Value = 0;

            p1.BorderStyle = BorderStyle.None;
            p1.BackColor = Color.WhiteSmoke;
            p2.BorderStyle = BorderStyle.None;
            p2.BackColor = Color.WhiteSmoke;

            pb1.Visible = false;
            pb2.Visible = true;
            pb3.Visible = false;
            pb4.Visible = false;
            


        }

        private void p1_Click(object sender, EventArgs e)
        {
            p1.BorderStyle = BorderStyle.FixedSingle;
            p1.BackColor = Color.LightGray;

            p2.BorderStyle = BorderStyle.None;
            p2.BackColor = Color.WhiteSmoke;

        }

        private void p2_Click(object sender, EventArgs e)
        {
            p2.BorderStyle = BorderStyle.FixedSingle;
            p2.BackColor = Color.LightGray;

            p1.BorderStyle = BorderStyle.None;
            p1.BackColor = Color.WhiteSmoke;

        }

        private void BMI_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void Расчитать_Click(object sender, EventArgs e)
        {
            
            r = float.Parse(rost.Text);
            v = float.Parse(ves.Text);
            r /= 100;
            index = v / (r * r);
            x.Text = index.ToString("N");
            trackBar1.Value = (int)index;

            
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = false;
            pb4.Visible = false;

            if (index < 18.5)
            {
                pb1.Visible = true;
                zn.Text = "Недостаточный вес";
            }
           
            if (index >= 18.5 && index <= 24.9)
            {
                pb2.Visible = true;
                zn.Text = "   Здоровый вес";
            }
            

            if (index >= 25 && index < 29.9)
            {
                pb3.Visible = true;
                zn.Text = "   Избыточный вес";
            }
            

            if (index >= 30)
            {
                pb4.Visible = true;
                zn.Text = "      Ожирение   ";
            }
            
        }
    }
}
