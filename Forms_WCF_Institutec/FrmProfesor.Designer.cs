﻿namespace ProyInstitutec_GUI
{
    partial class FrmProfesor
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesor));
            label1 = new Label();
            mskDNIProfesor = new TextBox();
            dtgProfesor = new DataGridView();
            IdProf = new DataGridViewTextBoxColumn();
            Ndocum = new DataGridViewTextBoxColumn();
            ApellPat_Mat = new DataGridViewTextBoxColumn();
            NomPro = new DataGridViewTextBoxColumn();
            TelPro = new DataGridViewTextBoxColumn();
            Sexopr = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            FecIng = new DataGridViewTextBoxColumn();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            label2 = new Label();
            LblRegistros = new Label();
            Id = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgProfesor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 23);
            label1.TabIndex = 0;
            label1.Text = "FILTRO DNI PROFESOR:";
            // 
            // mskDNIProfesor
            // 
            mskDNIProfesor.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mskDNIProfesor.Location = new Point(243, 12);
            mskDNIProfesor.Margin = new Padding(3, 2, 3, 2);
            mskDNIProfesor.MaxLength = 8;
            mskDNIProfesor.Name = "mskDNIProfesor";
            mskDNIProfesor.Size = new Size(335, 32);
            mskDNIProfesor.TabIndex = 1;
            // 
            // dtgProfesor
            // 
            dtgProfesor.AllowUserToAddRows = false;
            dtgProfesor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dtgProfesor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgProfesor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgProfesor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProfesor.BackgroundColor = SystemColors.ScrollBar;
            dtgProfesor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgProfesor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgProfesor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProfesor.Columns.AddRange(new DataGridViewColumn[] { IdProf, Ndocum, ApellPat_Mat, NomPro, TelPro, Sexopr, Estado, Foto, direccion, FecIng });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgProfesor.DefaultCellStyle = dataGridViewCellStyle3;
            dtgProfesor.GridColor = Color.FromArgb(88, 183, 213);
            dtgProfesor.Location = new Point(13, 54);
            dtgProfesor.Margin = new Padding(4);
            dtgProfesor.Name = "dtgProfesor";
            dtgProfesor.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgProfesor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgProfesor.RowHeadersVisible = false;
            dtgProfesor.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(88, 183, 213);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Window;
            dtgProfesor.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dtgProfesor.RowTemplate.Height = 33;
            dtgProfesor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProfesor.Size = new Size(1293, 503);
            dtgProfesor.TabIndex = 2;
            // 
            // IdProf
            // 
            IdProf.DataPropertyName = "IdProf";
            IdProf.HeaderText = "ID";
            IdProf.MinimumWidth = 6;
            IdProf.Name = "IdProf";
            IdProf.ReadOnly = true;
            // 
            // Ndocum
            // 
            Ndocum.DataPropertyName = "Ndocum";
            Ndocum.HeaderText = "DNI";
            Ndocum.MinimumWidth = 6;
            Ndocum.Name = "Ndocum";
            Ndocum.ReadOnly = true;
            // 
            // ApellPat_Mat
            // 
            ApellPat_Mat.DataPropertyName = "ApellPat_Mat";
            ApellPat_Mat.HeaderText = "Apellidos";
            ApellPat_Mat.MinimumWidth = 6;
            ApellPat_Mat.Name = "ApellPat_Mat";
            ApellPat_Mat.ReadOnly = true;
            // 
            // NomPro
            // 
            NomPro.DataPropertyName = "NomPro";
            NomPro.HeaderText = "Nombres";
            NomPro.MinimumWidth = 6;
            NomPro.Name = "NomPro";
            NomPro.ReadOnly = true;
            // 
            // TelPro
            // 
            TelPro.DataPropertyName = "TelPro";
            TelPro.HeaderText = "Teléfono";
            TelPro.MinimumWidth = 6;
            TelPro.Name = "TelPro";
            TelPro.ReadOnly = true;
            // 
            // Sexopr
            // 
            Sexopr.DataPropertyName = "Sexopr";
            Sexopr.HeaderText = "Sexo";
            Sexopr.MinimumWidth = 6;
            Sexopr.Name = "Sexopr";
            Sexopr.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Foto
            // 
            Foto.DataPropertyName = "Foto";
            Foto.HeaderText = "Foto";
            Foto.MinimumWidth = 6;
            Foto.Name = "Foto";
            Foto.ReadOnly = true;
            // 
            // direccion
            // 
            direccion.DataPropertyName = "direccion";
            direccion.HeaderText = "Dirección";
            direccion.MinimumWidth = 6;
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            // 
            // FecIng
            // 
            FecIng.DataPropertyName = "FecIng";
            FecIng.HeaderText = "Fecha Ingreso";
            FecIng.MinimumWidth = 6;
            FecIng.Name = "FecIng";
            FecIng.ReadOnly = true;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = SystemColors.ControlLight;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertar.Location = new Point(715, 609);
            btnInsertar.Margin = new Padding(4, 5, 4, 5);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(125, 40);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "INSERTAR";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ControlLight;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.Location = new Point(846, 609);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(138, 40);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLight;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(1045, 609);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(125, 40);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1094, 569);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 2;
            label2.Text = "REGISTROS:";
            // 
            // LblRegistros
            // 
            LblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LblRegistros.BackColor = SystemColors.Window;
            LblRegistros.BorderStyle = BorderStyle.FixedSingle;
            LblRegistros.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblRegistros.Location = new Point(1222, 564);
            LblRegistros.Margin = new Padding(4, 0, 4, 0);
            LblRegistros.Name = "LblRegistros";
            LblRegistros.Size = new Size(84, 30);
            LblRegistros.TabIndex = 3;
            LblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // FrmProfesor
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 661);
            Controls.Add(LblRegistros);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(mskDNIProfesor);
            Controls.Add(label1);
            Controls.Add(dtgProfesor);
            Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmProfesor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VER PROFESOR";
            Load += FrmProfesor_Load;
            ((System.ComponentModel.ISupportInitialize)dtgProfesor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox mskDNIProfesor;
        private DataGridView dtgProfesor;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnSalir;
        private Label label2;
        private Label LblRegistros;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdProf;
        private DataGridViewTextBoxColumn Ndocum;
        private DataGridViewTextBoxColumn ApellPat_Mat;
        private DataGridViewTextBoxColumn NomPro;
        private DataGridViewTextBoxColumn TelPro;
        private DataGridViewTextBoxColumn Sexopr;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Foto;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn FecIng;
    }
}