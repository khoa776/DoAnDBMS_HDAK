using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDBMS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            FormBai1 frm = new FormBai1();
            frm.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            FormBai2 frm = new FormBai2();
            frm.ShowDialog();
        }
    }
}
