namespace CarRentalApp
{
	partial class ResetPassword
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
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbConfirmedPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(160, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter New Password";
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(114, 70);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(219, 22);
			this.tbPassword.TabIndex = 1;
			// 
			// tbConfirmedPassword
			// 
			this.tbConfirmedPassword.Location = new System.Drawing.Point(114, 162);
			this.tbConfirmedPassword.Name = "tbConfirmedPassword";
			this.tbConfirmedPassword.Size = new System.Drawing.Size(219, 22);
			this.tbConfirmedPassword.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(160, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Confirm Password";
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(159, 207);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(116, 30);
			this.btnReset.TabIndex = 4;
			this.btnReset.Text = "Reset Password";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// ResetPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 267);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.tbConfirmedPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.label1);
			this.Name = "ResetPassword";
			this.Text = "ResetPassword";
			this.Load += new System.EventHandler(this.ResetPassword_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.TextBox tbConfirmedPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnReset;
	}
}