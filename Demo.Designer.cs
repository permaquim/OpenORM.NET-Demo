namespace Demo
{
    partial class Demo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsuariosDataGridview = new System.Windows.Forms.DataGridView();
            this.VerUsuariosButton = new System.Windows.Forms.Button();
            this.PaisComboBox = new System.Windows.Forms.ComboBox();
            this.UsuariosPorPaisButton = new System.Windows.Forms.Button();
            this.VistaUsuariosBoton = new System.Windows.Forms.Button();
            this.BotonProcedimientoUsuarios = new System.Windows.Forms.Button();
            this.BotonABM = new System.Windows.Forms.Button();
            this.BotonRelaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuariosDataGridview
            // 
            this.UsuariosDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosDataGridview.Location = new System.Drawing.Point(24, 24);
            this.UsuariosDataGridview.Name = "UsuariosDataGridview";
            this.UsuariosDataGridview.RowTemplate.Height = 25;
            this.UsuariosDataGridview.Size = new System.Drawing.Size(744, 232);
            this.UsuariosDataGridview.TabIndex = 0;
            // 
            // VerUsuariosButton
            // 
            this.VerUsuariosButton.Location = new System.Drawing.Point(24, 280);
            this.VerUsuariosButton.Name = "VerUsuariosButton";
            this.VerUsuariosButton.Size = new System.Drawing.Size(75, 23);
            this.VerUsuariosButton.TabIndex = 1;
            this.VerUsuariosButton.Text = "Ver Usuarios";
            this.VerUsuariosButton.UseVisualStyleBackColor = true;
            this.VerUsuariosButton.Click += new System.EventHandler(this.VerUsuariosButton_Click);
            // 
            // PaisComboBox
            // 
            this.PaisComboBox.FormattingEnabled = true;
            this.PaisComboBox.Location = new System.Drawing.Point(352, 280);
            this.PaisComboBox.Name = "PaisComboBox";
            this.PaisComboBox.Size = new System.Drawing.Size(121, 23);
            this.PaisComboBox.TabIndex = 2;
            // 
            // UsuariosPorPaisButton
            // 
            this.UsuariosPorPaisButton.Location = new System.Drawing.Point(512, 280);
            this.UsuariosPorPaisButton.Name = "UsuariosPorPaisButton";
            this.UsuariosPorPaisButton.Size = new System.Drawing.Size(152, 23);
            this.UsuariosPorPaisButton.TabIndex = 3;
            this.UsuariosPorPaisButton.Text = "Ver Usuarios Por Pais";
            this.UsuariosPorPaisButton.UseVisualStyleBackColor = true;
            this.UsuariosPorPaisButton.Click += new System.EventHandler(this.UsuariosPorPaisButton_Click);
            // 
            // VistaUsuariosBoton
            // 
            this.VistaUsuariosBoton.Location = new System.Drawing.Point(24, 328);
            this.VistaUsuariosBoton.Name = "VistaUsuariosBoton";
            this.VistaUsuariosBoton.Size = new System.Drawing.Size(120, 23);
            this.VistaUsuariosBoton.TabIndex = 4;
            this.VistaUsuariosBoton.Text = "Vista Usuarios";
            this.VistaUsuariosBoton.UseVisualStyleBackColor = true;
            this.VistaUsuariosBoton.Click += new System.EventHandler(this.VistaUsuariosBoton_Click);
            // 
            // BotonProcedimientoUsuarios
            // 
            this.BotonProcedimientoUsuarios.Location = new System.Drawing.Point(280, 328);
            this.BotonProcedimientoUsuarios.Name = "BotonProcedimientoUsuarios";
            this.BotonProcedimientoUsuarios.Size = new System.Drawing.Size(176, 23);
            this.BotonProcedimientoUsuarios.TabIndex = 5;
            this.BotonProcedimientoUsuarios.Text = "Procedimiento Usuarios";
            this.BotonProcedimientoUsuarios.UseVisualStyleBackColor = true;
            this.BotonProcedimientoUsuarios.Click += new System.EventHandler(this.BotonProcedimientoUsuarios_Click);
            // 
            // BotonABM
            // 
            this.BotonABM.Location = new System.Drawing.Point(576, 360);
            this.BotonABM.Name = "BotonABM";
            this.BotonABM.Size = new System.Drawing.Size(75, 23);
            this.BotonABM.TabIndex = 6;
            this.BotonABM.Text = "ABM";
            this.BotonABM.UseVisualStyleBackColor = true;
            this.BotonABM.Click += new System.EventHandler(this.BotonABM_Click);
            // 
            // BotonRelaciones
            // 
            this.BotonRelaciones.Location = new System.Drawing.Point(704, 360);
            this.BotonRelaciones.Name = "BotonRelaciones";
            this.BotonRelaciones.Size = new System.Drawing.Size(75, 23);
            this.BotonRelaciones.TabIndex = 7;
            this.BotonRelaciones.Text = "Relaciones";
            this.BotonRelaciones.UseVisualStyleBackColor = true;
            this.BotonRelaciones.Click += new System.EventHandler(this.BotonRelaciones_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.BotonRelaciones);
            this.Controls.Add(this.BotonABM);
            this.Controls.Add(this.BotonProcedimientoUsuarios);
            this.Controls.Add(this.VistaUsuariosBoton);
            this.Controls.Add(this.UsuariosPorPaisButton);
            this.Controls.Add(this.PaisComboBox);
            this.Controls.Add(this.VerUsuariosButton);
            this.Controls.Add(this.UsuariosDataGridview);
            this.Name = "Demo";
            this.Text = "Demo";
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView UsuariosDataGridview;
        private Button VerUsuariosButton;
        private ComboBox PaisComboBox;
        private Button UsuariosPorPaisButton;
        private Button VistaUsuariosBoton;
        private Button BotonProcedimientoUsuarios;
        private Button BotonABM;
        private Button BotonRelaciones;
    }
}