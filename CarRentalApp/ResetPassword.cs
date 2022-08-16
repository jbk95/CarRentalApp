using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
	public partial class ResetPassword : Form
	{
		public readonly CarRentalEntities _db;
		private User _user;

		public ResetPassword(User user)
		{
			InitializeComponent();
			_db = new CarRentalEntities();
			_user = user;
		}

		private void ResetPassword_Load(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			try
			{
				var password = tbPassword.Text;
				var confirm_password = tbConfirmedPassword.Text;
				var user = _db.Users.FirstOrDefault(q => q.id == _user.id);

				if (password != confirm_password)
				{
					MessageBox.Show("Passwords do not match. Please Try again!");

				}

				user.password = Utils.HashPassword(password);
				_db.SaveChanges();
				MessageBox.Show("Password was resset successfully");
				Close();
			}
			catch (Exception)
			{
				MessageBox.Show("An Error has ocurred, please try again");
				//throw;
			}
		}
	}
}
