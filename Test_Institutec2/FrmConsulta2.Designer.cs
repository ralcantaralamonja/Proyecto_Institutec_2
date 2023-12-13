namespace Test_Institutec2
{
    partial class FrmConsulta2
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
            cboEspecialidad = new ComboBox();
            btnBuscar = new Button();
            label1 = new Label();
            dtgEspecialistas = new DataGridView();
            txtNumero = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgEspecialistas).BeginInit();
            SuspendLayout();
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Location = new Point(244, 347);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(121, 23);
            cboEspecialidad.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(355, 35);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 39);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione Especialidad :";
            // 
            // dtgEspecialistas
            // 
            dtgEspecialistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEspecialistas.Location = new Point(43, 100);
            dtgEspecialistas.Name = "dtgEspecialistas";
            dtgEspecialistas.RowTemplate.Height = 25;
            dtgEspecialistas.Size = new Size(387, 209);
            dtgEspecialistas.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(197, 35);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 4;
            // 
            // FrmConsulta2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 394);
            Controls.Add(txtNumero);
            Controls.Add(dtgEspecialistas);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Controls.Add(cboEspecialidad);
            Name = "FrmConsulta2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de profesores especialistas";
            Load += FrmConsulta2_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEspecialistas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboEspecialidad;
        private Button btnBuscar;
        private Label label1;
        private DataGridView dtgEspecialistas;
        private TextBox txtNumero;
    }
}