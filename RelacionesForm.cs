using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class RelacionesForm : Form
    {
        private enum EnumColumnas
        {
            Id,
            Nombre,
            Apellido,
            Edad,
            PaisId
        }
        private const int REGISTRO_SELECCIONADO = 0;
        public RelacionesForm()
        {
            InitializeComponent();
            CargarUsuarios();
            CargarPaises();
        }
        /// <summary>
        /// Carga los uauarios en la Grilla
        /// </summary>
        private void CargarUsuarios()
        {
            AccesoADatos.Business.Relations.dbo.Usuario entidad = new();
            UsuariosDataGridview.DataSource = entidad.Items();

        }
        /// <summary>
        /// Carga los paises en el combo
        /// </summary>
        private void CargarPaises()
        {
            AccesoADatos.Business.Relations.dbo.Pais entidad = new();
            PaisComboBox.DisplayMember = AccesoADatos.Entities.Relations.dbo.Pais.ColumnNames.Nombre;
            PaisComboBox.ValueMember = AccesoADatos.Entities.Relations.dbo.Pais.ColumnNames.Id;

            PaisComboBox.DataSource = entidad.Items();

        }
        private void UsuariosDataGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AccesoADatos.Entities.Relations.dbo.Usuario entidad =
                (AccesoADatos.Entities.Relations.dbo.Usuario)UsuariosDataGridview.SelectedRows[REGISTRO_SELECCIONADO].DataBoundItem;

            NombrePaisTextbox.Text = entidad.PaisId.Nombre;
            NombreContinenteTextBox.Text = entidad.PaisId.ContinenteId.Nombre;
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void PaisComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            if(PaisComboBox.SelectedItem != null)
                GrillaUsuariosPais.DataSource = 
                    ((AccesoADatos.Entities.Relations.dbo.Pais)PaisComboBox.SelectedItem)
                    .ListOf_Usuario_PaisId;
        }
    }
}
