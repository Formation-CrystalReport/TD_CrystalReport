using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDWinform
{
    public partial class FormListStudents : Form
    {
        public FormListStudents()
        {
            InitializeComponent();
        }

        private void FormListStudents_Load(object sender, EventArgs e)
        {
            using (ModelTD db = new ModelTD())
            {
                CrystalReportListStudents crystalReport = new CrystalReportListStudents();
                crystalReport.SetDataSource(db.Students);
                crystalReportViewer1.ReportSource = crystalReport;
            }
        }
    }
}
