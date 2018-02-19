using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Core.Employee emp = new Core.Employee() {
                EmployeeID = -1,
                LastName = "sheley",
                FirstName = "andy",
                MiddleName = "scott",
                ParkingLogID = 2,
            };
        }
    }
}