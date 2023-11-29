namespace ProyInstitutec_GUI
{
    partial class FrmInsertarProfesor
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
            txtNomPro = new TextBox();
            txtApePat = new TextBox();
            lblNombre = new Label();
            lblApePat = new Label();
            lblApeMat = new Label();
            lblDni = new Label();
            label5 = new Label();
            txtTelf = new TextBox();
            cboDep = new ComboBox();
            groupBox1 = new GroupBox();
            btnImagen = new Button();
            pcbFoto = new PictureBox();
            groupBox3 = new GroupBox();
            chkActivo = new CheckBox();
            btnCancelar = new Button();
            dtpFecIng = new DateTimePicker();
            btnIngresar = new Button();
            label2 = new Label();
            label4 = new Label();
            txtApeMat = new TextBox();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtDni = new TextBox();
            groupBox2 = new GroupBox();
            optM = new RadioButton();
            optF = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomPro
            // 
            txtNomPro.CharacterCasing = CharacterCasing.Upper;

            txtNomPro.Location = new Point(22, 88);
            txtNomPro.Margin = new Padding(3, 4, 3, 4);
            txtNomPro.Name = "txtNomPro";
            txtNomPro.Size = new Size(357, 32);
            txtNomPro.TabIndex = 1;
            txtNomPro.TextChanged += txtNomPro_TextChanged;
            // 
            // txtApePat
            // 
            txtApePat.CharacterCasing = CharacterCasing.Upper;
            txtApePat.Location = new Point(22, 172);
            txtApePat.Margin = new Padding(3, 4, 3, 4);
            txtApePat.Name = "txtApePat";
            txtApePat.Size = new Size(357, 32);
            txtApePat.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;

            lblNombre.Location = new Point(22, 56);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(98, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE:";
            // 
            // lblApePat
            // 
            lblApePat.AutoSize = true;
            lblApePat.Location = new Point(21, 140);
            lblApePat.Name = "lblApePat";
            lblApePat.Size = new Size(199, 23);
            lblApePat.TabIndex = 2;
            lblApePat.Text = "APELLIDO PATERNO";
            // 
            // lblApeMat
            // 
            lblApeMat.AutoSize = true;
            lblApeMat.Location = new Point(22, 224);
            lblApeMat.Name = "lblApeMat";
            lblApeMat.Size = new Size(209, 23);
            lblApeMat.TabIndex = 4;
            lblApeMat.Text = "APELLIDO MATERNO:";
            lblApeMat.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(400, 56);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(50, 23);
            lblDni.TabIndex = 6;
            lblDni.Text = "DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 322);
            label5.Name = "label5";
            label5.Size = new Size(171, 23);
            label5.TabIndex = 11;
            label5.Text = "DEPARTAMENTO:";
            // 
            // txtTelf
            // 
            txtTelf.Location = new Point(136, 608);
            txtTelf.Margin = new Padding(3, 4, 3, 4);
            txtTelf.MaxLength = 9;
            txtTelf.Name = "txtTelf";
            txtTelf.Size = new Size(242, 32);
            txtTelf.TabIndex = 18;
            txtTelf.KeyPress += txtDni_KeyPress;
            // 
            // cboDep
            // 
            cboDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDep.FormattingEnabled = true;
            cboDep.Location = new Point(21, 354);
            cboDep.Margin = new Padding(3, 4, 3, 4);
            cboDep.Name = "cboDep";
            cboDep.Size = new Size(358, 31);
            cboDep.TabIndex = 12;
            cboDep.SelectionChangeCommitted += cboDep_SelectionChangeCommitted;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnImagen);
            groupBox1.Controls.Add(pcbFoto);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(dtpFecIng);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtApeMat);
            groupBox1.Controls.Add(cboDistrito);
            groupBox1.Controls.Add(cboProvincia);
            groupBox1.Controls.Add(txtTelf);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cboDep);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(txtNomPro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblApePat);
            groupBox1.Controls.Add(txtApePat);
            groupBox1.Controls.Add(lblDni);
            groupBox1.Controls.Add(lblApeMat);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);

            groupBox1.Location = new Point(10, 11);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(661, 818);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS PERSONALES";
           
            // 
            // btnImagen
            // 
            btnImagen.Location = new Point(447, 516);
            btnImagen.Margin = new Padding(2, 2, 2, 2);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(169, 42);
            btnImagen.TabIndex = 24;
            btnImagen.Text = "CARGAR FOTO";
            btnImagen.UseVisualStyleBackColor = true;
            btnImagen.Click += btnImagen_Click;
            // 
            // pcbFoto
            // 
            pcbFoto.BorderStyle = BorderStyle.FixedSingle;
            pcbFoto.Location = new Point(419, 574);
            pcbFoto.Margin = new Padding(2, 2, 2, 2);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(220, 148);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 23;
            pcbFoto.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkActivo);
            groupBox3.Location = new Point(400, 330);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(201, 154);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "¿EL PROFESOR ESTA ACTIVO?";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(27, 70);
            chkActivo.Margin = new Padding(3, 4, 3, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(108, 27);
            chkActivo.TabIndex = 10;
            chkActivo.Text = "ACTIVO";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(473, 756);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 54);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtpFecIng
            // 
            dtpFecIng.Format = DateTimePickerFormat.Short;
            dtpFecIng.Location = new Point(136, 690);
            dtpFecIng.Margin = new Padding(3, 4, 3, 4);
            dtpFecIng.Name = "dtpFecIng";
            dtpFecIng.Size = new Size(246, 32);
            dtpFecIng.TabIndex = 20;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.ControlLight;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(306, 756);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(143, 54);
            btnIngresar.TabIndex = 21;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 698);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 19;
            label2.Text = "INGRESO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 616);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 17;
            label4.Text = "TELEFONO:";
            // 
            // txtApeMat
            // 
            txtApeMat.CharacterCasing = CharacterCasing.Upper;
            txtApeMat.Location = new Point(22, 258);
            txtApeMat.Margin = new Padding(3, 4, 3, 4);
            txtApeMat.Name = "txtApeMat";
            txtApeMat.Size = new Size(357, 32);
            txtApeMat.TabIndex = 5;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(21, 548);
            cboDistrito.Margin = new Padding(3, 4, 3, 4);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(358, 31);
            cboDistrito.TabIndex = 16;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(21, 454);
            cboProvincia.Margin = new Padding(3, 4, 3, 4);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(358, 31);
            cboProvincia.TabIndex = 14;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 516);
            label7.Name = "label7";
            label7.Size = new Size(95, 23);
            label7.TabIndex = 15;
            label7.Text = "DISTRITO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 422);
            label6.Name = "label6";
            label6.Size = new Size(127, 23);
            label6.TabIndex = 13;
            label6.Text = "PROVINCIA:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(400, 88);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(201, 32);
            txtDni.TabIndex = 7;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(optM);
            groupBox2.Controls.Add(optF);
            groupBox2.Location = new Point(400, 160);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(201, 128);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "GENERO";
            // 
            // optM
            // 
            optM.AutoSize = true;
            optM.Checked = true;
            optM.Location = new Point(51, 34);
            optM.Margin = new Padding(3, 4, 3, 4);
            optM.Name = "optM";
            optM.Size = new Size(148, 27);
            optM.TabIndex = 0;
            optM.TabStop = true;
            optM.Text = "MASCULINO";
            optM.UseVisualStyleBackColor = true;
            // 
            // optF
            // 
            optF.AutoSize = true;
            optF.Location = new Point(51, 76);
            optF.Margin = new Padding(3, 4, 3, 4);
            optF.Name = "optF";
            optF.Size = new Size(132, 27);
            optF.TabIndex = 1;
            optF.Text = "FEMENINO";
            optF.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmInsertarProfesor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(702, 840);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInsertarProfesor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CREAR PROFESOR";
            Load += FrmInsertarProfesor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNomPro;
        private TextBox txtApePat;
        private Label lblNombre;
        private Label lblApePat;
        private Label lblApeMat;
        private Label lblDni;
        private Label label5;
        private TextBox txtTelf;
        private ComboBox cboDep;
        private GroupBox groupBox1;
        private RadioButton optF;
        private RadioButton optM;
        private CheckBox chkActivo;
        private GroupBox groupBox2;
        internal TextBox txtDni;
        private Label label4;
        private Label label2;
        private Button btnIngresar;
        private Button btnCancelar;
        private ComboBox cboDistrito;
        private ComboBox cboProvincia;
        private Label label7;
        private Label label6;
        private TextBox txtApeMat;
        private DateTimePicker dtpFecIng;
        private GroupBox groupBox3;
        private Button btnImagen;
        private PictureBox pcbFoto;
        private OpenFileDialog openFileDialog1;
    }
}