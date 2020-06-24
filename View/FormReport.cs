using BusinessLogic.BindingModel;
using BusinessLogic.BusinessLogic;
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
using Unity;

namespace View
{
    public partial class FormReport : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ReportLogic logic;
        public FormReport(ReportLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        public void LoadData()
        {

            try
            {
                var dataSource = logic.GetAuthors();
                ReportDataSource source = new ReportDataSource("DataSet1", dataSource);
                reportViewer.LocalReport.DataSources.Add(source);
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            this.reportViewer.RefreshReport();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string fileName = "C:\\Users\\marin.LAPTOP-0TUFHPTU\\Рабочий стол\\универ\\data\\" + "Отчет.pdf";
            logic.SaveClientsToPdfFile(fileName);
            MessageBox.Show("Отправлено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
