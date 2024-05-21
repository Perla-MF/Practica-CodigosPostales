using System.Windows.Forms;

namespace CodigosPostales
{
    public partial class Form1 : Form
    {
        private string query;
        public Form1()
        {
            InitializeComponent();
            query = "select id, nombre from estado";
            cBoxEstado.DataSource = Connection.SelectQuery(query);
            cBoxEstado.DisplayMember = "nombre";
            cBoxEstado.ValueMember = "id";
        }

        private void cBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select id, nombre from municipio where idEstado=" + cBoxEstado.SelectedValue;
            cBoxMunicipio.DataSource = Connection.SelectQuery(query);
            cBoxMunicipio.DisplayMember = "nombre";
            cBoxMunicipio.ValueMember = "id";
        }

        private void cBoxMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cBoxEstado.Text))
            {
                return;
            }
            query = "select * from VW_Busqueda where [Nombre Municipio]='" + cBoxMunicipio.Text + "'";
            DataGVCodP.DataSource = Connection.SelectQuery(query);
        }
    }
}
