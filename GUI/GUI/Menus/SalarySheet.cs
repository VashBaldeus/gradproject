using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Menus
{
    public partial class SalarySheet : Form
    {
        public SalarySheet()
        {
            InitializeComponent();
        }

        private void SalarySheet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hrDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.hrDataSet.employees);
            // TODO: This line of code loads data into the 'hrDataSet.reports' table. You can move, or remove it, as needed.
            this.reportsTableAdapter.Fill(this.hrDataSet.reports);

            using (hrDataSetTableAdapters.employeesTableAdapter db = new hrDataSetTableAdapters.employeesTableAdapter())
            {
                using (DataTable dt = db.GetData())
                {//pulls the data of the employees table from database;
                    employeesBindingSource.DataSource = dt.Select($"eid={Properties.Settings.Default.tempid} OR id={Properties.Settings.Default.tempid}").ToList();//filters the data according to previous sent query;
                }
            }

            if (Properties.Settings.Default.archive != true)
            {
                using (hrDataSetTableAdapters.reportsTableAdapter db = new hrDataSetTableAdapters.reportsTableAdapter())
                {//pulls the data of the reports table from the database;
                    #region Calculations Reports
                    using (DataTable dt = db.GetData())
                    {
                        using (DataTable sdt = new DataTable())
                        {
                            #region DataTable Columns;
                            sdt.Columns.Add("salary");//add the columns into the DataTable;
                            sdt.Columns.Add("salary125");
                            sdt.Columns.Add("salary150");
                            sdt.Columns.Add("salary175");
                            sdt.Columns.Add("salary200");
                            sdt.Columns.Add("salary_pay");
                            sdt.Columns.Add("salary125_pay");
                            sdt.Columns.Add("salary150_pay");
                            sdt.Columns.Add("salary175_pay");
                            sdt.Columns.Add("salary200_pay");
                            sdt.Columns.Add("social_security");
                            sdt.Columns.Add("health_tax");
                            sdt.Columns.Add("salaryBruto");
                            sdt.Columns.Add("salaryNeto");
                            sdt.Columns.Add("retirement");
                            sdt.Columns.Add("income_tax");
                            #endregion

                            double salary = 0, salary125 = 0, salary150 = 0, salary175 = 0, salary200 = 0, salary_pay = 0,
                                salary125_pay = 0, salary150_pay = 0, salary175_pay = 0, salary200_pay = 0, social_security = 0, health_tax = 0,
                                salaryBruto = 0, salaryNeto = 0, income_tax = 0, retirement = 0;//variables for salary arithmetic calculations;

                            foreach (DataRow dr in dt.Select(Properties.Settings.Default.temp))
                            {
                                if (double.Parse(dr["total_hours"].ToString()) > 8)
                                {
                                    double temp = double.Parse(dr["total_hours"].ToString());//used to calculate the salary;
                                    if (double.Parse(dr["total_hours"].ToString()) > 10)
                                    {
                                        salary150 += temp - 10;//calculates 150% salary count;
                                        salary125 += temp - 10;//calculates 125% salary count;
                                        salary += temp - 4;//calculates 100% salary count;
                                    }
                                    else
                                    {
                                        salary125 += temp - 8;//calculates 125% salary count;
                                        salary += temp - 2;//calculates 100% salary count;
                                    }
                                }
                                else salary += double.Parse(dr["total_hours"].ToString());

                                salary_pay = salary * 28.50;//total salary 100%
                                salary125_pay = salary125 * 28.50 * 1.25;//total salary 125%
                                salary150_pay = salary150 * 28.50 * 1.5;//total salary 150%
                            }
                            salaryBruto = salary_pay + salary125_pay + salary150_pay;//calculate salary bruto

                            retirement = salaryBruto * 0.06;

                            if (salaryBruto <= 5450)
                            {
                                social_security = salaryBruto * 0.004;//calculate social security total
                                health_tax = salaryBruto * 0.031;//calculate health tax total
                            }
                            else
                            {
                                social_security = ((salaryBruto - 5450) * 0.07) + ((salaryBruto - (salaryBruto - 5450)) * 0.004);//calculate social security total
                                health_tax = ((salaryBruto - 5450) * 0.05) + ((salaryBruto - (salaryBruto - 5450)) * 0.031);//calculate health tax total
                            }

                            if (salaryBruto > 53333)
                                income_tax += (salaryBruto - 53333) * 0.5;

                            if (salaryBruto > 41410)
                                income_tax += 5605.22;

                            if (salaryBruto > 19900)
                                income_tax += 7528.15;

                            if (salaryBruto > 14320)
                                income_tax += 1729.49;

                            if (salaryBruto > 8920)
                                income_tax += 1079.8;

                            if (salaryBruto > 6220)
                                income_tax += 377.86;

                            salaryNeto = salaryBruto - social_security - health_tax - income_tax - retirement;//calculate salary Neto;

                            sdt.Rows.Add(salary, salary125, salary150, salary175, salary200, salary_pay, salary125_pay, salary150_pay,
                                    salary175_pay, salary200_pay, social_security, health_tax, salaryBruto, salaryNeto, retirement, income_tax);//inputs the data into the DataTable;
                            salaryDataTableBindingSource.DataSource = sdt;//links the DataTable to the DataSet in order to properly show it on the report;
                        }
                    }
                    #endregion
                }
            }
            else
            {
                using (hrDataSetTableAdapters.archived_reportsTableAdapter db = new hrDataSetTableAdapters.archived_reportsTableAdapter())
                {//pulls the data of the reports table from the database;
                    #region Calculations Reports
                    using (DataTable dt = db.GetData())
                    {
                        using (DataTable sdt = new DataTable())
                        {
                            #region DataTable Columns;
                            sdt.Columns.Add("salary");//add the columns into the DataTable;
                            sdt.Columns.Add("salary125");
                            sdt.Columns.Add("salary150");
                            sdt.Columns.Add("salary175");
                            sdt.Columns.Add("salary200");
                            sdt.Columns.Add("salary_pay");
                            sdt.Columns.Add("salary125_pay");
                            sdt.Columns.Add("salary150_pay");
                            sdt.Columns.Add("salary175_pay");
                            sdt.Columns.Add("salary200_pay");
                            sdt.Columns.Add("social_security");
                            sdt.Columns.Add("health_tax");
                            sdt.Columns.Add("salaryBruto");
                            sdt.Columns.Add("salaryNeto");
                            sdt.Columns.Add("retirement");
                            sdt.Columns.Add("income_tax");
                            #endregion

                            double salary = 0, salary125 = 0, salary150 = 0, salary175 = 0, salary200 = 0, salary_pay = 0,
                                salary125_pay = 0, salary150_pay = 0, salary175_pay = 0, salary200_pay = 0, social_security = 0, health_tax = 0,
                                salaryBruto = 0, salaryNeto = 0, income_tax = 0, retirement = 0;//variables for salary arithmetic calculations;

                            foreach (DataRow dr in dt.Select(Properties.Settings.Default.temp))
                            {
                                if (double.Parse(dr["total_hours"].ToString()) > 8)
                                {
                                    double temp = double.Parse(dr["total_hours"].ToString());//used to calculate the salary;
                                    if (double.Parse(dr["total_hours"].ToString()) > 10)
                                    {
                                        salary150 += temp - 10;//calculates 150% salary count;
                                        salary125 += temp - 10;//calculates 125% salary count;
                                        salary += temp - 4;//calculates 100% salary count;
                                    }
                                    else
                                    {
                                        salary125 += temp - 8;//calculates 125% salary count;
                                        salary += temp - 2;//calculates 100% salary count;
                                    }
                                }
                                else salary += double.Parse(dr["total_hours"].ToString());

                                salary_pay = salary * 28.50;//total salary 100%
                                salary125_pay = salary125 * 28.50 * 1.25;//total salary 125%
                                salary150_pay = salary150 * 28.50 * 1.5;//total salary 150%
                            }
                            salaryBruto = salary_pay + salary125_pay + salary150_pay;//calculate salary bruto

                            retirement = salaryBruto * 0.06;

                            if (salaryBruto <= 5450)
                            {
                                social_security = salaryBruto * 0.004;//calculate social security total
                                health_tax = salaryBruto * 0.031;//calculate health tax total
                            }
                            else
                            {
                                social_security = ((salaryBruto - 5450) * 0.07) + ((salaryBruto - (salaryBruto - 5450)) * 0.004);//calculate social security total
                                health_tax = ((salaryBruto - 5450) * 0.05) + ((salaryBruto - (salaryBruto - 5450)) * 0.031);//calculate health tax total
                            }

                            if (salaryBruto > 53333)
                                income_tax += (salaryBruto - 53333) * 0.5;

                            if (salaryBruto > 41410)
                                income_tax += 5605.22;

                            if (salaryBruto > 19900)
                                income_tax += 7528.15;

                            if (salaryBruto > 14320)
                                income_tax += 1729.49;

                            if (salaryBruto > 8920)
                                income_tax += 1079.8;

                            if (salaryBruto > 6220)
                                income_tax += 377.86;

                            salaryNeto = salaryBruto - social_security - health_tax - income_tax - retirement;//calculate salary Neto;

                            sdt.Rows.Add(salary, salary125, salary150, salary175, salary200, salary_pay, salary125_pay, salary150_pay,
                                    salary175_pay, salary200_pay, social_security, health_tax, salaryBruto, salaryNeto, retirement, income_tax);//inputs the data into the DataTable;
                            salaryDataTableBindingSource.DataSource = sdt;//links the DataTable to the DataSet in order to properly show it on the report;
                        }
                    }
                    #endregion
                }
            }

            this.reportViewer1.RefreshReport();//reload the report to take effect of changes to DataSet data;
        }

        private void SalarySheet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.archive = false;//reset the statement of the variables for repeat use;
            Properties.Settings.Default.tempid = "";
            Properties.Settings.Default.temp = "";
        }
    }
}
