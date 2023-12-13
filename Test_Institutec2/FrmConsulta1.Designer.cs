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
            texLblNrc = new TextBox();
            label1 = new Label();
            btnConsultar = new Button();
            dtgAlumnoNrc = new DataGridView();
            Curso = new DataGridViewTextBoxColumn();
            Alumno = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Carrera = new DataGridViewTextBoxColumn();
            Facultad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgAlumnoNrc).BeginInit();
            SuspendLayout();
            // 
            // texLblNrc
            // 
            texLblNrc.Location = new Point(103, 35);
            texLblNrc.MaxLength = 6;
            texLblNrc.Name = "texLblNrc";
            texLblNrc.Size = new Size(100, 23);
            texLblNrc.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Location = new Point(43, 38);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "NRC :";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(244, 34);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dtgAlumnoNrc
            // 
            dtgAlumnoNrc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlumnoNrc.Columns.AddRange(new DataGridViewColumn[] { Curso, Alumno, ID, Correo, Carrera, Facultad });
            dtgAlumnoNrc.Location = new Point(43, 89);
            dtgAlumnoNrc.Name = "dtgAlumnoNrc";
            dtgAlumnoNrc.ReadOnly = true;
            dtgAlumnoNrc.RowTemplate.Height = 25;
            dtgAlumnoNrc.Size = new Size(645, 234);
            dtgAlumnoNrc.TabIndex = 3;
            dtgAlumnoNrc.CellContentClick += dtgAlumnoNrc_CellContentClick;
            // 
            // Curso
            // 
            Curso.DataPropertyName = "Curso";
            Curso.HeaderText = "Curso";
            Curso.Name = "Curso";
            Curso.ReadOnly = true;
            // 
            // Alumno
            // 
            Alumno.DataPropertyName = "Alumno";
            Alumno.HeaderText = "Alumno";
            Alumno.Name = "Alumno";
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // Carrera
            // 
            Carrera.DataPropertyName = "Carrera";
            Carrera.HeaderText = "Carrera";
            Carrera.Name = "Carrera";
            // 
            // Facultad
            // 
            Facultad.DataPropertyName = "Facultad";
            Facultad.HeaderText = "Facultad";
            Facultad.Name = "Facultad";
            // 
            // FrmConsulta1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgAlumnoNrc);
            Controls.Add(btnConsultar);
            Controls.Add(label1);
            Controls.Add(texLblNrc);
            Name = "FrmConsulta1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Alumnos por NRC";
            ((System.ComponentModel.ISupportInitialize)dtgAlumnoNrc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox texLblNrc;
        private Label label1;
        private Button btnConsultar;
        private DataGridView dtgAlumnoNrc;
        private DataGridViewTextBoxColumn Curso;
        private DataGridViewTextBoxColumn Alumno;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Carrera;
        private DataGridViewTextBoxColumn Facultad;
    }
}