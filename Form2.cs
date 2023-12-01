using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Phần_mềm_quản_lý_tiệm_photo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nHACUNGCAPBindingSource.AddNew();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qTCSDLNEFDataSet.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.qTCSDLNEFDataSet.NHACUNGCAP);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nHACUNGCAPBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nHACUNGCAPBindingSource.EndEdit();
            MessageBox.Show("Thành công");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tenncc= Interaction.InputBox("Nhập tên nhà cung cấp");
            nHACUNGCAPBindingSource.Filter = "TenNCC like '" + tenncc + "'";
        }
    }
}
