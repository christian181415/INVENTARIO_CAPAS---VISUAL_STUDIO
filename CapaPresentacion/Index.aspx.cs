﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClientePagina.aspx");
        }

        protected void BtnProveedor_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProveedorPagina.aspx");
        }
    }
}