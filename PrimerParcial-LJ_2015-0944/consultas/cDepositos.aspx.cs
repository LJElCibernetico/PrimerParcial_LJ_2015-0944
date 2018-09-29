using BLL;
using Entidades;
using System;
using System.Linq.Expressions;
using System.Web.UI.WebControls;

namespace PrimerParcial_LJ_2015_0944.consultas
{
    public partial class cDepositos : System.Web.UI.Page
    {
        Expression<Func<Depositos, bool>> filter = x => true;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Filtrar()
        {
            int dato = 0;
            switch (FiltroDropDownList.SelectedIndex)
            {
                case 0://Todo
                    filter = x => true;
                    break;

                case 1://DepositoId
                    dato = int.Parse(BuscarTextBox.Text);
                    filter = (x => x.DepositosId == dato);
                    break;

                case 2://CuentaId
                    dato = int.Parse(BuscarTextBox.Text);
                    filter = (x => x.CuentaId == dato);
                    break;

                case 3://Fecha
                    filter = (x => x.Fecha.Equals(BuscarTextBox.Text));
                    break;

                case 4://Concepto
                    filter = (x => x.Concepto.Contains(BuscarTextBox.Text));
                    break;

                case 5://Monto
                    double monto = double.Parse(BuscarTextBox.Text);
                    filter = (x => x.Monto == monto);
                    break;
            }
        }


        protected void BuscarLinkButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Depositos> rep = new RepositorioBase<Depositos>();
            Filtrar();
            DepositoGridView.DataSource = rep.GetList(filter);
            DepositoGridView.DataBind();
        }

        protected void DepositoGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            RepositorioBase<Depositos> rep = new RepositorioBase<Depositos>();
            DepositoGridView.DataSource = rep.GetList(filter);
            DepositoGridView.PageIndex = e.NewPageIndex;
            DepositoGridView.DataBind();
        }
    }
}