namespace Tarea5_Detalle.UI
{
    partial class rAnalisisMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rAnalisisMedico));
            this.label1 = new System.Windows.Forms.Label();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoverFilabutton = new System.Windows.Forms.Button();
            this.DetallesdataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarAnalisisbutton = new System.Windows.Forms.Button();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TipoAnalisiscomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UsuariocomboBox = new System.Windows.Forms.ComboBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(68, 20);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(150, 20);
            this.IdnumericUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(68, 57);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.FechadateTimePicker.TabIndex = 3;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Tarea5_Detalle.Properties.Resources.buscar;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(224, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 35);
            this.Buscarbutton.TabIndex = 9;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoverFilabutton);
            this.groupBox1.Controls.Add(this.DetallesdataGridView);
            this.groupBox1.Controls.Add(this.AgregarAnalisisbutton);
            this.groupBox1.Controls.Add(this.ResultadotextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TipoAnalisiscomboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 282);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Analisis";
            // 
            // RemoverFilabutton
            // 
            this.RemoverFilabutton.Image = global::Tarea5_Detalle.Properties.Resources.remover;
            this.RemoverFilabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverFilabutton.Location = new System.Drawing.Point(9, 242);
            this.RemoverFilabutton.Name = "RemoverFilabutton";
            this.RemoverFilabutton.Size = new System.Drawing.Size(110, 35);
            this.RemoverFilabutton.TabIndex = 15;
            this.RemoverFilabutton.Text = "Remover Fila";
            this.RemoverFilabutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverFilabutton.UseVisualStyleBackColor = true;
            this.RemoverFilabutton.Click += new System.EventHandler(this.RemoverFilabutton_Click);
            // 
            // DetallesdataGridView
            // 
            this.DetallesdataGridView.AllowUserToAddRows = false;
            this.DetallesdataGridView.AllowUserToDeleteRows = false;
            this.DetallesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetallesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DetallesdataGridView.Location = new System.Drawing.Point(9, 69);
            this.DetallesdataGridView.Name = "DetallesdataGridView";
            this.DetallesdataGridView.ReadOnly = true;
            this.DetallesdataGridView.Size = new System.Drawing.Size(365, 166);
            this.DetallesdataGridView.TabIndex = 14;
            // 
            // AgregarAnalisisbutton
            // 
            this.AgregarAnalisisbutton.Image = global::Tarea5_Detalle.Properties.Resources.add;
            this.AgregarAnalisisbutton.Location = new System.Drawing.Point(339, 24);
            this.AgregarAnalisisbutton.Name = "AgregarAnalisisbutton";
            this.AgregarAnalisisbutton.Size = new System.Drawing.Size(35, 36);
            this.AgregarAnalisisbutton.TabIndex = 13;
            this.AgregarAnalisisbutton.UseVisualStyleBackColor = true;
            this.AgregarAnalisisbutton.Click += new System.EventHandler(this.AgregarAnalisisbutton_Click);
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(196, 33);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(139, 20);
            this.ResultadotextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Resultado:";
            // 
            // TipoAnalisiscomboBox
            // 
            this.TipoAnalisiscomboBox.FormattingEnabled = true;
            this.TipoAnalisiscomboBox.Location = new System.Drawing.Point(6, 32);
            this.TipoAnalisiscomboBox.Name = "TipoAnalisiscomboBox";
            this.TipoAnalisiscomboBox.Size = new System.Drawing.Size(184, 21);
            this.TipoAnalisiscomboBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo de Analisis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Usuario:";
            // 
            // UsuariocomboBox
            // 
            this.UsuariocomboBox.FormattingEnabled = true;
            this.UsuariocomboBox.Location = new System.Drawing.Point(68, 89);
            this.UsuariocomboBox.Name = "UsuariocomboBox";
            this.UsuariocomboBox.Size = new System.Drawing.Size(322, 21);
            this.UsuariocomboBox.TabIndex = 12;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Tarea5_Detalle.Properties.Resources.nuevo;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(16, 408);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 52);
            this.Nuevobutton.TabIndex = 13;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Tarea5_Detalle.Properties.Resources.guardar;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(172, 408);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 52);
            this.Guardarbutton.TabIndex = 14;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Tarea5_Detalle.Properties.Resources.eliminar;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(321, 408);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 52);
            this.Eliminarbutton.TabIndex = 15;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "AnalisisDetalleId";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TipoAnalisisId";
            this.Column2.HeaderText = "Tipo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Resultado";
            this.Column3.HeaderText = "Resultado";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // rAnalisisMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 480);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.UsuariocomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "rAnalisisMedico";
            this.Text = "rAnalisisMedico";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AgregarAnalisisbutton;
        private System.Windows.Forms.TextBox ResultadotextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TipoAnalisiscomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoverFilabutton;
        private System.Windows.Forms.DataGridView DetallesdataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox UsuariocomboBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}