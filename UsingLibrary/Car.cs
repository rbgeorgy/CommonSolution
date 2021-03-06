﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UsingLibrary
{
	public class Car : Transport
	{
		private string _brand;

		public string Brand
		{
			get
			{
				return _brand;
			}
		}

		public Car(string brand, double maxSpeed, int numbersSeats, double mass) : base(mass, maxSpeed, numbersSeats)
		{
			_brand = brand;
		}

		public override void TravelType()
		{
			Console.WriteLine("Moves in ordinary roads");
		}

		public override string ToString()
		{
			return $"Марка: {Brand}" + base.ToString();
		}
	}
}