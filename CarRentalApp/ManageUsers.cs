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
	public partial class ManageUsers : Form
	{
		private readonly CarRentalEntities _db;

		public ManageUsers()
		{
			InitializeComponent();
			_db = new CarRentalEntities();
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			if (!Utils.FormIsOpen("AddUser"))
			{
				var addUser = new AddUser();
				addUser.MdiParent = this.MdiParent;
				addUser.Show();
			}
		}

		private void btnResetPassword_Click(object sender, EventArgs e)
		{
			try
			{
				//get Id of selected row
				var id = (int)gvUserList.SelectedRows[0].Cells["id"].Value;

				//query database for record
				var user = _db.Users.FirstOrDefault(q => q.id == id);
				//var genericPassword = "Password@123";
				//var hashed_password = Utils.HashPassword(genericPassword);
				var hashed_password = Utils.DefaultHashedPassword();
				user.password = hashed_password;
				_db.SaveChanges();

				MessageBox.Show($"{user.username}'s Password has been reset!");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void btnDeactivateUser_Click(object sender, EventArgs e)
		{
			try
			{
				//get Id of selected row
				var id = (int)gvUserList.SelectedRows[0].Cells["id"].Value;

				//query database for record
				var user = _db.Users.FirstOrDefault(q => q.id == id);
				user.isActive = user.isActive == true ? false : true;
				_db.SaveChanges();

				MessageBox.Show($"{user.username}'s Password has been reset!");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void ManageUsers_Load(object sender, EventArgs e)
		{
			PopulateGrid();
		}

		public void PopulateGrid()
		{
			var cars = _db.Users
				.Select(q => new
				{
					q.id,
					q,
					username,
					q.UserRoles.FirstOrDefault().Role.name,
					q.isActive
				})
				.ToList();
			gvUserList.DataSource = cars;
			gvUserList.Columns["username"].HeaderText = "Username";
			gvUserList.Columns["name"].HeaderText = "Role Name";
			gvUserList.Columns["isActive"].HeaderText = "Active";
		}
	}
}
