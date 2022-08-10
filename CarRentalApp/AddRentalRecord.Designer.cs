namespace CarRentalApp
{
	partial class AddRentalRecord
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbCustomerName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dtRented = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dtReturned = new System.Windows.Forms.DateTimePicker();
			this.cbTypeOfCar = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.tbCost = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(216, 41);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(414, 49);
			this.label1.TabIndex = 0;
			this.label1.Text = "Add Rental Record";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// tbCustomerName
			// 
			this.tbCustomerName.Location = new System.Drawing.Point(34, 209);
			this.tbCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbCustomerName.Name = "tbCustomerName";
			this.tbCustomerName.Size = new System.Drawing.Size(368, 26);
			this.tbCustomerName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 175);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Customer Name";
			// 
			// dtRented
			// 
			this.dtRented.Location = new System.Drawing.Point(34, 298);
			this.dtRented.Name = "dtRented";
			this.dtRented.Size = new System.Drawing.Size(363, 26);
			this.dtRented.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 270);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Date Rented";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(457, 261);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Date Returned";
			// 
			// dtReturned
			// 
			this.dtReturned.Location = new System.Drawing.Point(457, 298);
			this.dtReturned.Name = "dtReturned";
			this.dtReturned.Size = new System.Drawing.Size(363, 26);
			this.dtReturned.TabIndex = 5;
			// 
			// cbTypeOfCar
			// 
			this.cbTypeOfCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTypeOfCar.FormattingEnabled = true;
			this.cbTypeOfCar.Location = new System.Drawing.Point(34, 381);
			this.cbTypeOfCar.Name = "cbTypeOfCar";
			this.cbTypeOfCar.Size = new System.Drawing.Size(363, 28);
			this.cbTypeOfCar.TabIndex = 7;
			this.cbTypeOfCar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(34, 353);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Type of Car";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(719, 406);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(232, 108);
			this.button1.TabIndex = 9;
			this.button1.Text = "Submit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(452, 175);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "Cost";
			// 
			// tbCost
			// 
			this.tbCost.Location = new System.Drawing.Point(452, 209);
			this.tbCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbCost.Name = "tbCost";
			this.tbCost.Size = new System.Drawing.Size(368, 26);
			this.tbCost.TabIndex = 10;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(38, 446);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(206, 48);
			this.button2.TabIndex = 12;
			this.button2.Text = "Launch Main Window";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// AddRentalRecord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(930, 506);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbCost);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbTypeOfCar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtReturned);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtRented);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbCustomerName);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "AddRentalRecord";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbCustomerName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtRented;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtReturned;
		private System.Windows.Forms.ComboBox cbTypeOfCar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbCost;
		private System.Windows.Forms.Button button2;
	}
}

