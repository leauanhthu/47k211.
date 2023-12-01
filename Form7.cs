using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phần_mềm_quản_lý_tiệm_photo.EntityFramework;
using Phần_mềm_quản_lý_tiệm_photo.Model;
namespace Phần_mềm_quản_lý_tiệm_photo
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void Form7_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'qTCSDLNEFDataSet.MUA_CHITIET' table. You can move, or remove it, as needed.
            //this.mUA_CHITIETTableAdapter.Fill(this.qTCSDLNEFDataSet.MUA_CHITIET);
            //// TODO: This line of code loads data into the 'qTCSDLNEFDataSet.SANPHAM' table. You can move, or remove it, as needed.
            //this.sANPHAMTableAdapter.Fill(this.qTCSDLNEFDataSet.SANPHAM);
            QTCSDLNEFEntities context = new QTCSDLNEFEntities();
            var thongTinHoaDon = context.MUAs
                .Where(x => x.MaDonMua.Equals(""))
                .Select(x => new ThongTinHoaDonModel
                {
                    MaHD = x.MaDonMua,
                    MaKH = x.MaKH,
                    SDT = x.KHACHHANG.SDT.ToString(),
                    DiaChi = x.KHACHHANG.DiaChi,
                    NgayMua = x.NgayMua.ToString(),
                    Ten = x.KHACHHANG.TenKH
                }).FirstOrDefault();
            //textBox4.Text = thongTinHoaDon.MaHD;
            //textBox5.Text = thongTinHoaDon.MaKH;
            //textBox3.Text = thongTinHoaDon.SDT;
            //textBox8.Text = thongTinHoaDon.NgayMua;
            //textBox7.Text = thongTinHoaDon.DiaChi;
            //textBox9.Text = thongTinHoaDon.Ten;


            //Không cho chạy bất đồng bộ cần nâng cấp
            var DSSanPham =  context.MUA_CHITIET.
                Where(x => x.MaDonMua.Equals("MSP001")).
                Select(x => new ThongtinChiTietModel
                {
                    MaSP = x.SANPHAM.MaSP,
                    DonGia = x.SANPHAM.DonGia,
                    DVT = x.SANPHAM.DVT,
                    TenSP = x.SANPHAM.TenSP,
                    SL = x.Soluong,
                    ThanhTien = x.Soluong * x.SANPHAM.DonGia
                }).ToList();
            decimal? Tong = 0;
            foreach (var i in DSSanPham)
            {
                //dataGridView1.Rows.Add(new DataGridViewRow());
                Tong += i.ThanhTien;
                dataGridView1.Rows.Add(i.MaSP, i.TenSP, i.DonGia, i.DVT, i.SL, i.ThanhTien);
            }
            label8.Text = "Tổng tiền: " + Tong.ToString();

            List<MUA> mua=await  context.MUAs.ToListAsync();
            dataGridView2.DataSource = mua;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MDM = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            QTCSDLNEFEntities context = new QTCSDLNEFEntities();
            var DSSanPham = context.MUA_CHITIET.
               Where(x => x.MaDonMua.Equals(MDM)).
               Select(x => new ThongtinChiTietModel
               {
                   MaSP = x.SANPHAM.MaSP,
                   DonGia = x.SANPHAM.DonGia,
                   DVT = x.SANPHAM.DVT,
                   TenSP = x.SANPHAM.TenSP,
                   SL = x.Soluong,
                   ThanhTien = x.Soluong * x.SANPHAM.DonGia
               }).ToList();
            decimal? Tong = 0;
            dataGridView1.ClearSelection();
            foreach (var i in DSSanPham)
            {
                //dataGridView1.Rows.Add(new DataGridViewRow());
                Tong += i.ThanhTien;
                dataGridView1.Rows.Add(i.MaSP, i.TenSP, i.DonGia, i.DVT, i.SL, i.ThanhTien);
            }
            var thongTinHoaDon = context.MUAs
                .Where(x => x.MaDonMua.Equals(MDM))
                .Select(x => new ThongTinHoaDonModel
                {
                    MaHD = x.MaDonMua,
                    MaKH = x.MaKH,
                    SDT = x.KHACHHANG.SDT.ToString(),
                    DiaChi = x.KHACHHANG.DiaChi,
                    NgayMua = x.NgayMua.ToString(),
                    Ten = x.KHACHHANG.TenKH
                }).FirstOrDefault();
            textBox4.Text = thongTinHoaDon.MaHD;
            textBox5.Text = thongTinHoaDon.MaKH;
            textBox3.Text = thongTinHoaDon.SDT;
            textBox8.Text = thongTinHoaDon.NgayMua;
            textBox7.Text = thongTinHoaDon.DiaChi;
            textBox9.Text = thongTinHoaDon.Ten;
            label8.Text = "Tổng tiền: " + Tong.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
