using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoForms
{
	public partial class Form1 : Form
	{

		DataConnectivityDataContext dc;

		public Form1()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dc = new DataConnectivityDataContext();
			dataGridView1.DataSource = dc.Employees;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{

			if (dataGridView1.SelectedRows.Count > 0)
			{
				Form2 f2 = new Form2();

				f2.idtxt.ReadOnly = true;
				f2.idtxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
				f2.eNametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
				f2.jobtxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
				f2.salarytxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
				f2.dNametxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

				f2.ShowDialog();

				dc = new DataConnectivityDataContext();
				dataGridView1.DataSource = dc.Employees;

			} else
			{
				MessageBox.Show("Select a record for updation");
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				if (MessageBox.Show("Are You Sure?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
				{
					int eno = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
					Employee obj = dc.Employees.SingleOrDefault(E => E.emo == eno);
					dc.Employees.DeleteOnSubmit(obj);
					dc.SubmitChanges();
					dc = new DataConnectivityDataContext();
					dataGridView1.DataSource = dc.Employees;
				}	
			}
			else
			{
				MessageBox.Show("Select data to delete");
			}
		}
	}
}