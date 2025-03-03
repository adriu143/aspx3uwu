using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp3array20003529
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnCreateArray_Click(object sender, EventArgs e)
        {
			//Declare and load the array
			String[] strCategoryArray = new String[5];
			strCategoryArray[0] = "Footwear - Men's";
			strCategoryArray[1] = "Clothing - Men's";
			strCategoryArray[2] = "Racquets";
			strCategoryArray[3] = "Footwear - Women's";
			strCategoryArray[4] = "Clothing - Women's";
			//Save the array in a session variable for future use.
			Session["strCategoryArray"] = strCategoryArray;
			//Go to the Next page
			Response.Redirect("WebForm2.aspx");
        }
    }
}