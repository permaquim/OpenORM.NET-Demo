namespace Demo
{
    partial class ABMform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsuariosDataGridview = new System.Windows.Forms.DataGridView();
            this.NombreTextbox = new System.Windows.Forms.TextBox();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.PaisComboBox = new System.Windows.Forms.ComboBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.ApellidoLabel = new System.Windows.Forms.Label();
            this.EdadLabel = new System.Windows.Forms.Label();
            this.PaisLabel = new System.Windows.Forms.Label();
            this.BotonSalir = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdValueLabel = new System.Windows.Forms.Label();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.BotonModificar = new System.Windows.Forms.Button();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.BotonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuariosDataGridview
            // 
            this.UsuariosDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosDataGridview.Location = new System.Drawing.Point(16, 16);
            this.UsuariosDataGridview.MultiSelect = false;
            this.UsuariosDataGridview.Name = "UsuariosDataGridview";
            this.UsuariosDataGridview.RowTemplate.Height = 25;
            this.UsuariosDataGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsuariosDataGridview.Size = new System.Drawing.Size(760, 232);
            this.UsuariosDataGridview.TabIndex = 1;
            this.UsuariosDataGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsuariosDataGridview_CellClick);
            // 
            // NombreTextbox
            // 
            this.NombreTextbox.Location = new System.Drawing.Point(120, 296);
            this.NombreTextbox.Name = "NombreTextbox";
            this.NombreTextbox.Size = new System.Drawing.Size(336, 23);
            this.NombreTextbox.TabIndex = 2;
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(120, 331);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(336, 23);
            this.ApellidoTextBox.TabIndex = 3;
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Location = new System.Drawing.Point(120, 368);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.Size = new System.Drawing.Size(120, 23);
            this.EdadTextBox.TabIndex = 4;
            // 
            // PaisComboBox
            // 
            this.PaisComboBox.FormattingEnabled = true;
            this.PaisComboBox.Location = new System.Drawing.Point(120, 408);
            this.PaisComboBox.Name = "PaisComboBox";
            this.PaisComboBox.Size = new System.Drawing.Size(121, 23);
            this.PaisComboBox.TabIndex = 5;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(40, 304);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(54, 15);
            this.NombreLabel.TabIndex = 6;
            this.NombreLabel.Text = "Nombre:";
            // 
            // ApellidoLabel
            // 
            this.ApellidoLabel.AutoSize = true;
            this.ApellidoLabel.Location = new System.Drawing.Point(40, 336);
            this.ApellidoLabel.Name = "ApellidoLabel";
            this.ApellidoLabel.Size = new System.Drawing.Size(54, 15);
            this.ApellidoLabel.TabIndex = 7;
            this.ApellidoLabel.Text = "Apellido:";
            // 
            // EdadLabel
            // 
            this.EdadLabel.AutoSize = true;
            this.EdadLabel.Location = new System.Drawing.Point(40, 376);
            this.EdadLabel.Name = "EdadLabel";
            this.EdadLabel.Size = new System.Drawing.Size(36, 15);
            this.EdadLabel.TabIndex = 8;
            this.EdadLabel.Text = "Edad:";
            // 
            // PaisLabel
            // 
            this.PaisLabel.AutoSize = true;
            this.PaisLabel.Location = new System.Drawing.Point(40, 416);
            this.PaisLabel.Name = "PaisLabel";
            this.PaisLabel.Size = new System.Drawing.Size(31, 15);
            this.PaisLabel.TabIndex = 9;
            this.PaisLabel.Text = "Pais:";
            // 
            // BotonSalir
            // 
            this.BotonSalir.Location = new System.Drawing.Point(712, 408);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(75, 23);
            this.BotonSalir.TabIndex = 10;
            this.BotonSalir.Text = "Salir";
            this.BotonSalir.UseVisualStyleBackColor = true;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(40, 264);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(20, 15);
            this.IdLabel.TabIndex = 11;
            this.IdLabel.Text = "Id:";
            // 
            // IdValueLabel
            // 
            this.IdValueLabel.AutoSize = true;
            this.IdValueLabel.Location = new System.Drawing.Point(120, 264);
            this.IdValueLabel.Name = "IdValueLabel";
            this.IdValueLabel.Size = new System.Drawing.Size(0, 15);
            this.IdValueLabel.TabIndex = 12;
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Location = new System.Drawing.Point(312, 408);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(75, 23);
            this.BotonAgregar.TabIndex = 13;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.UseVisualStyleBackColor = true;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // BotonModificar
            // 
            this.BotonModificar.Location = new System.Drawing.Point(424, 408);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.Size = new System.Drawing.Size(75, 23);
            this.BotonModificar.TabIndex = 14;
            this.BotonModificar.Text = "Modificar";
            this.BotonModificar.UseVisualStyleBackColor = true;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(528, 408);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(75, 23);
            this.BotonEliminar.TabIndex = 15;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // BotonLimpiar
            // 
            this.BotonLimpiar.Location = new System.Drawing.Point(520, 296);
            this.BotonLimpiar.Name = "BotonLimpiar";
            this.BotonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BotonLimpiar.TabIndex = 16;
            this.BotonLimpiar.Text = "Limpiar";
            this.BotonLimpiar.UseVisualStyleBackColor = true;
            this.BotonLimpiar.Click += new System.EventHandler(this.BotonLimpiar_Click);
            // 
            // ABMform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonLimpiar);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.BotonModificar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.IdValueLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.BotonSalir);
            this.Controls.Add(this.PaisLabel);
            this.Controls.Add(this.EdadLabel);
            this.Controls.Add(this.ApellidoLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.PaisComboBox);
            this.Controls.Add(this.EdadTextBox);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.NombreTextbox);
            this.Controls.Add(this.UsuariosDataGridview);
            this.Name = "ABMform";
            this.Text = "ABMform";
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView UsuariosDataGridview;
        private TextBox NombreTextbox;
        private TextBox ApellidoTextBox;
        private TextBox EdadTextBox;
        private ComboBox PaisComboBox;
        private Label NombreLabel;
        private Label ApellidoLabel;
        private Label EdadLabel;
        private Label PaisLabel;
        private Button BotonSalir;
        private Label IdLabel;
        private Label IdValueLabel;
        private Button BotonAgregar;
        private Button BotonModificar;
        private Button BotonEliminar;
        private Button BotonLimpiar;
    }
}