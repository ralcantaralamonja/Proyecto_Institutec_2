namespace Test_Institutec
{
    partial class FrmActualizarSeccion
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
            btnCancelar = new Button();
            btnGrabar = new Button();
            dtpHoraFin = new DateTimePicker();
            dtpHoraInicio = new DateTimePicker();
            txtVacante = new TextBox();
            label3 = new Label();
            label5 = new Label();
            cboNomProf = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            chkActivo = new CheckBox();
            cboNomCurso = new ComboBox();
            label1 = new Label();
            label8 = new Label();
            lblCodigo = new Label();
            cboCentroEst = new ComboBox();
            txtdia = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(433, 538);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 42);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(270, 538);
            btnGrabar.Margin = new Padding(4, 3, 4, 3);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(134, 42);
            btnGrabar.TabIndex = 17;
            btnGrabar.Text = "GRABAR";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.Format = DateTimePickerFormat.Time;
            dtpHoraFin.Location = new Point(168, 321);
            dtpHoraFin.Margin = new Padding(4, 3, 4, 3);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.Size = new Size(132, 23);
            dtpHoraFin.TabIndex = 13;
            dtpHoraFin.Value = new DateTime(2023, 11, 25, 17, 25, 23, 0);
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.Format = DateTimePickerFormat.Time;
            dtpHoraInicio.Location = new Point(168, 272);
            dtpHoraInicio.Margin = new Padding(4, 3, 4, 3);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.Size = new Size(132, 23);
            dtpHoraInicio.TabIndex = 11;
            dtpHoraInicio.Value = new DateTime(2023, 11, 25, 17, 25, 23, 0);
            // 
            // txtVacante
            // 
            txtVacante.Location = new Point(168, 168);
            txtVacante.Margin = new Padding(4, 3, 4, 3);
            txtVacante.Name = "txtVacante";
            txtVacante.Size = new Size(116, 23);
            txtVacante.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 172);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "Vacantes:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 373);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 14;
            label5.Text = "Centro de estudios:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboNomProf
            // 
            cboNomProf.BackColor = SystemColors.ScrollBar;
            cboNomProf.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNomProf.FormattingEnabled = true;
            cboNomProf.Location = new Point(168, 119);
            cboNomProf.Margin = new Padding(4, 3, 4, 3);
            cboNomProf.Name = "cboNomProf";
            cboNomProf.Size = new Size(398, 23);
            cboNomProf.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 321);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 12;
            label7.Text = "Hora de Fin:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 272);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 10;
            label6.Text = "Hora de Inicio:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 224);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 8;
            label4.Text = "Dia: ";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre del Profesor: ";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(36, 440);
            chkActivo.Margin = new Padding(4, 3, 4, 3);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(67, 19);
            chkActivo.TabIndex = 16;
            chkActivo.Text = "ACTIVO";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // cboNomCurso
            // 
            cboNomCurso.BackColor = SystemColors.ScrollBar;
            cboNomCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNomCurso.FormattingEnabled = true;
            cboNomCurso.Location = new Point(168, 70);
            cboNomCurso.Margin = new Padding(4, 3, 4, 3);
            cboNomCurso.Name = "cboNomCurso";
            cboNomCurso.Size = new Size(398, 23);
            cboNomCurso.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre del Curso: ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 25);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 0;
            label8.Text = "Codigo Seccion: ";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(168, 25);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(133, 23);
            lblCodigo.TabIndex = 1;
            // 
            // cboCentroEst
            // 
            cboCentroEst.BackColor = SystemColors.ScrollBar;
            cboCentroEst.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCentroEst.FormattingEnabled = true;
            cboCentroEst.Location = new Point(168, 369);
            cboCentroEst.Margin = new Padding(4, 3, 4, 3);
            cboCentroEst.Name = "cboCentroEst";
            cboCentroEst.Size = new Size(398, 23);
            cboCentroEst.TabIndex = 15;
            // 
            // txtdia
            // 
            txtdia.Location = new Point(168, 224);
            txtdia.Margin = new Padding(4, 3, 4, 3);
            txtdia.Name = "txtdia";
            txtdia.Size = new Size(116, 23);
            txtdia.TabIndex = 9;
            // 
            // FrmActualizarSeccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 612);
            Controls.Add(lblCodigo);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(dtpHoraFin);
            Controls.Add(dtpHoraInicio);
            Controls.Add(txtdia);
            Controls.Add(txtVacante);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(cboCentroEst);
            Controls.Add(cboNomProf);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(chkActivo);
            Controls.Add(cboNomCurso);
            Controls.Add(label8);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmActualizarSeccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ACTUALIZAR SECCION";
            Load += FrmActualizarSeccion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGrabar;
        private DateTimePicker dtpHoraFin;
        private DateTimePicker dtpHoraInicio;
        private TextBox txtVacante;
        private Label label3;
        private Label label5;
        private ComboBox cboNomProf;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label2;
        private CheckBox chkActivo;
        private ComboBox cboNomCurso;
        private Label label1;
        private Label label8;
        private Label lblCodigo;
        private ComboBox cboCentroEst;
        private TextBox txtdia;
    }
}