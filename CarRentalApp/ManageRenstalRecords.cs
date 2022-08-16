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
	public partial class ManageRenstalRecords : Form
	{
		private readonly CarRentalEntities _db;

		public ManageRenstalRecords()
		{
			InitializeComponent();
			_db = new CarRentalEntities();
		}

		private void btnAddRecord_Click(object sender, EventArgs e)
		{
			var addRentalRecord = new AddEditRentalRecord();
			addRentalRecord.MdiParent = this.MdiParent;
			addRentalRecord.Show();
		}

		private void btnEditRecord_Click(object sender, EventArgs e)
		{
			//get Id of selected row
			var id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;
			//query database for record
			var record = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);
			//launch AddEditVehicle window with data
			var addEditVehicle = new AddEditVehicle(record);
			addEditVehicle.Show();
		}

		private void btnDeleteRecord_Click(object sender, EventArgs e)
		{
			try
			{
				//get Id of selected row
				var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
				//query database for record
				var record = _db.TypeOfCars.FirstOrDefault(q => q.id == id);

				// delete vehicle from table
				_db.TypeOfCars.Remove(record);
				_db.SaveChanges();

				gvVehicleList.Refresh();

				PopulateGrid();

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void ManageRenstalRecords_Load(object sender, EventArgs e)
		{
			try
			{
				PopulateGrid();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		public void PopulateGrid()
		{
			var records = _db.CarRentalRecords.Select(q => new
			{
				Customer = q.CustomerName,
				DateOut = q.DateRented,
				DateIn = q.DateReturned,
				Id = q.id,
				q.Cost,
				Car = q.TypeOfCar.Make + " " + q.TypeOfCar.Model
			}).ToList();
			gvRecordList.DataSource = records;
			gvRecordList.Columns["DateIn"].HeaderText = "Date In";
			gvRecordList.Columns["DateOut"].HeaderText = "Date Out";
			// Hide the column for id.
			gvRecordList.Columns["id"].Visible = false;
		}
	}
}
