using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteLibrary;

public partial class Product : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}

	protected void btnCalculate_Click(object sender, EventArgs e)
	{
		if (!this.IsValid)
		{
			return;
		}

		var product = this.GetShippingProduct();
		var companyCode = this.drpCompany.SelectedValue;

		IShipper shipper = ShipperFactory.Create(companyCode);

		if (shipper == null)
		{
			var js = "alert('發生不預期錯誤，請洽系統管理者');location.href='http://tw.yahoo.com/';";
			this.ClientScript.RegisterStartupScript(this.GetType(), "back", js, true);
		}
		else
		{
			shipper.CalculateFee(product);
			this.lblCompany.Text = shipper.Name;
			this.lblCharge.Text = product.ShippingFee.ToString();
		}
	}

	private ShippingProduct GetShippingProduct()
	{
		var result = new ShippingProduct
		{
			Name = this.txtProductName.Text,
			Weight = Convert.ToDouble(this.txtProductWeight.Text),
			Size = new Size
			{
				Length = Convert.ToDouble(this.txtProductLength.Text),
				Width = Convert.ToDouble(this.txtProductWidth.Text),
				Height = Convert.ToDouble(this.txtProductHeight.Text)
			},
			Shipper = Convert.ToInt32(this.drpCompany.SelectedValue)
		};

		return result;
	}

}