using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSiteLibrary
{
	public class BlackCatShipper : IShipper
	{
		public string Name
		{
			get { return "黑貓"; }
		}

		public void CalculateFee(ShippingProduct product)
		{
			var weight = product.Weight;

			if (weight > 20)
			{
				product.ShippingFee = 500;
			}
			else
			{
				product.ShippingFee = 100 + weight * 10;
			}
		}
	}
}
