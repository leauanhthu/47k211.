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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tHIETBIBindingSource.AddNew();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qTCSDLNEFDataSet.THIETBI' table. You can move, or remove it, as needed.
            this.tHIETBITableAdapter.Fill(this.qTCSDLNEFDataSet.THIETBI);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tHIETBIBindingSource.EndEdit();
            MessageBox.Show("Thành công");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tHIETBIBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tentb = Interaction.InputBox("Nhập tên thiết bị");
            tHIETBIBindingSource.Filter = "TenTB like '" + tentb + "'";
        }
    }
}
