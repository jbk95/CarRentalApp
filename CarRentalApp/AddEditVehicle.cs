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
	public partial class AddEditVehicle : Form
	{
		private bool isEditMode;
		private readonly CarRentalEntities _db;

		public AddEditVehicle()
		{
			InitializeComponent();
			lblTitle.Text = "Add New Vehicle";
			isEditMode = false;
			_db = new CarRentalEntities();
		}

		public AddEditVehicle(TypeOfCar carToEdit)
		{
			InitializeComponent();
			lblTitle.Text = "Edit Vehicle";
			this.Text = "Edit Vehicle";
			if (carToEdit == null)
			{
				MessageBox.Show("Please ensure that you selected a valid record to edit");
				Close();
			}
			else
			{
				isEditMode = true;
				_db = new CarRentalEntities();
				PopulateFields(carToEdit);
			}
		}

		private void PopulateFields(TypeOfCar car)
		{
			lblid.Text = car.id.ToString();
			tbMake.Text = car.Make;
			tbModel.Text = car.Model;
			tbVin.Text = car.VIN;
			tbYear.Text = car.Year.ToString();
			tbLicense.Text = car.LicensePlateNumber;
		}

		//private void AddEditVehicle_Load(object sender, EventArgs e)
		//{
		//	throw new NotImplementedException();
		//}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (isEditMode)
			{
				// Edit Code here
				var id = int.Parse(lblid.Text);
				var car = _db.TypeOfCars.FirstOrDefault(q => q.id == id);
				car.Model = tbModel.Text;
				car.Make = tbMake.Text;
				car.VIN = tbVin.Text;
				car.Year = int.Parse(tbYear.Text);
				car.LicensePlateNumber = tbLicense.Text;

				_db.SaveChanges();
			}
			else
			{
				//Add Code Here
				var newCar = new TypeOfCar
				{
					LicensePlateNumber = tbLicense.Text,
					Make = tbMake.Text,
					Model = tbModel.Text,
					VIN = tbVin.Text,
					Year = int.Parse(tbYear.Text)
				};

				_db.TypeOfCars.Add(newCar);
				_db.SaveChanges();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
