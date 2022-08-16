namespace CarRentalApp
{
	partial class ManageRenstalRecords
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
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnDeleteRecord = new System.Windows.Forms.Button();
			this.btnEditRecord = new System.Windows.Forms.Button();
			this.btnAddRecord = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.gvRecordList = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(0, 106);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 11;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			// 
			// btnDeleteRecord
			// 
			this.btnDeleteRecord.Location = new System.Drawing.Point(525, 453);
			this.btnDeleteRecord.Margin = new System.Windows.Forms.Padding(4);
			this.btnDeleteRecord.Name = "btnDeleteRecord";
			this.btnDeleteRecord.Size = new System.Drawing.Size(176, 86);
			this.btnDeleteRecord.TabIndex = 10;
			this.btnDeleteRecord.Text = "Delete Record";
			this.btnDeleteRecord.UseVisualStyleBackColor = true;
			this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
			// 
			// btnEditRecord
			// 
			this.btnEditRecord.Location = new System.Drawing.Point(280, 453);
			this.btnEditRecord.Margin = new System.Windows.Forms.Padding(4);
			this.btnEditRecord.Name = "btnEditRecord";
			this.btnEditRecord.Size = new System.Drawing.Size(176, 86);
			this.btnEditRecord.TabIndex = 9;
			this.btnEditRecord.Text = "Edit Record";
			this.btnEditRecord.UseVisualStyleBackColor = true;
			this.btnEditRecord.Click += new System.EventHandler(this.btnEditRecord_Click);
			// 
			// btnAddRecord
			// 
			this.btnAddRecord.Location = new System.Drawing.Point(43, 453);
			this.btnAddRecord.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddRecord.Name = "btnAddRecord";
			this.btnAddRecord.Size = new System.Drawing.Size(176, 86);
			this.btnAddRecord.TabIndex = 8;
			this.btnAddRecord.Text = "Add New Record";
			this.btnAddRecord.UseVisualStyleBackColor = true;
			this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(185, 37);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(624, 60);
			this.label1.TabIndex = 7;
			this.label1.Text = "Manage Rental Records";
			// 
			// gvRecordList
			// 
			this.gvRecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvRecordList.Location = new System.Drawing.Point(0, 136);
			this.gvRecordList.Margin = new System.Windows.Forms.Padding(4);
			this.gvRecordList.Name = "gvRecordList";
			this.gvRecordList.RowHeadersWidth = 51;
			this.gvRecordList.Size = new System.Drawing.Size(1013, 286);
			this.gvRecordList.TabIndex = 6;
			// 
			// ManageRenstalRecords
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1012, 576);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnDeleteRecord);
			this.Controls.Add(this.btnEditRecord);
			this.Controls.Add(this.btnAddRecord);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gvRecordList);
			this.Name = "ManageRenstalRecords";
			this.Text = "Manage Renstal Records";
			this.Load += new System.EventHandler(this.ManageRenstalRecords_Load);
			((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnDeleteRecord;
		private System.Windows.Forms.Button btnEditRecord;
		private System.Windows.Forms.Button btnAddRecord;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView gvRecordList;
	}
}