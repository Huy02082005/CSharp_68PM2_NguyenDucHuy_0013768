using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            LoadDuLieuMau();
        }

        private void LoadDuLieuMau()
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UC_QLSV ucQLSV = new UC_QLSV();
            panel1.Controls.Clear();
            panel1.Controls.Add(ucQLSV);
        }

        private void quảnLíSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_QLSV ucQLSV = new UC_QLSV();
            panel1.Controls.Clear();
            panel1.Controls.Add(ucQLSV);
        }

        private void quảnLíLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_QLLH ucQLLH = new UC_QLLH();
            panel1.Controls.Clear();
            panel1.Controls.Add(ucQLLH);
        }
    }
}