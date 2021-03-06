﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSiteLibrary
{
	public class HsinChuShipper : IShipper
	{
		public string Name
		{
			get { return "新竹貨運"; }
		}

		public void CalculateFee(ShippingProduct product)
		{
			var size = product.Size.Length * product.Size.Width * product.Size.Height;

			//長 x 寬 x 高（公分）x 0.0000353
			if (product.Size.Length > 100 ||
				product.Size.Width > 100 ||
				product.Size.Height > 100)
			{
				product.ShippingFee = size * 0.0000353 * 1100 + 500;
			}
			else
			{
				product.ShippingFee = size * 0.0000353 * 1200;
			}
		}

	}
}
