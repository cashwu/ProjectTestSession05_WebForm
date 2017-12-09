using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSiteLibrary
{
	public class ShipperFactory
	{
		public static IShipper Create(string companyCode)
		{
			IShipper shipper = null;

			if (string.IsNullOrWhiteSpace(companyCode))
			{
				throw new ArgumentNullException("companyCode", "please input value");
			}

			switch (companyCode)
			{
				case "1":
					shipper = new BlackCatShipper();
					break;
				case "2":
					shipper = new HsinChuShipper();
					break;
				case "3":
					shipper = new PostOfficeShipper();
					break;
				default:
					shipper = null;
					break;
			}
			return shipper;
		}
	}
}
