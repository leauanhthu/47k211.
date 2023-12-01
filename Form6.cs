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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tAILIEUBindingSource.EndEdit();
            MessageBox.Show("Thành công");
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qTCSDLNEFDataSet.TAILIEU' table. You can move, or remove it, as needed.
            this.tAILIEUTableAdapter.Fill(this.qTCSDLNEFDataSet.TAILIEU);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tAILIEUBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tAILIEUBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tentl = Interaction.InputBox("Nhập tên tài liệu");
            tAILIEUBindingSource.Filter = "TenTL like '" + tentl + "'";
        }
    }
}
