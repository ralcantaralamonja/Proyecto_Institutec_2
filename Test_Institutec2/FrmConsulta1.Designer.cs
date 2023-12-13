namespace Test_Institutec2
{
    partial class FrmConsulta1
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
            components = new System.ComponentModel.Container();
            texLblNrc = new TextBox();
            label1 = new Label();
            btnConsultar = new Button();
            dtgAlumnoNrc = new DataGridView();
            seccionDCBindingSource = new BindingSource(components);
            lblRegistros = new Label();
            label3 = new Label();
            btnCancelar = new Button();
            Curso = new DataGridViewTextBoxColumn();
            Alumno = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Carrera = new DataGridViewTextBoxColumn();
            Facultad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgAlumnoNrc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seccionDCBindingSource).BeginInit();
            SuspendLayout();
            // 
            // texLblNrc
            // 
            texLblNrc.Location = new Point(73, 22);
            texLblNrc.MaxLength = 6;
            texLblNrc.Name = "texLblNrc";
            texLblNrc.Size = new Size(100, 23);
            texLblNrc.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "NRC :";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(190, 17);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(115, 31);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "CONSULTAR";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dtgAlumnoNrc
            // 
            dtgAlumnoNrc.AllowUserToAddRows = false;
            dtgAlumnoNrc.AllowUserToDeleteRows = false;
            dtgAlumnoNrc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgAlumnoNrc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgAlumnoNrc.BackgroundColor = SystemColors.ScrollBar;
            dtgAlumnoNrc.BorderStyle = BorderStyle.None;
            dtgAlumnoNrc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlumnoNrc.Columns.AddRange(new DataGridViewColumn[] { Curso, Alumno, ID, Correo, Carrera, Facultad });
            dtgAlumnoNrc.Location = new Point(30, 54);
            dtgAlumnoNrc.Margin = new Padding(4, 3, 4, 3);
            dtgAlumnoNrc.Name = "dtgAlumnoNrc";
            dtgAlumnoNrc.ReadOnly = true;
            dtgAlumnoNrc.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgAlumnoNrc.RowHeadersVisible = false;
            dtgAlumnoNrc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgAlumnoNrc.RowTemplate.Height = 25;
            dtgAlumnoNrc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgAlumnoNrc.Size = new Size(1094, 519);
            dtgAlumnoNrc.TabIndex = 3;
            dtgAlumnoNrc.TabStop = false;
            dtgAlumnoNrc.CellContentClick += dtgAlumnoNrc_CellContentClick;
            // 
            // seccionDCBindingSource
            // 
            seccionDCBindingSource.DataSource = typeof(ProxySeccion.SeccionDC);
            // 
            // lblRegistros
            // 
            lblRegistros.BackColor = SystemColors.Window;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1020, 582);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(107, 33);
            lblRegistros.TabIndex = 6;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(944, 591);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "REGISTROS:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(993, 658);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 42);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "SALIR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Curso
            // 
            Curso.DataPropertyName = "NomCur";
            Curso.HeaderText = "CURSO";
            Curso.Name = "Curso";
            Curso.ReadOnly = true;
            // 
            // Alumno
            // 
            Alumno.DataPropertyName = "fullName";
            Alumno.HeaderText = "ALUMNO";
            Alumno.Name = "Alumno";
            Alumno.ReadOnly = true;
            // 
            // ID
            // 
            ID.DataPropertyName = "IdAlum";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "CorAlu";
            Correo.HeaderText = "CORREO";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Carrera
            // 
            Carrera.DataPropertyName = "DesCar";
            Carrera.HeaderText = "CARRERA";
            Carrera.Name = "Carrera";
            Carrera.ReadOnly = true;
            // 
            // Facultad
            // 
            Facultad.DataPropertyName = "DesFac";
            Facultad.HeaderText = "FACULTAD";
            Facultad.Name = "Facultad";
            Facultad.ReadOnly = true;
            // 
            // FrmConsulta1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1153, 730);
            Controls.Add(btnCancelar);
            Controls.Add(lblRegistros);
            Controls.Add(label3);
            Controls.Add(dtgAlumnoNrc);
            Controls.Add(btnConsultar);
            Controls.Add(label1);
            Controls.Add(texLblNrc);
            Name = "FrmConsulta1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CONSULTA | ALUMNOS POR NRC";
            Load += FrmConsulta1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgAlumnoNrc).EndInit();
            ((System.ComponentModel.ISupportInitialize)seccionDCBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox texLblNrc;
        private Label label1;
        private Button btnConsultar;
        private DataGridView dtgAlumnoNrc;
        private BindingSource seccionDCBindingSource;
        private Label lblRegistros;
        private Label label3;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn Curso;
        private DataGridViewTextBoxColumn Alumno;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Carrera;
        private DataGridViewTextBoxColumn Facultad;
    }
}