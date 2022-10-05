using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoADatos.Business.Relations.dbo;
using AccesoADatos.Business.Tables.dbo;

namespace Demo
{
    public partial class ABMform : Form
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
        public ABMform()
        {
            InitializeComponent();
            CargarUsuarios();
            CargarPaises();
        }

        #region Eventos      
        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;    
        }


        private void UsuariosDataGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdValueLabel.Text = 
                UsuariosDataGridview.SelectedRows[REGISTRO_SELECCIONADO].Cells[(int)EnumColumnas.Id].Value.ToString();

            NombreTextbox.Text = 
                UsuariosDataGridview.SelectedRows[REGISTRO_SELECCIONADO].Cells[(int)EnumColumnas.Nombre].Value.ToString();

            ApellidoTextBox.Text =
                UsuariosDataGridview.SelectedRows[REGISTRO_SELECCIONADO].Cells[(int)EnumColumnas.Apellido].Value.ToString();

            EdadTextBox.Text =
                UsuariosDataGridview.SelectedRows[REGISTRO_SELECCIONADO].Cells[(int)EnumColumnas.Edad].Value.ToString();

            PaisComboBox.SelectedValue =
                (long)UsuariosDataGridview.SelectedRows[REGISTRO_SELECCIONADO].Cells[(int)EnumColumnas.PaisId].Value;

        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            IdValueLabel.Text = String.Empty;
            NombreTextbox.Text = String.Empty;
            ApellidoTextBox.Text = String.Empty;
            EdadTextBox.Text = String.Empty;
            PaisComboBox.SelectedValue = 0;

        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma agregar?", "Confirmación alta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AgregarUsuario();
                CargarUsuarios();
            }

            //AccesoADatos.Business.Tables.dbo.Banco bco = new();
            //bco.Add(new AccesoADatos.Entities.Tables.dbo.Banco()
            //{
            //    Codigo = "Demo",
            //    Descripcion = "Descripcion",
            //    FechaCreacion = DateTime.Now,
            //    Habilitado = true,
            //    Nombre = "Nombre",
            //    PaisId = 0,
            //    UsuarioCreacion = 1
            //},9);

        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Confirma modificar?", "Confirmación modificación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    ModificarUsuario();
            //    CargarUsuarios();
            //}


            //AccesoADatos.Business.Tables.dbo.Banco bco = new();
            //bco.Update(new AccesoADatos.Entities.Tables.dbo.Banco()
            //{
            //     Id = 2,
            //    Codigo = "Demo2",
            //    Descripcion = "Descripcion2",
            //    Habilitado = true,
            //    Nombre = "Nombre 2",
            //    PaisId = 3,
            //    FechaCreacion = DateTime.Now,
            //    UsuarioModificacion  =2,
            //    FechaModificacion = DateTime.Now,
            //}, 9);
        }


        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Confirma eliminar?", "Confirmación borrado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    EliminarUsuario();
            //    CargarUsuarios();
            //}

            //AccesoADatos.Business.Tables.dbo.Banco bco = new();
            //bco.Delete(3, 9);
        }
        #endregion

        #region Funciones

        /// <summary>
        /// Carga los uauarios en la Grilla
        /// </summary>
        private void CargarUsuarios()
        {
            AccesoADatos.Business.Tables.dbo.Usuario entidad = new();
            UsuariosDataGridview.DataSource = entidad.Items();

        }
        private void CargarPaises()
        {
            AccesoADatos.Business.Tables.dbo.Pais entidad = new();
            PaisComboBox.DisplayMember = AccesoADatos.Entities.Tables.dbo.Pais.ColumnNames.Nombre;
            PaisComboBox.ValueMember = AccesoADatos.Entities.Tables.dbo.Pais.ColumnNames.Id;

            PaisComboBox.DataSource = entidad.Items();

        }

        private void AgregarUsuario()
        {
            AccesoADatos.Business.Tables.dbo.Usuario entidad = new();

            //entidad.Add(
            //    NombreTextbox.Text.Trim(),
            //    ApellidoTextBox.Text.Trim(),
            //    Convert.ToInt16(EdadTextBox.Text.Trim()),
            //    (long)PaisComboBox.SelectedValue
            //    );

            var usuario =  entidad.Add(new AccesoADatos.Entities.Tables.dbo.Usuario()
              {
                 Nombre = NombreTextbox.Text.Trim(),
                 Apellido = ApellidoTextBox.Text.Trim(),
                 Edad = Convert.ToInt16(EdadTextBox.Text.Trim()),
                 PaisId = (long)PaisComboBox.SelectedValue
            });


        }

        private void ModificarUsuario()
        {
            AccesoADatos.Business.Tables.dbo.Usuario entidad = new();

            entidad.BeginTransaction();

            //entidad.Update(
            //    Convert.ToInt64(IdValueLabel.Text),
            //    NombreTextbox.Text.Trim(),
            //    ApellidoTextBox.Text.Trim(),
            //    Convert.ToInt16(EdadTextBox.Text.Trim()),
            //    (long)PaisComboBox.SelectedValue
            //    );

            var usuario = entidad.Update(new AccesoADatos.Entities.Tables.dbo.Usuario()
            {
                Id = Convert.ToInt64(IdValueLabel.Text),
                Nombre = NombreTextbox.Text.Trim(),
                Apellido = ApellidoTextBox.Text.Trim(),
                Edad = Convert.ToInt16(EdadTextBox.Text.Trim()),
                PaisId = (long)PaisComboBox.SelectedValue
            });


            AccesoADatos.Business.Tables.dbo.Pais pais = new(entidad);

            entidad.EndTransaction(true);

        }

        private void EliminarUsuario()
        {
            AccesoADatos.Business.Tables.dbo.Usuario entidad = new();
            
            entidad.Delete(Convert.ToInt64(IdValueLabel.Text));
  
         }

        #endregion


    }
}
