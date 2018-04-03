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
    public partial class FormListStudentWithQuery : Form
    {
        public FormListStudentWithQuery()
        {
            InitializeComponent();
        }

        private void FormListStudentWithQuery_Load(object sender, EventArgs e)
        {

            using (ModelTD db = new ModelTD())
            {
                CrystalReportQuery crystalReportQuery = new CrystalReportQuery();

                var query = from s in db.Students.Include("Group")
                        select new { s.LastName, Name = s.Group.Name,s.GroupId };
                crystalReportQuery.SetDataSource(query);
                crystalReportViewer1.ReportSource = crystalReportQuery;

            }
        }
    }
}
