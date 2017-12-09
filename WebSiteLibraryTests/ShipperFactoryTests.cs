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
	public class ShipperFactoryTests
	{
		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void GetShipper_沒有輸入貨運商代碼_應拋出ArgumentNullException()
		{
			// arrange
			var companyCode = "";

			// act
			var actual = ShipperFactory.Create(companyCode);
		}

		[TestMethod]
		public void GetShipper_貨運商代碼輸入1_應回傳黑貓()
		{
			// arrange
			var companyCode = "1";
			var expected = "黑貓";

			// act
			var actual = ShipperFactory.Create(companyCode);

			// assert
			Assert.AreEqual(expected, actual.Name);
		}

		[TestMethod]
		public void GetShipper_貨運商代碼輸入2_應回傳新竹貨運()
		{
			// arrange
			var companyCode = "2";
			var expected = "新竹貨運";

			// act
			var actual = ShipperFactory.Create(companyCode);

			// assert
			Assert.AreEqual(expected, actual.Name);
		}

		[TestMethod]
		public void GetShipper_貨運商代碼輸入3_應回傳郵局()
		{
			// arrange
			var companyCode = "3";
			var expected = "郵局";

			// act
			var actual = ShipperFactory.Create(companyCode);

			// assert
			Assert.AreEqual(expected, actual.Name);
		}

	}
}
