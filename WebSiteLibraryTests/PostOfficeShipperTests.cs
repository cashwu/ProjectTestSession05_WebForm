﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebSiteLibrary.Tests
{
	[TestClass()]
	public class PostOfficeShipperTests
	{
		[TestMethod()]
		public void CalculateFeeTest()
		{
			//arrange
			var sut = new PostOfficeShipper();
			var product = new ShippingProduct
			{
				Name = "book",
				Weight = 10,
				Size = new Size
				{
					Length = 30,
					Width = 20,
					Height = 10
				},
			};

			//act
			sut.CalculateFee(product);

			//assert
			var expected = 180;
			Assert.AreEqual(expected, product.ShippingFee);
		}
	}
}
