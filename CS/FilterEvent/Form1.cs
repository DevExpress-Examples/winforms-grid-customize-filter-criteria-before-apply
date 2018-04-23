using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.Data;

namespace FilterEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            DataSet ds = new DataSet();
            ds.ReadXml("nwind.xml");
            this.GridControl.DataSource = ds;
            this.GridControl.DataMember = "Orders";
            this.GridView.ActiveFilterCriteria = CriteriaOperator.Parse("Freight > 0");
        }

        private void GridView_SubstituteFilter(object sender, SubstituteFilterEventArgs e) {
            e.Filter &= CriteriaOperator.Parse("getyear(OrderDate) = ?", Convert.ToInt32(this.beiShowByYear.EditValue));
        }

        private void beiShowByYear_EditValueChanged(object sender, EventArgs e) {
            CriteriaOperator filter = this.GridView.ActiveFilterCriteria;
            this.GridView.BeginDataUpdate();
            try {
                this.GridView.ActiveFilterCriteria = null;
                this.GridView.ActiveFilterCriteria = filter;
            } finally {
                this.GridView.EndDataUpdate();
            }
        }
    }
}
