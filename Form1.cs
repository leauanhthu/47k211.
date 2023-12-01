using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phần_mềm_quản_lý_tiệm_photo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild!=null)
            {
                currentFormChild.Close();

            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild!=null)
            {
                currentFormChild.Close();
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form4());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form5());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form6());
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void InHoaDon_Click(object sender, EventArgs e)
        {
            //using (HoaDonViewer hoadon = new HoaDonViewer())
            //{
            //    hoadon.ShowDialog();
            //}
            OpenChildForm(new HoaDonViewer());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form7());
        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
