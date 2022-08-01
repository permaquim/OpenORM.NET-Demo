namespace Demo
{
    partial class RelacionesForm
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
            this.NombreContinenteLabel = new System.Windows.Forms.Label();
            this.NombrePaisLabel = new System.Windows.Forms.Label();
            this.NombreContinenteTextBox = new System.Windows.Forms.TextBox();
            this.NombrePaisTextbox = new System.Windows.Forms.TextBox();
            this.BotonSalir = new System.Windows.Forms.Button();
            this.PaisComboBox = new System.Windows.Forms.ComboBox();
            this.GrillaUsuariosPais = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsuariosPais)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuariosDataGridview
            // 
            this.UsuariosDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosDataGridview.Location = new System.Drawing.Point(8, 16);
            this.UsuariosDataGridview.MultiSelect = false;
            this.UsuariosDataGridview.Name = "UsuariosDataGridview";
            this.UsuariosDataGridview.RowTemplate.Height = 25;
            this.UsuariosDataGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsuariosDataGridview.Size = new System.Drawing.Size(480, 232);
            this.UsuariosDataGridview.TabIndex = 2;
            this.UsuariosDataGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsuariosDataGridview_CellClick);
            // 
            // NombreContinenteLabel
            // 
            this.NombreContinenteLabel.AutoSize = true;
            this.NombreContinenteLabel.Location = new System.Drawing.Point(24, 328);
            this.NombreContinenteLabel.Name = "NombreContinenteLabel";
            this.NombreContinenteLabel.Size = new System.Drawing.Size(116, 15);
            this.NombreContinenteLabel.TabIndex = 11;
            this.NombreContinenteLabel.Text = "Nombre Continente:";
            // 
            // NombrePaisLabel
            // 
            this.NombrePaisLabel.AutoSize = true;
            this.NombrePaisLabel.Location = new System.Drawing.Point(24, 296);
            this.NombrePaisLabel.Name = "NombrePaisLabel";
            this.NombrePaisLabel.Size = new System.Drawing.Size(78, 15);
            this.NombrePaisLabel.TabIndex = 10;
            this.NombrePaisLabel.Text = "Nombre Pais:";
            // 
            // NombreContinenteTextBox
            // 
            this.NombreContinenteTextBox.Location = new System.Drawing.Point(152, 320);
            this.NombreContinenteTextBox.Name = "NombreContinenteTextBox";
            this.NombreContinenteTextBox.Size = new System.Drawing.Size(336, 23);
            this.NombreContinenteTextBox.TabIndex = 9;
            // 
            // NombrePaisTextbox
            // 
            this.NombrePaisTextbox.Location = new System.Drawing.Point(152, 288);
            this.NombrePaisTextbox.Name = "NombrePaisTextbox";
            this.NombrePaisTextbox.Size = new System.Drawing.Size(336, 23);
            this.NombrePaisTextbox.TabIndex = 8;
            // 
            // BotonSalir
            // 
            this.BotonSalir.Location = new System.Drawing.Point(808, 408);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(75, 23);
            this.BotonSalir.TabIndex = 12;
            this.BotonSalir.Text = "Salir";
            this.BotonSalir.UseVisualStyleBackColor = true;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // PaisComboBox
            // 
            this.PaisComboBox.FormattingEnabled = true;
            this.PaisComboBox.Location = new System.Drawing.Point(664, 304);
            this.PaisComboBox.Name = "PaisComboBox";
            this.PaisComboBox.Size = new System.Drawing.Size(121, 23);
            this.PaisComboBox.TabIndex = 13;
            this.PaisComboBox.SelectedValueChanged += new System.EventHandler(this.PaisComboBox_SelectedValueChanged);
            // 
            // GrillaUsuariosPais
            // 
            this.GrillaUsuariosPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaUsuariosPais.Location = new System.Drawing.Point(536, 16);
            this.GrillaUsuariosPais.MultiSelect = false;
            this.GrillaUsuariosPais.Name = "GrillaUsuariosPais";
            this.GrillaUsuariosPais.RowTemplate.Height = 25;
            this.GrillaUsuariosPais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaUsuariosPais.Size = new System.Drawing.Size(472, 232);
            this.GrillaUsuariosPais.TabIndex = 14;
            // 
            // RelacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 450);
            this.Controls.Add(this.GrillaUsuariosPais);
            this.Controls.Add(this.PaisComboBox);
            this.Controls.Add(this.BotonSalir);
            this.Controls.Add(this.NombreContinenteLabel);
            this.Controls.Add(this.NombrePaisLabel);
            this.Controls.Add(this.NombreContinenteTextBox);
            this.Controls.Add(this.NombrePaisTextbox);
            this.Controls.Add(this.UsuariosDataGridview);
            this.Name = "RelacionesForm";
            this.Text = "RelacionesForm";
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsuariosPais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView UsuariosDataGridview;
        private Label NombreContinenteLabel;
        private Label NombrePaisLabel;
        private TextBox NombreContinenteTextBox;
        private TextBox NombrePaisTextbox;
        private Button BotonSalir;
        private ComboBox PaisComboBox;
        private DataGridView GrillaUsuariosPais;
    }
}