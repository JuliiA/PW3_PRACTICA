using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                lblresultado.Text = "0";
        }

        protected void btnsumar_Click(object sender, EventArgs e)
        {
            int anterior = Int32.Parse(lblresultado.Text);
            int operando = Int32.Parse(txtentrada.Text);
            int resultado = anterior + operando;
            lblresultado.Text = Convert.ToString(resultado);



        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}