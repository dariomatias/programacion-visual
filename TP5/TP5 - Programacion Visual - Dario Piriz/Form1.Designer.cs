
namespace TP5___Programacion_Visual___Dario_Piriz
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDetalles = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFechaEdicion = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblFechaEdicion = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbLibros = new System.Windows.Forms.GroupBox();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.librosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libreriaDataSet = new TP5___Programacion_Visual___Dario_Piriz.LibreriaDataSet();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new TP5___Programacion_Visual___Dario_Piriz.LibreriaDataSetTableAdapters.LibrosTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEdicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbDetalles.SuspendLayout();
            this.gbLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.librosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.libreriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.libroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetalles
            // 
            this.gbDetalles.Controls.Add(this.btnCancelar);
            this.gbDetalles.Controls.Add(this.dtpFechaEdicion);
            this.gbDetalles.Controls.Add(this.btnGuardar);
            this.gbDetalles.Controls.Add(this.txtLugar);
            this.gbDetalles.Controls.Add(this.lblFechaEdicion);
            this.gbDetalles.Controls.Add(this.lblLugar);
            this.gbDetalles.Controls.Add(this.txtEditorial);
            this.gbDetalles.Controls.Add(this.txtEdicion);
            this.gbDetalles.Controls.Add(this.lblEditorial);
            this.gbDetalles.Controls.Add(this.lblEdicion);
            this.gbDetalles.Controls.Add(this.txtPaginas);
            this.gbDetalles.Controls.Add(this.txtIsbn);
            this.gbDetalles.Controls.Add(this.lblPaginas);
            this.gbDetalles.Controls.Add(this.lblIsbn);
            this.gbDetalles.Controls.Add(this.txtAutor);
            this.gbDetalles.Controls.Add(this.txtTitulo);
            this.gbDetalles.Controls.Add(this.lblAutor);
            this.gbDetalles.Controls.Add(this.lblTitulo);
            this.gbDetalles.Location = new System.Drawing.Point(12, 73);
            this.gbDetalles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetalles.Name = "gbDetalles";
            this.gbDetalles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetalles.Size = new System.Drawing.Size(843, 334);
            this.gbDetalles.TabIndex = 0;
            this.gbDetalles.TabStop = false;
            this.gbDetalles.Text = "Nuevo Libro";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(424, 288);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 28);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpFechaEdicion
            // 
            this.dtpFechaEdicion.Location = new System.Drawing.Point(424, 238);
            this.dtpFechaEdicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaEdicion.Name = "dtpFechaEdicion";
            this.dtpFechaEdicion.Size = new System.Drawing.Size(407, 22);
            this.dtpFechaEdicion.TabIndex = 18;
            this.dtpFechaEdicion.Value = new System.DateTime(2021, 11, 2, 0, 0, 0, 0);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(308, 288);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 30);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(9, 239);
            this.txtLugar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(408, 22);
            this.txtLugar.TabIndex = 14;
            // 
            // lblFechaEdicion
            // 
            this.lblFechaEdicion.AutoSize = true;
            this.lblFechaEdicion.Location = new System.Drawing.Point(420, 218);
            this.lblFechaEdicion.Name = "lblFechaEdicion";
            this.lblFechaEdicion.Size = new System.Drawing.Size(117, 17);
            this.lblFechaEdicion.TabIndex = 13;
            this.lblFechaEdicion.Text = "Fecha de Edición";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(5, 218);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(145, 17);
            this.lblLugar.TabIndex = 12;
            this.lblLugar.Text = "Lugar (Ciudad y País)";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(423, 178);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(408, 22);
            this.txtEditorial.TabIndex = 11;
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(9, 178);
            this.txtEdicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(408, 22);
            this.txtEdicion.TabIndex = 10;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(420, 158);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(59, 17);
            this.lblEditorial.TabIndex = 9;
            this.lblEditorial.Text = "Editorial";
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(5, 158);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(54, 17);
            this.lblEdicion.TabIndex = 8;
            this.lblEdicion.Text = "Edición";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(423, 117);
            this.txtPaginas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(408, 22);
            this.txtPaginas.TabIndex = 7;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(9, 117);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(408, 22);
            this.txtIsbn.TabIndex = 6;
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Location = new System.Drawing.Point(420, 96);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(59, 17);
            this.lblPaginas.TabIndex = 5;
            this.lblPaginas.Text = "Páginas";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(5, 96);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(39, 17);
            this.lblIsbn.TabIndex = 4;
            this.lblIsbn.Text = "ISBN";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(423, 60);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(408, 22);
            this.txtAutor.TabIndex = 3;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(9, 60);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(408, 22);
            this.txtTitulo.TabIndex = 2;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(420, 39);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(42, 17);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(5, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 17);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // gbLibros
            // 
            this.gbLibros.Controls.Add(this.dgvLibros);
            this.gbLibros.Location = new System.Drawing.Point(12, 414);
            this.gbLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLibros.Name = "gbLibros";
            this.gbLibros.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLibros.Size = new System.Drawing.Size(843, 299);
            this.gbLibros.TabIndex = 1;
            this.gbLibros.TabStop = false;
            this.gbLibros.Text = "Libros Cargados";
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.AllowUserToResizeRows = false;
            this.dgvLibros.AutoGenerateColumns = false;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.idDataGridViewTextBoxColumn, this.tituloDataGridViewTextBoxColumn, this.autorDataGridViewTextBoxColumn, this.paginasDataGridViewTextBoxColumn, this.iSBNDataGridViewTextBoxColumn, this.edicionDataGridViewTextBoxColumn, this.editorialDataGridViewTextBoxColumn, this.lugarDataGridViewTextBoxColumn, this.fechaEdicionDataGridViewTextBoxColumn, this.Editar, this.Eliminar});
            this.dgvLibros.DataSource = this.librosBindingSource1;
            this.dgvLibros.Location = new System.Drawing.Point(9, 27);
            this.dgvLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLibros.MultiSelect = false;
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(821, 272);
            this.dgvLibros.TabIndex = 0;
            this.dgvLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellContentClick);
            // 
            // librosBindingSource1
            // 
            this.librosBindingSource1.DataMember = "Libros";
            this.librosBindingSource1.DataSource = this.libreriaDataSet;
            // 
            // libreriaDataSet
            // 
            this.libreriaDataSet.DataSetName = "LibreriaDataSet";
            this.libreriaDataSet.Namespace = "http://tempuri.org/LibreriaDataSet.xsd";
            this.libreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            this.librosBindingSource.DataSource = this.libreriaDataSet;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Eras Medium ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.Location = new System.Drawing.Point(364, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 34);
            this.label9.TabIndex = 2;
            this.label9.Text = "Librería";
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataSource = typeof(BusinessObjects.Libro);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(768, 45);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(74, 22);
            this.txtId.TabIndex = 20;
            this.txtId.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 68;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            this.autorDataGridViewTextBoxColumn.Width = 67;
            // 
            // paginasDataGridViewTextBoxColumn
            // 
            this.paginasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.paginasDataGridViewTextBoxColumn.DataPropertyName = "Paginas";
            this.paginasDataGridViewTextBoxColumn.HeaderText = "Paginas";
            this.paginasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paginasDataGridViewTextBoxColumn.Name = "paginasDataGridViewTextBoxColumn";
            this.paginasDataGridViewTextBoxColumn.ReadOnly = true;
            this.paginasDataGridViewTextBoxColumn.Width = 84;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            this.iSBNDataGridViewTextBoxColumn.Width = 64;
            // 
            // edicionDataGridViewTextBoxColumn
            // 
            this.edicionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.edicionDataGridViewTextBoxColumn.DataPropertyName = "Edicion";
            this.edicionDataGridViewTextBoxColumn.HeaderText = "Edicion";
            this.edicionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.edicionDataGridViewTextBoxColumn.Name = "edicionDataGridViewTextBoxColumn";
            this.edicionDataGridViewTextBoxColumn.ReadOnly = true;
            this.edicionDataGridViewTextBoxColumn.Width = 79;
            // 
            // editorialDataGridViewTextBoxColumn
            // 
            this.editorialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.editorialDataGridViewTextBoxColumn.DataPropertyName = "Editorial";
            this.editorialDataGridViewTextBoxColumn.HeaderText = "Editorial";
            this.editorialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.editorialDataGridViewTextBoxColumn.Name = "editorialDataGridViewTextBoxColumn";
            this.editorialDataGridViewTextBoxColumn.ReadOnly = true;
            this.editorialDataGridViewTextBoxColumn.Width = 84;
            // 
            // lugarDataGridViewTextBoxColumn
            // 
            this.lugarDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lugarDataGridViewTextBoxColumn.DataPropertyName = "Lugar";
            this.lugarDataGridViewTextBoxColumn.HeaderText = "Lugar";
            this.lugarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lugarDataGridViewTextBoxColumn.Name = "lugarDataGridViewTextBoxColumn";
            this.lugarDataGridViewTextBoxColumn.ReadOnly = true;
            this.lugarDataGridViewTextBoxColumn.Width = 70;
            // 
            // fechaEdicionDataGridViewTextBoxColumn
            // 
            this.fechaEdicionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fechaEdicionDataGridViewTextBoxColumn.DataPropertyName = "FechaEdicion";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fechaEdicionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fechaEdicionDataGridViewTextBoxColumn.HeaderText = "FechaEdicion";
            this.fechaEdicionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaEdicionDataGridViewTextBoxColumn.Name = "fechaEdicionDataGridViewTextBoxColumn";
            this.fechaEdicionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaEdicionDataGridViewTextBoxColumn.Width = 118;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Editar.HeaderText = "";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 19;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eliminar.HeaderText = "";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 800);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbLibros);
            this.Controls.Add(this.gbDetalles);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDetalles.ResumeLayout(false);
            this.gbDetalles.PerformLayout();
            this.gbLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.librosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.libreriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.libroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtId;

        #endregion

        private System.Windows.Forms.GroupBox gbDetalles;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblFechaEdicion;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.GroupBox gbLibros;
        private System.Windows.Forms.DataGridView dgvLibros;
        private LibreriaDataSet libreriaDataSet;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private LibreriaDataSetTableAdapters.LibrosTableAdapter librosTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFechaEdicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paginasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.BindingSource librosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEdicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource libroBindingSource;
    }
}

