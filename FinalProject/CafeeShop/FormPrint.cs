using Cafee.BUS;
using Cafee.DAO;
using Cafee.DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeeShop
{
    public partial class FormPrint : Form
    {
        double _totalPriceBill;
        Table _table;
        Bill _bill;
        double _inputMoney;
        public FormPrint(
            Bill bill,
            Table table,
            double totalPriceBill,
            double inputMoney
            )
        {
            InitializeComponent();
            _bill = bill;
            _table = table;
            _totalPriceBill = totalPriceBill;
            _inputMoney = inputMoney;
        }
        private void FormPrint_Load(object sender, EventArgs e)
        {

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            List<Cafee.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(_table.id);
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSetMenu";
            reportDataSource.Value = listBillInfo;
            string date = ((DateTime)_bill.DateCheckOut).ToString("dd/MM/yyyy HH:mm:ss");
            Employees employees = EmployeesBUS.Instance.GetDetail(_bill.idEmployees);
            ReportParameter[] p = new ReportParameter[]
            {
                new ReportParameter("pNameEmployees",employees.name),
                new ReportParameter("pDataTime",date),
                new ReportParameter("pDicount",_bill.discount+"%"),
                new ReportParameter("pTableName",_table.name),
                new ReportParameter("pIdBill",_bill.id.ToString()),
                new ReportParameter("pTotalPrice",_totalPriceBill.ToString("#,###", cul.NumberFormat)),
                new ReportParameter("pfinalTotalPrice",_bill.total.ToString("#,###", cul.NumberFormat)),
                new ReportParameter("pInputMoney",_inputMoney.ToString("#,###", cul.NumberFormat)),
                new ReportParameter("pMoneyRetrun",(_inputMoney-_bill.total).ToString("#,###", cul.NumberFormat))
            };
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
