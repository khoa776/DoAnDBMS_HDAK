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
namespace DoAnDBMS
{
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
        }


        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a, b, c;

            // Kiểm tra dữ liệu nhập
            if (!double.TryParse(txtA.Text, out a) ||
                !double.TryParse(txtB.Text, out b) ||
                !double.TryParse(txtC.Text, out c) ||
                double.IsNaN(a) || double.IsInfinity(a) ||
                double.IsNaN(b) || double.IsInfinity(b) ||
                double.IsNaN(c) || double.IsInfinity(c))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ 3 hệ số hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string sql = "SELECT dbo.fn_GiaiPTBac2(@a, @b, @c)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@a", SqlDbType.Float).Value = a;
                        cmd.Parameters.Add("@b", SqlDbType.Float).Value = b;
                        cmd.Parameters.Add("@c", SqlDbType.Float).Value = c;

                        object ketQua = cmd.ExecuteScalar();

                        txtKetQua.Text = Convert.ToString(ketQua);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi giải phương trình: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    MessageBox.Show(
                        "Kết nối SQL Server thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Kết nối thất bại: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtKetQua.Clear();
            txtA.Focus();
        }
    }
}
