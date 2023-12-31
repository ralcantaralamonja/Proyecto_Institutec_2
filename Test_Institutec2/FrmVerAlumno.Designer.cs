﻿namespace ProyInstitutec_GUI
{
    partial class FrmVerAlumno
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            mskDNIAlumno = new TextBox();
            dtgAlumno = new DataGridView();
            label2 = new Label();
            lblRegistros = new Label();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            IdAlum = new DataGridViewTextBoxColumn();
            Ndocum = new DataGridViewTextBoxColumn();
            Alumno = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            NomAlu = new DataGridViewTextBoxColumn();
            ApePat = new DataGridViewTextBoxColumn();
            ApeMat = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            Carrera = new DataGridViewTextBoxColumn();
            desFac = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgAlumno).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 0;
            label1.Text = "INGRESE DNI DEL ALUMNO:";
            // 
            // mskDNIAlumno
            // 
            mskDNIAlumno.Location = new Point(229, 12);
            mskDNIAlumno.Margin = new Padding(5);
            mskDNIAlumno.Name = "mskDNIAlumno";
            mskDNIAlumno.Size = new Size(241, 25);
            mskDNIAlumno.TabIndex = 3;
            mskDNIAlumno.TextChanged += mskDNIAlumno_TextChanged;
            // 
            // dtgAlumno
            // 
            dtgAlumno.AllowUserToAddRows = false;
            dtgAlumno.AllowUserToDeleteRows = false;
            dtgAlumno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgAlumno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgAlumno.BackgroundColor = SystemColors.ScrollBar;
            dtgAlumno.BorderStyle = BorderStyle.None;
            dtgAlumno.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dtgAlumno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlumno.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, NomAlu, ApePat, ApeMat, dataGridViewTextBoxColumn4, Genero, Correo, Telefono, direccion, Carrera, desFac, Estado });
            dtgAlumno.Location = new Point(14, 56);
            dtgAlumno.Margin = new Padding(5);
            dtgAlumno.Name = "dtgAlumno";
            dtgAlumno.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgAlumno.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgAlumno.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dtgAlumno.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dtgAlumno.RowTemplate.Height = 33;
            dtgAlumno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgAlumno.Size = new Size(1293, 503);
            dtgAlumno.TabIndex = 2;
            dtgAlumno.TabStop = false;
            dtgAlumno.CellContentClick += dtgAlumno_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1094, 569);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 4;
            label2.Text = "REGISTROS:";
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1222, 564);
            lblRegistros.Margin = new Padding(5, 0, 5, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(84, 30);
            lblRegistros.TabIndex = 5;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = SystemColors.ControlLight;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Location = new Point(715, 609);
            btnInsertar.Margin = new Padding(3, 4, 3, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(125, 40);
            btnInsertar.TabIndex = 6;
            btnInsertar.Text = "INSERTAR";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ControlLight;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Location = new Point(846, 609);
            btnActualizar.Margin = new Padding(5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(125, 40);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLight;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(1045, 609);
            btnSalir.Margin = new Padding(5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(125, 40);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // IdAlum
            // 
            IdAlum.HeaderText = "ID";
            IdAlum.Name = "IdAlum";
            // 
            // Ndocum
            // 
            Ndocum.HeaderText = "DNI";
            Ndocum.Name = "Ndocum";
            // 
            // Alumno
            // 
            Alumno.DataPropertyName = "Alumno";
            Alumno.HeaderText = "Alumno";
            Alumno.Name = "Alumno";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IdAlum";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Ndocum";
            dataGridViewTextBoxColumn2.HeaderText = "DNI";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // NomAlu
            // 
            NomAlu.DataPropertyName = "NomAlu";
            NomAlu.HeaderText = "Nombre";
            NomAlu.Name = "NomAlu";
            NomAlu.ReadOnly = true;
            // 
            // ApePat
            // 
            ApePat.DataPropertyName = "ApePat";
            ApePat.HeaderText = "Ape Pat";
            ApePat.Name = "ApePat";
            ApePat.ReadOnly = true;
            // 
            // ApeMat
            // 
            ApeMat.DataPropertyName = "ApeMat";
            ApeMat.HeaderText = "Ape Mat";
            ApeMat.Name = "ApeMat";
            ApeMat.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "FecNac";
            dataGridViewTextBoxColumn4.HeaderText = "Fecha de Nacimiento";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Genero
            // 
            Genero.DataPropertyName = "Sexoal";
            Genero.HeaderText = "Genero";
            Genero.Name = "Genero";
            Genero.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "CorAlu";
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "TelAlu";
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // direccion
            // 
            direccion.DataPropertyName = "direccion";
            direccion.HeaderText = "Direccion";
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            // 
            // Carrera
            // 
            Carrera.DataPropertyName = "CodCar";
            Carrera.HeaderText = "Carrera";
            Carrera.Name = "Carrera";
            Carrera.ReadOnly = true;
            // 
            // desFac
            // 
            desFac.DataPropertyName = "DesFac";
            desFac.HeaderText = "Facultad";
            desFac.Name = "desFac";
            desFac.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // FrmVerAlumno
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 661);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgAlumno);
            Controls.Add(mskDNIAlumno);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmVerAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VER ALUMNO";
            Load += VerAlumno_Load;
            ((System.ComponentModel.ISupportInitialize)dtgAlumno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox mskDNIAlumno;
        private DataGridView dtgAlumno;
        private Label label2;
        private Label lblRegistros;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn IdAlum;
        private DataGridViewTextBoxColumn Ndocum;
        private DataGridViewTextBoxColumn Alumno;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn NomAlu;
        private DataGridViewTextBoxColumn ApePat;
        private DataGridViewTextBoxColumn ApeMat;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn Carrera;
        private DataGridViewTextBoxColumn desFac;
        private DataGridViewTextBoxColumn Estado;
    }
}