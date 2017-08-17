﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exercise09_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataView dataView1 = (DataView)SqlDataSource2.Select(DataSourceSelectArguments.Empty);

            foreach (DataRowView dRV in dataView1)
            {
                this.TextBox1.Text = dRV["EmployeeID"].ToString();
                this.TextBox2.Text = dRV["FirstName"].ToString();
                this.TextBox3.Text = dRV["LastName"].ToString();
                this.TextBox4.Text = dRV["Title"].ToString();
            }
        }
    }
}