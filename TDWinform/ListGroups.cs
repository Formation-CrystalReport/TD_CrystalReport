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
    public partial class ListGroups : Form
    {
        public ListGroups()
        {
            InitializeComponent();
        }

        private void ListGroups_Load(object sender, EventArgs e)
        {
            using (ModelTD db = new ModelTD())
            {
                CrystalReportListGroup crystalReportListGroup = new CrystalReportListGroup();
                crystalReportListGroup.SetDataSource(db.Groups);
                crystalReportViewer1.ReportSource = crystalReportListGroup;
            }

        }
    }
}
