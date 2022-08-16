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
	public partial class MainWindow : Form
	{
		private Login _login;
		public string _RoleName;
		public User _user;

		public MainWindow(Login login, User user)
		{
			InitializeComponent();
			_login = login;
			//_RoleName = roleShortName;
			_user = user;
			_RoleName = user.UserRoles.FirstOrDefault().Role.shortname;
		}

		private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var addRentalRecord = new AddEditRentalRecord();
			addRentalRecord.ShowDialog();
			addRentalRecord.MdiParent = this;
		}

		private void manage(object sender, EventArgs e)
		{
			//Get a list of open forms and save as an object form
			var OpenForms = Application.OpenForms.Cast<Form>();
			//Check this form is open
			var isOpen = OpenForms.Any(q => q.Name == "ManageVehicleListin");
			if (!isOpen)
			{
				var vehicleListing = new ManageVehicleListing();
				vehicleListing.MdiParent = this;
				vehicleListing.Show();
			}
		}

		private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var manageRentalRecords = new ManageRenstalRecords();
			manageRentalRecords.MdiParent = this;
			manageRentalRecords.Show();
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			_login.Close();
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			if(_user.password == Utils.DefaultHashedPassword())
			{
				var resetPassword = new ResetPassword();
				resetPassword.ShowDialog();

			}
			
			var username = _user.username;
			tsiLoginText.Text = $"Logged In As: {username}";
			if(_RoleName != "admin")
			{
				manageUsersToolStripMenuItem.Visible = false;
			}
		}
	}
}
