using Cafee.DAO;
using Cafee.DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafee
{
    public partial class FormPrintBill : Form
    {
        int _discount;
        int _idTable;
        string _nameTable;
        double _finalTotalPrice;
        public FormPrintBill(int discount, int idTable,
        string nameTable,
        double finalTotalPrice)
        {
            InitializeComponent();
            this._discount = discount;
            _idTable = idTable;
            _nameTable = nameTable;
            _finalTotalPrice = finalTotalPrice;
        }

        private void FormPrintBill_Load(object sender, EventArgs e)
        {
            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(_idTable);
            this.menuBindingSource.DataSource = listBillInfo;
            //ReportDataSource rds = new ReportDataSource();
            //rds.Name = "tblMatHang";
            //rds.Value = data;
            ReportParameter[] p = new ReportParameter[]
            {
                new ReportParameter("pDicount",_discount+"%"),
                new ReportParameter("pTableName",_nameTable),
                new ReportParameter("pfinalTotalPrice",_finalTotalPrice.ToString("0.000"))
            };
            this.reportViewer1.LocalReport.SetParameters(p);
            ////this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
