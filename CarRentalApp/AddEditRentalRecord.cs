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
	public partial class AddEditRentalRecord : Form
	{
		private bool isEditMode;
		private readonly CarRentalEntities _db;

		public AddEditRentalRecord()
		{
			InitializeComponent();
			carRentalEntities = new CarRentalEntities();
			lblTitle.Text = "Add New Vehicle";
			isEditMode = false;
			_db = new CarRentalEntities();
		}

		public AddEditRentalRecord(CarRentalRecord recordToEdit)
		{
			InitializeComponent();
			lblTitle.Text = "Edit Rental Record";
			this.Text = "Edit Rental Record";
			if (recordToEdit == null)
			{
				MessageBox.Show("Please ensure that you selected a valid record to edit");
				Close();
			}
			else
			{
				isEditMode = true;
				_db = new CarRentalEntities();
				PopulateFields(recordToEdit);
			}
		}

		public void PopulateGrid(CarRentalRecord recordToEdit)
		{
			tbCustomerName.Text= recordToEdit.CustomerName;
			dtRented.Value = recordToEdit.DateRented;
			dtReturned.Value = (DateTime)recordToEdit.DateRented;
			dtReturned.Value = (DateTime)recordToEdit.DateReturned;
			tbCost.Text = recordToEdit.Cost.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string customerName = tbCustomerName.Text;
				DateTime dateOut = dtRented.Value;
				DateTime dateIn = dtReturned.Value;
				double cost = Convert.ToDouble(tbCost.Text);


				var carType = cbTypeOfCar.SelectedItem.ToString();
				var isValid = true;
				var errorMessage = "";


				if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
				{
					isValid = false;
					errorMessage += "Please enter missing data.";
				}

				if (dateOut > dateIn)
				{
					isValid = false;
					errorMessage += "Illegal Date Selection";
				}


				//if(isValid == true)
				if (isValid)
				{
					var rentalRecord = new CarRentalRecord();
					rentalRecord.CustomerName = customerName;
					rentalRecord.DateRented = dateOut;
					rentalRecord.DateReturned = dateIn;
					rentalRecord.Cost = (decimal)cost; //(decimal)
					rentalRecord.TypeOfCarId = (int)cbTypeOfCar.SelectedValue;

					carRentalEntities.CarRentalRecords.Add(rentalRecord);

					MessageBox.Show($"Customer Name: {customerName}\n\r" +
						$"Date Rented: {dateOut.ToString()}\n\r" +
						$"Date Returned: {dateIn.ToString()}\n\r" +
						$"Cost: {cost}\n\r" +
						$"Car Typer: {carType}\n\r" +
						$"Thank you for your business! :D");

				}
				else
				{
					MessageBox.Show(errorMessage);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				throw;
			}
			
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//var cars = carRentalEntities.TypeOfCars.ToList();
			var cars = carRentalEntities.TypeOfCars.Select(q => new { Id = q.id, Name = q.Make + " " + q.Model }).ToList();
			cbTypeOfCar.DisplayMember = "Name";
			cbTypeOfCar.ValueMember = "Id";
			cbTypeOfCar.DataSource = cars;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			//mainWindow.BringToFront();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
