namespace CarRentalApp
{
	partial class ManageUsers
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
			this.btnDeactivateUser = new System.Windows.Forms.Button();
			this.btnResetPassword = new System.Windows.Forms.Button();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.gvUserList = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gvUserList)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(9, 111);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 17;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			// 
			// btnDeactivateUser
			// 
			this.btnDeactivateUser.Location = new System.Drawing.Point(534, 458);
			this.btnDeactivateUser.Margin = new System.Windows.Forms.Padding(4);
			this.btnDeactivateUser.Name = "btnDeactivateUser";
			this.btnDeactivateUser.Size = new System.Drawing.Size(176, 86);
			this.btnDeactivateUser.TabIndex = 16;
			this.btnDeactivateUser.Text = "Deactivate User";
			this.btnDeactivateUser.UseVisualStyleBackColor = true;
			this.btnDeactivateUser.Click += new System.EventHandler(this.btnDeactivateUser_Click);
			// 
			// btnResetPassword
			// 
			this.btnResetPassword.Location = new System.Drawing.Point(289, 458);
			this.btnResetPassword.Margin = new System.Windows.Forms.Padding(4);
			this.btnResetPassword.Name = "btnResetPassword";
			this.btnResetPassword.Size = new System.Drawing.Size(176, 86);
			this.btnResetPassword.TabIndex = 15;
			this.btnResetPassword.Text = "Reset User Password";
			this.btnResetPassword.UseVisualStyleBackColor = true;
			this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
			// 
			// btnAddUser
			// 
			this.btnAddUser.Location = new System.Drawing.Point(52, 458);
			this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(176, 86);
			this.btnAddUser.TabIndex = 14;
			this.btnAddUser.Text = "Add New User";
			this.btnAddUser.UseVisualStyleBackColor = true;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(201, 26);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(383, 60);
			this.label1.TabIndex = 13;
			this.label1.Text = "Manage Users";
			// 
			// gvUserList
			// 
			this.gvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvUserList.Location = new System.Drawing.Point(9, 141);
			this.gvUserList.Margin = new System.Windows.Forms.Padding(4);
			this.gvUserList.Name = "gvUserList";
			this.gvUserList.RowHeadersWidth = 51;
			this.gvUserList.Size = new System.Drawing.Size(748, 286);
			this.gvUserList.TabIndex = 12;
			// 
			// ManageUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(799, 587);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnDeactivateUser);
			this.Controls.Add(this.btnResetPassword);
			this.Controls.Add(this.btnAddUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gvUserList);
			this.Name = "ManageUsers";
			this.Text = "ManageUsers";
			this.Load += new System.EventHandler(this.ManageUsers_Load);
			((System.ComponentModel.ISupportInitialize)(this.gvUserList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnDeactivateUser;
		private System.Windows.Forms.Button btnResetPassword;
		private System.Windows.Forms.Button btnAddUser;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView gvUserList;
	}
}