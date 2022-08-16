using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp
{
	public static class Utils
	{
		public static bool FormIsOpen(string name)
		{
			// Check Window is already open
			var OpenForms = ApplicationException.OpenForms.Cast<Format>();
			var isOpen = OpenForms.Any(q => q.Name == name);
			return isOpen;
		}

		public static string HashPassword(string password)
		{
			SHA256 sHA256 = SHA256.Create();
			byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

			//Create a new Stringbuilder to collect the bytes
			//and create a string.
			StringBuilder sBuilder = new StringBuilder();

			// Loop through each byte of the hashed data
			// and format each one as a hexadecimal string
			for (int i = 0; i < data.Length; i++)
			{
				sBuilder.Append(data[i].ToString("x2"));
			}

			return sBuilder.ToString();
		}

		public static string DefaultHashedPassword()
		{
			SHA256 sHA256 = SHA256.Create();
			byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes("Password@123"));

			//Create a new Stringbuilder to collect the bytes
			//and create a string.
			StringBuilder sBuilder = new StringBuilder();

			// Loop through each byte of the hashed data
			// and format each one as a hexadecimal string
			for (int i = 0; i < data.Length; i++)
			{
				sBuilder.Append(data[i].ToString("x2"));
			}

			return sBuilder.ToString();
		}
	}
}
