using Microsoft.VisualBasic;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qTCSDLNEFDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qTCSDLNEFDataSet.KHACHHANG);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kHACHHANGBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kHACHHANGBindingSource.EndEdit();
            MessageBox.Show("Thành công");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kHACHHANGBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tenkh = Interaction.InputBox("Nhập tên nhà cung cấp");
            kHACHHANGBindingSource.Filter = "TenKH like '" + tenkh + "'";
        }
    }
}
