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
    public partial class FromMain : Form
    {
        public FromMain()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
           
        }
        
       
        static Form2 form2;
        private void muaHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(form2==null||form2.IsDisposed)
            {
                form2 = new Form2();
                form2.MdiParent= FromMain.ActiveForm ;
                form2.Show();
            }
            else { form2.Activate(); }
        }

        private void FromMain_Load(object sender, EventArgs e)
        {
            
        }
        static Form3 form3;
        private void nhàCungCấpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (form3 == null || form3.IsDisposed)
            {
                form3 = new Form3();
                form3.MdiParent = FromMain.ActiveForm;
                form3.Show();
            }
            else { form3.Activate(); }
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        static Form4 form4;
        private void thiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
                if (form4 == null || form4.IsDisposed)
                {
                    form4 = new Form4();
                    form4.MdiParent = FromMain.ActiveForm;
                    form4.Show();
                }
                else { form4.Activate(); }
            }
        static Form5 form5;
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (form5 == null || form5.IsDisposed)
                {
                    form5 = new Form5();
                    form5.MdiParent = FromMain.ActiveForm;
                    form5.Show();
                }
                else { form5.Activate(); }
            }
        static Form6 form6;
        private void tàiLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form6 == null || form6.IsDisposed)
            {
                form6 = new Form6();
                form6.MdiParent = FromMain.ActiveForm;
                form6.Show();
            }
            else { form6.Activate(); }
        }
        static Form7 form7;
        private void muaHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                if (form7 == null || form7.IsDisposed)
                {
                    form7 = new Form7();
                    form7.MdiParent = FromMain.ActiveForm;
                    form7.Show();
                }
                else { form7.Activate(); }
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        static Form8 form8;
        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (form8 == null || form8.IsDisposed)
            {
                form8 = new Form8();
                form8.MdiParent = FromMain.ActiveForm;
                form8.Show();
            }
            else { form8.Activate(); }


        }
        static Form9 form9;
        private void cungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (form9 == null || form9.IsDisposed)
            {
                form9 = new Form9();
                form9.MdiParent = FromMain.ActiveForm;
                form9.Show();
            }
            else { form9.Activate(); }
        }
    }
    }
 
