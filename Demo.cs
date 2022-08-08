namespace Demo
{
    public partial class Demo : Form
    {

        public Demo()
        {
            InitializeComponent();
            CargarPaises();
        }

        private void BotonVerUsuarios_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }


        private void VerUsuariosButton_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }


        private void UsuariosPorPaisButton_Click(object sender, EventArgs e)
        {
            CargarUsuarios((long)PaisComboBox.SelectedValue);
        }

        private void VistaUsuariosBoton_Click(object sender, EventArgs e)
        {
            CargarVistaUsuarios();
        }


        private void BotonProcedimientoUsuarios_Click(object sender, EventArgs e)
        {
            CargarProcedimientoUsuarios();
        }
        /// <summary>
        /// Carga los uauarios en la Grilla
        /// </summary>
        private void CargarUsuarios()
        {
            AccesoADatos.Business.Tables.dbo.Usuario entidad = new();
            //UsuariosDataGridview.DataSource = entidad.Items();

            entidad.Where.OpenParentheses();
            entidad.Where.Add(AccesoADatos.Business.Tables.dbo.Usuario.ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, 1);
            entidad.Where.CloseParentheses();
            entidad.Where.AddConjunction(AccesoADatos.sqlEnum.ConjunctionEnum.OR);
            entidad.Where.OpenParentheses();
            entidad.Where.Add(AccesoADatos.Business.Tables.dbo.Usuario.ColumnEnum.Id, AccesoADatos.sqlEnum.OperandEnum.Equal, 2);
            entidad.Where.CloseParentheses();

            UsuariosDataGridview.DataSource = entidad.Items();


        }
        /// <summary>
        /// Carga los usuarios de un pais, 
        /// que es seleccionado en el combo
        /// </summary>
        /// <param name="paisId"></param>
        private void CargarUsuarios(long paisId)
        {
            AccesoADatos.Business.Tables.dbo.Usuario entidad = new();
            entidad.Where.Add(AccesoADatos.Business.Tables.dbo.Usuario.ColumnEnum.PaisId,
                AccesoADatos.sqlEnum.OperandEnum.Equal, paisId);

            UsuariosDataGridview.DataSource = entidad.Items();

        }
        /// <summary>
        /// Carga los paises en el combo
        /// </summary>
        private void CargarPaises()
        {
            AccesoADatos.Business.Tables.dbo.Pais entidad = new();
            PaisComboBox.DisplayMember = AccesoADatos.Entities.Tables.dbo.Pais.ColumnNames.Nombre;
            PaisComboBox.ValueMember = AccesoADatos.Entities.Tables.dbo.Pais.ColumnNames.Id;

            PaisComboBox.DataSource = entidad.Items();

        }

        /// <summary>
        /// Muestra los datos de la vista de usuarios
        /// </summary>
        private void CargarVistaUsuarios()
        {
            AccesoADatos.Business.Views.dbo.VistaUsuario entidad = new();
            UsuariosDataGridview.DataSource = entidad.Items();
        }

        /// <summary>
        /// mustra los datos del procedimiento de ObtenerUsuarios
        /// </summary>
        private void CargarProcedimientoUsuarios()
        {
            AccesoADatos.Business.Procedures.dbo.ObtenerUsuario entidad = new();
            UsuariosDataGridview.DataSource = entidad.Items();
        }

        private void BotonABM_Click(object sender, EventArgs e)
        {
            ABMform form = new ABMform();
            form.ShowDialog();
        }

        private void BotonRelaciones_Click(object sender, EventArgs e)
        {
            RelacionesForm form = new RelacionesForm();
            form.ShowDialog();
        }
    }
}