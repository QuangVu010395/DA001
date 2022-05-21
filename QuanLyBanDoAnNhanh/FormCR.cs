using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanDoAnNhanh
{
    public partial class FormCR : Form
    {
        public FormCR()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FormCR_Load(object sender, EventArgs e)
        {
            Classketnoi connect = new Classketnoi();
            SqlConnection conn = connect.ketnoi();
            if (connect.getloi() == "")
            {

                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "SELECT dbo.Bill.totalPrice, dbo.Bill.idTable, dbo.Bill.id, dbo.Bill.DateCheckIn, dbo.Bill.DateCheckOut FROM dbo.Bill INNER JOIN dbo.BillInfo ON dbo.Bill.id = dbo.BillInfo.idBill";
                SqlDataReader data1 = com.ExecuteReader();
                DataTable tBview = new DataTable();
                tBview.Load(data1);
                CrystalReport1 rp = new CrystalReport1();
                rp.SetDataSource(tBview);
                crystalReportViewer1.ReportSource = rp;
            }
        }
    }
}
