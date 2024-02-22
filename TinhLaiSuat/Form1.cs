using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhLaiSuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttinh_Click(object sender, EventArgs e)
        {
            decimal tienbandau;
            double laisuat;
            int nam;
            decimal ketqua;
            string daura;
            tienbandau = Convert.ToDecimal(txttienbandau.Text);
            laisuat = Convert.ToDouble(txtlaisuat.Text);
            nam = Convert.ToInt32(nudnam.Value);
            daura = "Năm\t Khoản tiền thu được gồm lãi suất \r\n";
            for(int nams = 1; nams <= nam; nams++)
            {
                ketqua = tienbandau + ((decimal)Math.Pow((1 + laisuat / 100), nams));
                daura += (nams + "\t" + string.Format("{0:C}", ketqua) + "\r\n");
            }
            rtbketqua.Text = daura;
        }
    }
}
