namespace TwoForms
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.eNametxt = new System.Windows.Forms.TextBox();
			this.jobtxt = new System.Windows.Forms.TextBox();
			this.salarytxt = new System.Windows.Forms.TextBox();
			this.dNametxt = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.idtxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(163, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ename";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(163, 172);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Job";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(163, 215);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Salary";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(163, 264);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Dname";
			// 
			// eNametxt
			// 
			this.eNametxt.Location = new System.Drawing.Point(294, 131);
			this.eNametxt.Name = "eNametxt";
			this.eNametxt.Size = new System.Drawing.Size(100, 26);
			this.eNametxt.TabIndex = 6;
			// 
			// jobtxt
			// 
			this.jobtxt.Location = new System.Drawing.Point(294, 172);
			this.jobtxt.Name = "jobtxt";
			this.jobtxt.Size = new System.Drawing.Size(100, 26);
			this.jobtxt.TabIndex = 7;
			// 
			// salarytxt
			// 
			this.salarytxt.Location = new System.Drawing.Point(294, 215);
			this.salarytxt.Name = "salarytxt";
			this.salarytxt.Size = new System.Drawing.Size(100, 26);
			this.salarytxt.TabIndex = 8;
			// 
			// dNametxt
			// 
			this.dNametxt.Location = new System.Drawing.Point(294, 258);
			this.dNametxt.Name = "dNametxt";
			this.dNametxt.Size = new System.Drawing.Size(100, 26);
			this.dNametxt.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(140, 363);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 48);
			this.button1.TabIndex = 10;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(319, 363);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(84, 48);
			this.button2.TabIndex = 11;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(521, 363);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(81, 48);
			this.button3.TabIndex = 12;
			this.button3.Text = "Close";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(164, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 20);
			this.label1.TabIndex = 13;
			this.label1.Text = "ID";
			// 
			// idtxt
			// 
			this.idtxt.Location = new System.Drawing.Point(294, 85);
			this.idtxt.Name = "idtxt";
			this.idtxt.Size = new System.Drawing.Size(100, 26);
			this.idtxt.TabIndex = 14;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.idtxt);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dNametxt);
			this.Controls.Add(this.salarytxt);
			this.Controls.Add(this.jobtxt);
			this.Controls.Add(this.eNametxt);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "Form2";
			this.Text = " ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		internal System.Windows.Forms.TextBox eNametxt;
		internal System.Windows.Forms.TextBox jobtxt;
		internal System.Windows.Forms.TextBox salarytxt;
		internal System.Windows.Forms.TextBox dNametxt;
		private System.Windows.Forms.Label label1;
		internal System.Windows.Forms.TextBox idtxt;
	}
}