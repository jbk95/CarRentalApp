namespace CarRentalApp
{
	partial class AddEditVehicle
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tbLicense = new System.Windows.Forms.TextBox();
			this.tbYear = new System.Windows.Forms.TextBox();
			this.tbVin = new System.Windows.Forms.TextBox();
			this.tbModel = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tbMake = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblid = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.tbLicense, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.tbYear, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.tbVin, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.tbModel, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.tbMake, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 113);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 233);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tbLicense
			// 
			this.tbLicense.Location = new System.Drawing.Point(395, 187);
			this.tbLicense.Name = "tbLicense";
			this.tbLicense.Size = new System.Drawing.Size(204, 22);
			this.tbLicense.TabIndex = 13;
			// 
			// tbYear
			// 
			this.tbYear.Location = new System.Drawing.Point(395, 141);
			this.tbYear.Name = "tbYear";
			this.tbYear.Size = new System.Drawing.Size(204, 22);
			this.tbYear.TabIndex = 12;
			// 
			// tbVin
			// 
			this.tbVin.Location = new System.Drawing.Point(395, 95);
			this.tbVin.Name = "tbVin";
			this.tbVin.Size = new System.Drawing.Size(204, 22);
			this.tbVin.TabIndex = 11;
			// 
			// tbModel
			// 
			this.tbModel.Location = new System.Drawing.Point(395, 49);
			this.tbModel.Name = "tbModel";
			this.tbModel.Size = new System.Drawing.Size(204, 22);
			this.tbModel.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Make";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "Model";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 92);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 16);
			this.label6.TabIndex = 4;
			this.label6.Text = "VIN";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 138);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(36, 16);
			this.label8.TabIndex = 6;
			this.label8.Text = "Year";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 184);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(139, 16);
			this.label10.TabIndex = 8;
			this.label10.Text = "License Plate Number";
			// 
			// tbMake
			// 
			this.tbMake.Location = new System.Drawing.Point(395, 3);
			this.tbMake.Name = "tbMake";
			this.tbMake.Size = new System.Drawing.Size(204, 22);
			this.tbMake.TabIndex = 9;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(13, 372);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(288, 66);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save Changes";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(500, 372);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(288, 66);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(106, 21);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(0, 60);
			this.lblTitle.TabIndex = 2;
			// 
			// lblid
			// 
			this.lblid.AutoSize = true;
			this.lblid.Location = new System.Drawing.Point(405, 94);
			this.lblid.Name = "lblid";
			this.lblid.Size = new System.Drawing.Size(0, 16);
			this.lblid.TabIndex = 3;
			// 
			// AddEditVehicle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblid);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "AddEditVehicle";
			this.Text = "Add Edit Vehicle";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox tbLicense;
		private System.Windows.Forms.TextBox tbYear;
		private System.Windows.Forms.TextBox tbVin;
		private System.Windows.Forms.TextBox tbModel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tbMake;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblid;
	}
}