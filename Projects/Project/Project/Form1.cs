using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;
using ClassLibrary1;

namespace Project
{
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var EmpObj = new Employee_ProjectEntities())
            {
                //var emp = new emp();
                //emp.Empid = 1;
                //emp.Name = "Navi";
                //emp.Salary = 250000;
                //EmpObj.emps.Add(emp);
                //emp = new emp();
                //emp.Empid = 2;
                //emp.Name = "Nav";
                //emp.Salary = 250000;
                //EmpObj.emps.Add(emp);
                //emp = new emp();
                //emp.Empid = 3;
                //emp.Name = "Navpi";
                //emp.Salary = 250000;
                //EmpObj.emps.Add(emp);
                //EmpObj.SaveChanges();
                var emp = new Detail();
                emp.ID = i;
                emp.Name = textBox1.Text;
                emp.Salary = Convert.ToInt32(textBox2.Text);
                EmpObj.Details.Add(emp);
                EmpObj.SaveChanges();
                i++;
                MessageBox.Show("Records inserted");
            }
        }
    }
}
