using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoForms
{
	public partial class Form2 : Form
	{
		DataConnectivityDataContext dc;
		public Form2()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//string connectionString = @"Data Source=SP13884\SQLEXPRESS;Initial Catalog=myDatabase;Integrated Security=True";

			//using (SqlConnection cnn = new SqlConnection(connectionString))
			//{
			//	cnn.Open();
			//	string query = $"INSERT INTO Employee (Ename, Job, Salary, Dname) VALUES ('{eNametxt.Text}', '{jobtxt.Text}', '{salarytxt.Text}', '{dNametxt.Text}')";
			//	using (SqlCommand cmd = new SqlCommand(query,cnn))
			//	{
			//		cmd.ExecuteNonQuery();
			//	}
			//}

			dc = new DataConnectivityDataContext();

			if (!idtxt.ReadOnly)
			{
				Employee obj = new Employee();
				obj.emo = int.Parse(idtxt.Text);
				obj.Ename = eNametxt.Text;
				obj.Salary = int.Parse(salarytxt.Text);
				obj.Dname = dNametxt.Text;
				obj.Job = jobtxt.Text;


				dc.Employees.InsertOnSubmit(obj);
				dc.SubmitChanges();

				MessageBox.Show("Data Inserted");
			}
			else
			{
				Employee obj = dc.Employees.SingleOrDefault(E => E.emo == int.Parse(idtxt.Text));
				obj.Ename = eNametxt.Text;
				obj.Job = jobtxt.Text;
				obj.Salary = int.Parse(salarytxt.Text);
				obj.Dname = dNametxt.Text;
				dc.SubmitChanges();
				MessageBox.Show("Data Updated");
				
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			idtxt.Text = "";
			eNametxt.Text = "";
			jobtxt.Text = "";
			salarytxt.Text = "";
			dNametxt.Text = "";
		}
	}
}
