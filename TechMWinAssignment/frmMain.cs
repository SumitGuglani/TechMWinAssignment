using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace TechMWinAssignment
{
    public partial class frmMain : Form
    {
        private IList<EmployeeInput> inputList;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnUploadCSV_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofileDialog = new OpenFileDialog();

            ofileDialog.Filter = "Csv files (*.csv)|*.csv";
            DialogResult dialogResult = ofileDialog.ShowDialog();
            if (ofileDialog.FileName != null)
            {
                string str = ofileDialog.FileName;
                ReadInputFileAsync(str);
            }

        }

        private async void ReadInputFileAsync(string inputfilePath)
        {
            try
            {
                using (StreamReader file = new StreamReader(inputfilePath))
                {
                    int counter = 0;
                    string ln;
                    inputList = new List<EmployeeInput>();
                    while ((ln = await file.ReadLineAsync()) != null)
                    {
                        string[] strArr = ln.Split(',');
                        DateTime dt = DateTime.ParseExact(strArr[4], "ddMMyyyy", new CultureInfo("en-US"));
                        EmployeeInput input = new EmployeeInput(strArr[0], strArr[1], Convert.ToInt32(strArr[2]), Convert.ToInt32(strArr[3].Substring(0, strArr[3].Length - 1)), dt);
                        inputList.Add(input);
                        counter++;
                    }

                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }
        private EmployeeOutput GenerateEmployeeOutput(EmployeeInput employeeInput)
        {
            EmployeeOutput employeeOutput = new EmployeeOutput();
            employeeOutput.Name = employeeInput.FirstName + " " + employeeInput.LastName;
            employeeOutput.PayPeriod = employeeInput.PaymentStartDate.ToString("dd/MMM/yyyy", CultureInfo.CreateSpecificCulture("en-US")) + " - " +
                                        (new DateTime(employeeInput.PaymentStartDate.Year, employeeInput.PaymentStartDate.Month, 1).AddMonths(1).AddDays(-1)).ToString("dd/MMM/yyyy", CultureInfo.CreateSpecificCulture("en-ES"));
            employeeOutput.GrossIncome = Math.Round(employeeInput.AnnualSalary / 12);
            employeeOutput.IncomeTax = Math.Round(SalaryCalculation.CalculateTax(employeeInput.AnnualSalary));
            employeeOutput.NetIncome = Math.Round(employeeOutput.GrossIncome - employeeOutput.IncomeTax);
            employeeOutput.Super = Math.Round(employeeOutput.GrossIncome * (employeeInput.SuperRate / 100));
            return employeeOutput;
        }
        private async void WriteOutputFileAsync()
        {
            try
            {
                saveFileDlg.Filter = "csv files (*.csv)|*.csv";
                DialogResult dlgResult = saveFileDlg.ShowDialog();
                if (saveFileDlg.FileName != null)
                {
                    using (StreamWriter outfile = new StreamWriter(saveFileDlg.FileName))
                    {
                        foreach (EmployeeInput ei in inputList)
                        {
                            EmployeeOutput eo = GenerateEmployeeOutput(ei);
                            await outfile.WriteLineAsync(eo.Name + "," + eo.PayPeriod + "," + eo.GrossIncome + "," + eo.IncomeTax + "," + eo.NetIncome + "," + eo.Super);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btnDownloadCSV_Click(object sender, EventArgs e)
        {

            if (inputList != null && inputList.Count() > 0)
            {
                WriteOutputFileAsync();
            }
            else
            {
                MessageBox.Show("No more employees data to export", "Message");
            }
        }


    }
}
