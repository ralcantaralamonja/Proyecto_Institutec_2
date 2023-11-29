namespace ProyInstitutec_GUI
{
    partial class FrmActualizarProfesor
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
            gbActulizar = new GroupBox();
            btnFoto = new Button();
            pcbFoto = new PictureBox();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            cboDep = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            optFemenino = new RadioButton();
            optMasculino = new RadioButton();
            txtDNI = new TextBox();
            label6 = new Label();
            dtpFecIng = new DateTimePicker();
            lbltiempo = new Label();
            btnIngresar = new Button();
            btnSalir = new Button();
            groupBox1 = new GroupBox();
            optInactivo = new RadioButton();
            optActivo = new RadioButton();
            txtTelf = new TextBox();
            lblCodigo = new Label();
            txtApeMat = new TextBox();
            txtApePat = new TextBox();
            txtNompro = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            gbActulizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbActulizar
            // 
            gbActulizar.BackColor = SystemColors.Control;
            gbActulizar.Controls.Add(btnFoto);
            gbActulizar.Controls.Add(pcbFoto);
            gbActulizar.Controls.Add(cboDistrito);
            gbActulizar.Controls.Add(cboProvincia);
            gbActulizar.Controls.Add(cboDep);
            gbActulizar.Controls.Add(label9);
            gbActulizar.Controls.Add(label8);
            gbActulizar.Controls.Add(label7);
            gbActulizar.Controls.Add(groupBox2);
            gbActulizar.Controls.Add(txtDNI);
            gbActulizar.Controls.Add(label6);
            gbActulizar.Controls.Add(dtpFecIng);
            gbActulizar.Controls.Add(lbltiempo);
            gbActulizar.Controls.Add(btnIngresar);
            gbActulizar.Controls.Add(btnSalir);
            gbActulizar.Controls.Add(groupBox1);
            gbActulizar.Controls.Add(txtTelf);
            gbActulizar.Controls.Add(lblCodigo);
            gbActulizar.Controls.Add(txtApeMat);
            gbActulizar.Controls.Add(txtApePat);
            gbActulizar.Controls.Add(txtNompro);
            gbActulizar.Controls.Add(label5);
            gbActulizar.Controls.Add(label4);
            gbActulizar.Controls.Add(label3);
            gbActulizar.Controls.Add(label2);
            gbActulizar.Controls.Add(label1);
            gbActulizar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbActulizar.Location = new Point(19, 11);
            gbActulizar.Margin = new Padding(3, 4, 3, 4);
            gbActulizar.Name = "gbActulizar";
            gbActulizar.Padding = new Padding(3, 4, 3, 4);
            gbActulizar.Size = new Size(673, 1095);
            gbActulizar.TabIndex = 0;
            gbActulizar.TabStop = false;
            gbActulizar.Text = "DATOS A ACTUALIZAR";
            gbActulizar.Enter += gbActulizar_Enter;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(395, 579);
            btnFoto.Margin = new Padding(2, 3, 2, 3);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(207, 37);
            btnFoto.TabIndex = 23;
            btnFoto.Text = "CARGAR FOTO";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // pcbFoto
            // 
            pcbFoto.BorderStyle = BorderStyle.FixedSingle;
            pcbFoto.Location = new Point(410, 631);
            pcbFoto.Margin = new Padding(2, 3, 2, 3);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(184, 162);
            pcbFoto.TabIndex = 25;
            pcbFoto.TabStop = false;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(24, 631);
            cboDistrito.Margin = new Padding(3, 4, 3, 4);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(327, 31);
            cboDistrito.TabIndex = 13;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(25, 517);
            cboProvincia.Margin = new Padding(3, 4, 3, 4);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(327, 31);
            cboProvincia.TabIndex = 11;
            // 
            // cboDep
            // 
            cboDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDep.FormattingEnabled = true;
            cboDep.Location = new Point(25, 407);
            cboDep.Margin = new Padding(3, 4, 3, 4);
            cboDep.Name = "cboDep";
            cboDep.Size = new Size(327, 31);
            cboDep.TabIndex = 9;
            cboDep.SelectionChangeCommitted += cboDep_SelectionChangeCommitted_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 579);
            label9.Name = "label9";
            label9.Size = new Size(95, 23);
            label9.TabIndex = 12;
            label9.Text = "DISTRITO:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 473);
            label8.Name = "label8";
            label8.Size = new Size(127, 23);
            label8.TabIndex = 10;
            label8.Text = "PROVINCIA:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 375);
            label7.Name = "label7";
            label7.Size = new Size(171, 23);
            label7.TabIndex = 8;
            label7.Text = "DEPARTAMENTO:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(optFemenino);
            groupBox2.Controls.Add(optMasculino);
            groupBox2.Location = new Point(395, 196);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(229, 155);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Genero";
            // 
            // optFemenino
            // 
            optFemenino.AutoSize = true;
            optFemenino.Location = new Point(27, 92);
            optFemenino.Margin = new Padding(3, 4, 3, 4);
            optFemenino.Name = "optFemenino";
            optFemenino.Size = new Size(132, 27);
            optFemenino.TabIndex = 1;
            optFemenino.TabStop = true;
            optFemenino.Text = "FEMENINO";
            optFemenino.UseVisualStyleBackColor = true;
            // 
            // optMasculino
            // 
            optMasculino.AutoSize = true;
            optMasculino.Location = new Point(27, 36);
            optMasculino.Margin = new Padding(3, 4, 3, 4);
            optMasculino.Name = "optMasculino";
            optMasculino.Size = new Size(148, 27);
            optMasculino.TabIndex = 0;
            optMasculino.TabStop = true;
            optMasculino.Text = "MASCULINO";
            optMasculino.UseVisualStyleBackColor = true;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(395, 143);
            txtDNI.Margin = new Padding(3, 4, 3, 4);
            txtDNI.MaxLength = 345;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(229, 32);
            txtDNI.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(395, 111);
            label6.Name = "label6";
            label6.Size = new Size(50, 23);
            label6.TabIndex = 18;
            label6.Text = "DNI:";
            // 
            // dtpFecIng
            // 
            dtpFecIng.Format = DateTimePickerFormat.Short;
            dtpFecIng.Location = new Point(141, 823);
            dtpFecIng.Margin = new Padding(3, 4, 3, 4);
            dtpFecIng.Name = "dtpFecIng";
            dtpFecIng.Size = new Size(211, 32);
            dtpFecIng.TabIndex = 17;
            // 
            // lbltiempo
            // 
            lbltiempo.AutoSize = true;
            lbltiempo.Location = new Point(25, 823);
            lbltiempo.Name = "lbltiempo";
            lbltiempo.Size = new Size(102, 23);
            lbltiempo.TabIndex = 16;
            lbltiempo.Text = "INGRESO:";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.ControlLight;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Location = new Point(337, 909);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(143, 53);
            btnIngresar.TabIndex = 13;
            btnIngresar.Text = "GRABAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLight;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(510, 909);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(143, 53);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "CANCELAR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optInactivo);
            groupBox1.Controls.Add(optActivo);
            groupBox1.Location = new Point(395, 395);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(184, 160);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "¿EL PROFESOR ESTA ACTIVO?";
            // 
            // optInactivo
            // 
            optInactivo.AutoSize = true;
            optInactivo.Location = new Point(24, 119);
            optInactivo.Margin = new Padding(3, 4, 3, 4);
            optInactivo.Name = "optInactivo";
            optInactivo.Size = new Size(127, 27);
            optInactivo.TabIndex = 1;
            optInactivo.TabStop = true;
            optInactivo.Text = "INACTIVO";
            optInactivo.UseVisualStyleBackColor = true;
            // 
            // optActivo
            // 
            optActivo.AutoSize = true;
            optActivo.Checked = true;
            optActivo.Location = new Point(24, 63);
            optActivo.Margin = new Padding(3, 4, 3, 4);
            optActivo.Name = "optActivo";
            optActivo.Size = new Size(107, 27);
            optActivo.TabIndex = 0;
            optActivo.TabStop = true;
            optActivo.Text = "ACTIVO";
            optActivo.UseVisualStyleBackColor = true;
            // 
            // txtTelf
            // 
            txtTelf.Location = new Point(141, 732);
            txtTelf.Margin = new Padding(3, 4, 3, 4);
            txtTelf.MaxLength = 9;
            txtTelf.Name = "txtTelf";
            txtTelf.Size = new Size(212, 32);
            txtTelf.TabIndex = 15;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(186, 52);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(75, 30);
            lblCodigo.TabIndex = 1;
            // 
            // txtApeMat
            // 
            txtApeMat.Location = new Point(25, 315);
            txtApeMat.Margin = new Padding(3, 4, 3, 4);
            txtApeMat.Name = "txtApeMat";
            txtApeMat.Size = new Size(327, 32);
            txtApeMat.TabIndex = 7;
            // 
            // txtApePat
            // 
            txtApePat.Location = new Point(25, 228);
            txtApePat.Margin = new Padding(3, 4, 3, 4);
            txtApePat.Name = "txtApePat";
            txtApePat.Size = new Size(327, 32);
            txtApePat.TabIndex = 5;
            // 
            // txtNompro
            // 
            txtNompro.Location = new Point(25, 143);
            txtNompro.Margin = new Padding(3, 4, 3, 4);
            txtNompro.Name = "txtNompro";
            txtNompro.Size = new Size(327, 32);
            txtNompro.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 111);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 2;
            label5.Text = "NOMBRE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 283);
            label4.Name = "label4";
            label4.Size = new Size(209, 23);
            label4.TabIndex = 6;
            label4.Text = "APELLIDO MATERNO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 196);
            label3.Name = "label3";
            label3.Size = new Size(204, 23);
            label3.TabIndex = 4;
            label3.Text = "APELLIDO PATERNO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 736);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 14;
            label2.Text = "TELEFONO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 52);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 0;
            label1.Text = "ID PROFESOR";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmActualizarProfesor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(729, 1047);
            Controls.Add(gbActulizar);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmActualizarProfesor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actulizar Profesor";
            Load += FrmActualizarProfesor_Load;
            gbActulizar.ResumeLayout(false);
            gbActulizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbActulizar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblCodigo;
        private TextBox txtNompro;
        private TextBox txtApeMat;
        private TextBox txtApePat;
        private GroupBox groupBox1;
        private RadioButton optInactivo;
        private RadioButton optActivo;
        private TextBox txtTelf;
        private Button btnIngresar;
        private Button btnSalir;
        private DateTimePicker dtpFecIng;
        private Label lbltiempo;
        private GroupBox groupBox2;
        private RadioButton optMasculino;
        private Label label6;
        private RadioButton optFemenino;
        private TextBox txtDNI;
        private Label label7;
        private Label label9;
        private Label label8;
        private ComboBox cboDep;
        private ComboBox cboProvincia;
        private ComboBox cboDistrito;
        private PictureBox pcbFoto;
        private Button btnFoto;
        private OpenFileDialog openFileDialog1;
    }
}