using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebSiteLibrary.Tests
{
	[TestClass()]
	public class BlackCatShipperTests
	{
		[TestMethod()]
		public void CalculateTest()
		{
			//arrange
			var sut = new BlackCatShipper();
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
			var expected = 200;
			Assert.AreEqual(expected, product.ShippingFee);
		}
	}
}
