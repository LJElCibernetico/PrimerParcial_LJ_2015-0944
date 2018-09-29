using BLL;
using Entidades;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimerParcial_LJ_2015_0944.registros
{
    public partial class rDepositos : System.Web.UI.Page
    {
        private RepositorioBase<Depositos> rd = new DepositosRepositorio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LlenarDropDown();
        }

        private void LlenarDropDown()
        {
            RepositorioBase<CuentasBancarias> rb = new RepositorioBase<CuentasBancarias>();
            CuentaDropDownList.DataSource = rb.GetList(x => true);
            CuentaDropDownList.DataValueField = "CuentaId";
            CuentaDropDownList.DataTextField = "Nombre";
            CuentaDropDownList.DataBind();
            CuentaDropDownList.Items.Insert(0, new ListItem("", ""));
        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            TextBoxDepositoID.Text = string.Empty;
            TextBoxFecha.Text = string.Empty;
            TextBoxConcepto.Text = string.Empty;
            TextBoxMonto.Text = string.Empty;
        }

        private void LlenarCampos(Depositos deposito)
        {
            TextBoxFecha.Text = deposito.Fecha.ToString();
            CuentaDropDownList.SelectedValue = deposito.CuentaId.ToString();
            TextBoxConcepto.Text = deposito.Concepto;
            TextBoxMonto.Text = deposito.Monto.ToString();
        }

        private Depositos LlenaClase()
        {
            int id;
            if (TextBoxDepositoID.Text == String.Empty)
                id = 0;
            else
                id = int.Parse(TextBoxDepositoID.Text);

            return new Depositos(
                id,
                DateTime.Parse(TextBoxFecha.Text),
                int.Parse(CuentaDropDownList.SelectedValue),
                TextBoxConcepto.Text,
                double.Parse(TextBoxMonto.Text)
            );
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                DepositosRepositorio rd = new DepositosRepositorio();
                int.TryParse(TextBoxDepositoID.Text, out int id);
                if (id == 0 )
                {
                    if(rd.Guardar(LlenaClase()))
                        ScriptManager.RegisterStartupScript(Page, typeof(Page), "Popup", "alert('Deposito Guardado')", true);
                    ClearAll();
                }
                else
                {
                    rd.Modificar(LlenaClase());
                    ClearAll();
                }
            }
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            DepositosRepositorio rd = new DepositosRepositorio();
            Depositos deposito = rd.Buscar(int.Parse(TextBoxDepositoID.Text));

            if (deposito != null)
            {
                rd.Eliminar(int.Parse(TextBoxDepositoID.Text));
                ClearAll();
            }
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            RepositorioBase<Depositos> rb = new RepositorioBase<Depositos>();
            Depositos deposito = rb.Buscar(int.Parse(TextBoxDepositoID.Text));
            if (deposito != null)
                LlenarCampos(deposito);
        }
    }
}