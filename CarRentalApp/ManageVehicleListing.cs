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
	public partial class ManageVehicleListing : Form
	{
		private readonly CarRentalEntities _db;

		public ManageVehicleListing()
		{
			InitializeComponent();
			_db = new CarRentalEntities();
		}

		private void ManageVehicleListing_Load(object sender, EventArgs e)
		{
			//Select * From Type Of Cars
			//var cars = _db.TypeOfCars.ToList();

			//Select ID as CarId, NAME AS CarName FROM TypesOfCars
			//var cars = _db.TypeOfCars.Select(q => new { CarId = q.id, CarName = q.Make}).ToList();
			var cars = _db.TypeOfCars.Select(q => new { Make = q.Make, Model = q.Model, VIN = q.VIN, Year = q.Year, LicensePlateNumber = q.LicensePlateNumber, Id = q.id }).ToList();
			gvVehicleList.DataSource = cars;
			gvVehicleList.Columns[4].HeaderText = "License Plate Number";
			gvVehicleList.Columns[5].Visible = false;
			//gvVehicleList.Columns[0].HeaderText = "ID";
			//gvVehicleList.Columns[1].HeaderText = "NAME";
		}

		private void btnAddCar_Click(object sender, EventArgs e)
		{
			AddEditVehicle addEditVehicle = new AddEditVehicle();
			addEditVehicle.MdiParent = this.MdiParent;
			addEditVehicle.Show();
		}

		private void btnEditCar_Click(object sender, EventArgs e)
		{
			//get Id of selected row
			var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
			//query database for record
			var car = _db.TypeOfCars.FirstOrDefault(q => q.id == id);
			//launch AddEditVehicle window with data
			var addEditVehicle = new AddEditVehicle(car);
			addEditVehicle.Show();
		}


		private void btnDeleteCar_Click(object sender, EventArgs e)
		{
			try
			{
				//get Id of selected row
				var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
				//query database for record
				var car = _db.TypeOfCars.FirstOrDefault(q => q.id == id);

				// delete vehicle from table
				_db.TypeOfCars.Remove(car);
				_db.SaveChanges();

				gvVehicleList.Refresh();

				//launch AditVehicle window with data
				var addEditVehicle = new AddEditVehicle(car);
				addEditVehicle.Show();

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			//Simple refresh option
			PopulateGrid();
		}

		public void PopulateGrid()
		{
			var cars = _db.TypeOfCars
				.Select(q => new
				{
					Make = q.Make,
					Model = q.Model,
					VIN = q.VIN,
					Year = q.Year,
					LicensePlateNumber = q.LicensePlateNumber,
					q.id
				})
				.ToList();
			gvVehicleList.DataSource = cars;
			gvVehicleList.Columns[4].HeaderText = "License Plate Number";
			// Hide the column for id.
			gvVehicleList.Columns["id"].Visible = false;
		}
	}
		
}
