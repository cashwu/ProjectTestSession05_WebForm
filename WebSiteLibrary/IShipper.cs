using System;
namespace WebSiteLibrary
{
	public interface IShipper
	{
		string Name { get; }

		void CalculateFee(ShippingProduct product);
	}
}
