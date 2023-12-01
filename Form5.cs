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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qTCSDLNEFDataSet.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.qTCSDLNEFDataSet.SANPHAM);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sANPHAMBindingSource.AddNew();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sANPHAMBindingSource.EndEdit();
            MessageBox.Show("Thành công");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sANPHAMBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tensp = Interaction.InputBox("Nhập tên sản phẩm");
            sANPHAMBindingSource.Filter = "TenSP like '" + tensp + "'";
        }
    }
}
