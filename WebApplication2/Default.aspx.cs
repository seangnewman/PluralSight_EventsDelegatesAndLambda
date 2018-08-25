using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = "Clicked Me";
        }

        protected void CountriesDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void CountriesDropDownList_SelectedIndexChanged1(object sender, EventArgs e)
        {
            OutputLabel.Text = CountriesDropDownList.SelectedValue;
            //OutputLabel.Text = "Index changed";
        }
    }
}