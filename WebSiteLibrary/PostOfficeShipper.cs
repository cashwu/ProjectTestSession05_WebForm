using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSiteLibrary
{
	public class PostOfficeShipper : IShipper
	{
		public string Name
		{
			get { return "郵局"; }
		}

		public void CalculateFee(ShippingProduct product)
		{
			var weight = product.Weight;

			var feeByWeight = 80 + weight * 10;

			var size = product.Size.Length * product.Size.Width * product.Size.Height;

			var feeBySize = size * 0.0000353 * 1100;

			if (feeByWeight < feeBySize)
			{
				product.ShippingFee = feeByWeight;
			}
			else
			{
				product.ShippingFee = feeBySize;
			}
		}
	}
}
