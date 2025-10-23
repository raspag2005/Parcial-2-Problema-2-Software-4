namespace Parcial_2_Problema_2_Software_4
{
    partial class FormDataGridView
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
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbGeneros = new System.Windows.Forms.ComboBox();
            this.lblGeneros = new System.Windows.Forms.Label();
            this.grpOpciones = new System.Windows.Forms.GroupBox();
            this.rdbModificar = new System.Windows.Forms.RadioButton();
            this.rdbEliminar = new System.Windows.Forms.RadioButton();
            this.rdbAgregar = new System.Windows.Forms.RadioButton();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.grpOpciones.SuspendLayout();
            this.grpAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(201, 42);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(488, 249);
            this.dgvLibros.TabIndex = 1;
            this.dgvLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellClick);
            this.dgvLibros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellDoubleClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(337, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Libros de la Libreria";
            // 
            // cmbGeneros
            // 
            this.cmbGeneros.FormattingEnabled = true;
            this.cmbGeneros.Location = new System.Drawing.Point(513, 296);
            this.cmbGeneros.Name = "cmbGeneros";
            this.cmbGeneros.Size = new System.Drawing.Size(116, 21);
            this.cmbGeneros.TabIndex = 3;
            this.cmbGeneros.SelectedIndexChanged += new System.EventHandler(this.cmbGeneros_SelectedIndexChanged);
            // 
            // lblGeneros
            // 
            this.lblGeneros.AutoSize = true;
            this.lblGeneros.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneros.Location = new System.Drawing.Point(255, 294);
            this.lblGeneros.Name = "lblGeneros";
            this.lblGeneros.Size = new System.Drawing.Size(252, 23);
            this.lblGeneros.TabIndex = 4;
            this.lblGeneros.Text = "Elegir género para especificar:";
            // 
            // grpOpciones
            // 
            this.grpOpciones.Controls.Add(this.rdbModificar);
            this.grpOpciones.Controls.Add(this.rdbEliminar);
            this.grpOpciones.Controls.Add(this.rdbAgregar);
            this.grpOpciones.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOpciones.Location = new System.Drawing.Point(201, 323);
            this.grpOpciones.Name = "grpOpciones";
            this.grpOpciones.Size = new System.Drawing.Size(488, 69);
            this.grpOpciones.TabIndex = 5;
            this.grpOpciones.TabStop = false;
            this.grpOpciones.Text = "Opciones";
            // 
            // rdbModificar
            // 
            this.rdbModificar.AutoSize = true;
            this.rdbModificar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbModificar.Location = new System.Drawing.Point(188, 25);
            this.rdbModificar.Name = "rdbModificar";
            this.rdbModificar.Size = new System.Drawing.Size(118, 31);
            this.rdbModificar.TabIndex = 2;
            this.rdbModificar.TabStop = true;
            this.rdbModificar.Text = "Modificar";
            this.rdbModificar.UseVisualStyleBackColor = true;
            this.rdbModificar.CheckedChanged += new System.EventHandler(this.rdbModificar_CheckedChanged);
            // 
            // rdbEliminar
            // 
            this.rdbEliminar.AutoSize = true;
            this.rdbEliminar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEliminar.Location = new System.Drawing.Point(380, 25);
            this.rdbEliminar.Name = "rdbEliminar";
            this.rdbEliminar.Size = new System.Drawing.Size(102, 31);
            this.rdbEliminar.TabIndex = 1;
            this.rdbEliminar.TabStop = true;
            this.rdbEliminar.Text = "Eliminar";
            this.rdbEliminar.UseVisualStyleBackColor = true;
            this.rdbEliminar.CheckedChanged += new System.EventHandler(this.rdbEliminar_CheckedChanged);
            // 
            // rdbAgregar
            // 
            this.rdbAgregar.AutoSize = true;
            this.rdbAgregar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAgregar.Location = new System.Drawing.Point(18, 25);
            this.rdbAgregar.Name = "rdbAgregar";
            this.rdbAgregar.Size = new System.Drawing.Size(104, 31);
            this.rdbAgregar.TabIndex = 0;
            this.rdbAgregar.TabStop = true;
            this.rdbAgregar.Text = "Agregar";
            this.rdbAgregar.UseVisualStyleBackColor = true;
            this.rdbAgregar.CheckedChanged += new System.EventHandler(this.rdbAgregar_CheckedChanged);
            // 
            // grpAcciones
            // 
            this.grpAcciones.Controls.Add(this.btnReset);
            this.grpAcciones.Controls.Add(this.btnConfirmar);
            this.grpAcciones.Controls.Add(this.lblGenero);
            this.grpAcciones.Controls.Add(this.txtGenero);
            this.grpAcciones.Controls.Add(this.lblPaginas);
            this.grpAcciones.Controls.Add(this.txtPaginas);
            this.grpAcciones.Controls.Add(this.lblPrecio);
            this.grpAcciones.Controls.Add(this.txtPrecio);
            this.grpAcciones.Controls.Add(this.lblAutor);
            this.grpAcciones.Controls.Add(this.txtAutor);
            this.grpAcciones.Controls.Add(this.lblCodigo);
            this.grpAcciones.Controls.Add(this.txtCodigo);
            this.grpAcciones.Controls.Add(this.lblNombre);
            this.grpAcciones.Controls.Add(this.txtNombre);
            this.grpAcciones.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAcciones.Location = new System.Drawing.Point(201, 398);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Size = new System.Drawing.Size(488, 166);
            this.grpAcciones.TabIndex = 6;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Agregar";
            this.grpAcciones.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(263, 125);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 35);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(141, 125);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(96, 35);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(250, 88);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(76, 27);
            this.lblGenero.TabIndex = 11;
            this.lblGenero.Text = "Genero";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(328, 89);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(146, 26);
            this.txtGenero.TabIndex = 10;
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginas.Location = new System.Drawing.Point(250, 24);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(78, 27);
            this.lblPaginas.TabIndex = 9;
            this.lblPaginas.Text = "Paginas";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(328, 25);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(146, 26);
            this.txtPaginas.TabIndex = 8;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(250, 56);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(67, 27);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(328, 57);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(146, 26);
            this.txtPrecio.TabIndex = 6;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(13, 88);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(89, 27);
            this.lblAutor.TabIndex = 5;
            this.lblAutor.Text = "Autor(a)";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(102, 89);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(139, 26);
            this.txtAutor.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(13, 24);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 27);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(102, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(139, 26);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(13, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 27);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(102, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // FormDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 592);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpOpciones);
            this.Controls.Add(this.lblGeneros);
            this.Controls.Add(this.cmbGeneros);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvLibros);
            this.Name = "FormDataGridView";
            this.Text = "DataGridView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.grpOpciones.ResumeLayout(false);
            this.grpOpciones.PerformLayout();
            this.grpAcciones.ResumeLayout(false);
            this.grpAcciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbGeneros;
        private System.Windows.Forms.Label lblGeneros;
        private System.Windows.Forms.GroupBox grpOpciones;
        private System.Windows.Forms.RadioButton rdbModificar;
        private System.Windows.Forms.RadioButton rdbEliminar;
        private System.Windows.Forms.RadioButton rdbAgregar;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnReset;
    }
}