using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhToan_52_Hao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cong_52_Hao_Click(object sender, EventArgs e)
        {
            int a_52_Hao, b_52_Hao, ketqua_52_Hao;
            a_52_Hao = int.Parse(txt_1_52_Hao.Text);
            b_52_Hao = int.Parse(txt_2_52_Hao.Text);
            TinhPhepToan_52_Hao c = new TinhPhepToan_52_Hao(a_52_Hao, b_52_Hao);
            ketqua_52_Hao = c.Execute_52_Hao("+");
            txtKQ_52_Hao.Text = ketqua_52_Hao.ToString();
        }

        private void btn_Tru_52_Hao_Click(object sender, EventArgs e)
        {
            int a_52_Hao, b_52_Hao, ketqua_52_Hao;
            a_52_Hao = int.Parse(txt_1_52_Hao.Text);
            b_52_Hao = int.Parse(txt_2_52_Hao.Text);
            TinhPhepToan_52_Hao c = new TinhPhepToan_52_Hao(a_52_Hao, b_52_Hao);
            ketqua_52_Hao = c.Execute_52_Hao("-");
            txtKQ_52_Hao.Text = ketqua_52_Hao.ToString();
        }

        private void btn_Nhan_52_Hao_Click(object sender, EventArgs e)
        {
            int a_52_Hao, b_52_Hao, ketqua_52_Hao;
            a_52_Hao = int.Parse(txt_1_52_Hao.Text);
            b_52_Hao = int.Parse(txt_2_52_Hao.Text);
            TinhPhepToan_52_Hao c = new TinhPhepToan_52_Hao(a_52_Hao, b_52_Hao);
            ketqua_52_Hao = c.Execute_52_Hao("*");
            txtKQ_52_Hao.Text = ketqua_52_Hao.ToString();
        }

        private void btn_Chia_52_Hao_Click(object sender, EventArgs e)
        {
            int a_52_Hao, b_52_Hao, ketqua_52_Hao;
            a_52_Hao = int.Parse(txt_1_52_Hao.Text);
            b_52_Hao = int.Parse(txt_2_52_Hao.Text);
            TinhPhepToan_52_Hao c = new TinhPhepToan_52_Hao(a_52_Hao, b_52_Hao);
            ketqua_52_Hao = c.Execute_52_Hao("/");
            txtKQ_52_Hao.Text = ketqua_52_Hao.ToString();
        }
    }
}
