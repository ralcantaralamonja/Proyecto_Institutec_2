namespace Test_Institutec
{
    partial class FrmInsertarSeccion
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
            dtpFin = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            txtVacante = new TextBox();
            label3 = new Label();
            label5 = new Label();
            cboCentroEst = new ComboBox();
            cboNomProf = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            chkActivo = new CheckBox();
            cboNomCurso = new ComboBox();
            label1 = new Label();
            txtdia = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(436, 496);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 42);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(273, 496);
            btnGrabar.Margin = new Padding(4, 3, 4, 3);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(134, 42);
            btnGrabar.TabIndex = 15;
            btnGrabar.Text = "GRABAR";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // dtpFin
            // 
            dtpFin.Format = DateTimePickerFormat.Time;
            dtpFin.Location = new Point(172, 279);
            dtpFin.Margin = new Padding(4, 3, 4, 3);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(132, 23);
            dtpFin.TabIndex = 11;
            dtpFin.Value = new DateTime(2023, 11, 25, 17, 25, 23, 0);
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Time;
            dtpInicio.Location = new Point(172, 231);
            dtpInicio.Margin = new Padding(4, 3, 4, 3);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(132, 23);
            dtpInicio.TabIndex = 9;
            dtpInicio.Value = new DateTime(2023, 11, 25, 17, 25, 23, 0);
            // 
            // txtVacante
            // 
            txtVacante.Location = new Point(172, 127);
            txtVacante.Margin = new Padding(4, 3, 4, 3);
            txtVacante.Name = "txtVacante";
            txtVacante.Size = new Size(132, 23);
            txtVacante.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 130);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Vacantes:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 331);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 12;
            label5.Text = "Centro de estudios:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboCentroEst
            // 
            cboCentroEst.BackColor = SystemColors.ScrollBar;
            cboCentroEst.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCentroEst.FormattingEnabled = true;
            cboCentroEst.Location = new Point(172, 328);
            cboCentroEst.Margin = new Padding(4, 3, 4, 3);
            cboCentroEst.Name = "cboCentroEst";
            cboCentroEst.Size = new Size(398, 23);
            cboCentroEst.TabIndex = 13;
            // 
            // cboNomProf
            // 
            cboNomProf.BackColor = SystemColors.ScrollBar;
            cboNomProf.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNomProf.FormattingEnabled = true;
            cboNomProf.Location = new Point(172, 77);
            cboNomProf.Margin = new Padding(4, 3, 4, 3);
            cboNomProf.Name = "cboNomProf";
            cboNomProf.Size = new Size(398, 23);
            cboNomProf.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 279);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 10;
            label7.Text = "Hora de Fin:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 231);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 8;
            label6.Text = "Hora de Inicio:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 182);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 6;
            label4.Text = "Dia: ";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre del Profesor: ";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(40, 398);
            chkActivo.Margin = new Padding(4, 3, 4, 3);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(67, 19);
            chkActivo.TabIndex = 14;
            chkActivo.Text = "ACTIVO";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // cboNomCurso
            // 
            cboNomCurso.BackColor = SystemColors.ScrollBar;
            cboNomCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNomCurso.FormattingEnabled = true;
            cboNomCurso.Location = new Point(172, 29);
            cboNomCurso.Margin = new Padding(4, 3, 4, 3);
            cboNomCurso.Name = "cboNomCurso";
            cboNomCurso.Size = new Size(398, 23);
            cboNomCurso.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Curso: ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtdia
            // 
            txtdia.Location = new Point(172, 182);
            txtdia.Margin = new Padding(4, 3, 4, 3);
            txtdia.Name = "txtdia";
            txtdia.Size = new Size(132, 23);
            txtdia.TabIndex = 7;
            // 
            // FrmInsertarSeccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 565);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(dtpFin);
            Controls.Add(dtpInicio);
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
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInsertarSeccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INSERTAR SECCION";
            Load += FrmInsertarSeccion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGrabar;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpInicio;
        private TextBox txtVacante;
        private Label label3;
        private Label label5;
        private ComboBox cboCentroEst;
        private ComboBox cboNomProf;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label2;
        private CheckBox chkActivo;
        private ComboBox cboNomCurso;
        private Label label1;
        private TextBox txtdia;
    }
}