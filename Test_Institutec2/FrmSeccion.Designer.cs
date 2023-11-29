namespace Test_Institutec
{
    partial class FrmSeccion
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
            label1 = new Label();
            txtCodSeccion = new TextBox();
            dgtSeccion = new DataGridView();
            idCodsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomCurDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomProfesorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomLocalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horaIniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horaFinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vacanteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            seccionDCBindingSource = new BindingSource(components);
            btnActualizar = new Button();
            btnInsertar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            lblRegistros = new Label();
            ((System.ComponentModel.ISupportInitialize)dgtSeccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seccionDCBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "FILTRO SECCION:";
            // 
            // txtCodSeccion
            // 
            txtCodSeccion.Location = new Point(170, 22);
            txtCodSeccion.Margin = new Padding(4, 3, 4, 3);
            txtCodSeccion.Name = "txtCodSeccion";
            txtCodSeccion.Size = new Size(283, 23);
            txtCodSeccion.TabIndex = 1;
            txtCodSeccion.TextChanged += txtCodSeccion_TextChanged;
            // 
            // dgtSeccion
            // 
            dgtSeccion.AllowUserToAddRows = false;
            dgtSeccion.AllowUserToDeleteRows = false;
            dgtSeccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgtSeccion.AutoGenerateColumns = false;
            dgtSeccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtSeccion.BackgroundColor = SystemColors.ScrollBar;
            dgtSeccion.BorderStyle = BorderStyle.None;
            dgtSeccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtSeccion.Columns.AddRange(new DataGridViewColumn[] { idCodsDataGridViewTextBoxColumn, nomCurDataGridViewTextBoxColumn, nomProfesorDataGridViewTextBoxColumn, nomLocalDataGridViewTextBoxColumn, diaDataGridViewTextBoxColumn, horaIniDataGridViewTextBoxColumn, horaFinDataGridViewTextBoxColumn, vacanteDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn });
            dgtSeccion.DataSource = seccionDCBindingSource;
            dgtSeccion.Location = new Point(30, 61);
            dgtSeccion.Margin = new Padding(4, 3, 4, 3);
            dgtSeccion.Name = "dgtSeccion";
            dgtSeccion.ReadOnly = true;
            dgtSeccion.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgtSeccion.RowHeadersVisible = false;
            dgtSeccion.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgtSeccion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgtSeccion.Size = new Size(1097, 476);
            dgtSeccion.TabIndex = 2;
            dgtSeccion.TabStop = false;
            // 
            // idCodsDataGridViewTextBoxColumn
            // 
            idCodsDataGridViewTextBoxColumn.DataPropertyName = "IdCods";
            idCodsDataGridViewTextBoxColumn.HeaderText = "CODIGO";
            idCodsDataGridViewTextBoxColumn.Name = "idCodsDataGridViewTextBoxColumn";
            idCodsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomCurDataGridViewTextBoxColumn
            // 
            nomCurDataGridViewTextBoxColumn.DataPropertyName = "NomCur";
            nomCurDataGridViewTextBoxColumn.HeaderText = "CURSO";
            nomCurDataGridViewTextBoxColumn.Name = "nomCurDataGridViewTextBoxColumn";
            nomCurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomProfesorDataGridViewTextBoxColumn
            // 
            nomProfesorDataGridViewTextBoxColumn.DataPropertyName = "nomProfesor";
            nomProfesorDataGridViewTextBoxColumn.HeaderText = "PROFESOR";
            nomProfesorDataGridViewTextBoxColumn.Name = "nomProfesorDataGridViewTextBoxColumn";
            nomProfesorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomLocalDataGridViewTextBoxColumn
            // 
            nomLocalDataGridViewTextBoxColumn.DataPropertyName = "nomLocal";
            nomLocalDataGridViewTextBoxColumn.HeaderText = "LOCAL";
            nomLocalDataGridViewTextBoxColumn.Name = "nomLocalDataGridViewTextBoxColumn";
            nomLocalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaDataGridViewTextBoxColumn
            // 
            diaDataGridViewTextBoxColumn.DataPropertyName = "dia";
            diaDataGridViewTextBoxColumn.HeaderText = "DIA";
            diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            diaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaIniDataGridViewTextBoxColumn
            // 
            horaIniDataGridViewTextBoxColumn.DataPropertyName = "HoraIni";
            horaIniDataGridViewTextBoxColumn.HeaderText = "HORA INICIO";
            horaIniDataGridViewTextBoxColumn.Name = "horaIniDataGridViewTextBoxColumn";
            horaIniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaFinDataGridViewTextBoxColumn
            // 
            horaFinDataGridViewTextBoxColumn.DataPropertyName = "HoraFin";
            horaFinDataGridViewTextBoxColumn.HeaderText = "HORA FIN";
            horaFinDataGridViewTextBoxColumn.Name = "horaFinDataGridViewTextBoxColumn";
            horaFinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vacanteDataGridViewTextBoxColumn
            // 
            vacanteDataGridViewTextBoxColumn.DataPropertyName = "Vacante";
            vacanteDataGridViewTextBoxColumn.HeaderText = "VACANTE";
            vacanteDataGridViewTextBoxColumn.Name = "vacanteDataGridViewTextBoxColumn";
            vacanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "ESTADO";
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seccionDCBindingSource
            // 
            seccionDCBindingSource.DataSource = typeof(ProxySeccion.SeccionDC);
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(748, 716);
            btnActualizar.Margin = new Padding(4, 3, 4, 3);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(134, 42);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(585, 716);
            btnInsertar.Margin = new Padding(4, 3, 4, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(134, 42);
            btnInsertar.TabIndex = 5;
            btnInsertar.Text = "INSERTAR";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(993, 716);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 42);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "SALIR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(929, 630);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "REGISTROS:";
            // 
            // lblRegistros
            // 
            lblRegistros.BackColor = SystemColors.Window;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(1021, 620);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(107, 33);
            lblRegistros.TabIndex = 4;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmSeccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 774);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(dgtSeccion);
            Controls.Add(txtCodSeccion);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSeccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " MANTENIMIENTO SECCION";
            Load += FrmSeccion_Load;
            ((System.ComponentModel.ISupportInitialize)dgtSeccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)seccionDCBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodSeccion;
        private DataGridView dgtSeccion;
        private Button btnActualizar;
        private Button btnInsertar;
        private Button btnCancelar;
        private Label label2;
        private Label lblRegistros;
        private DataGridViewTextBoxColumn idCodsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomCurDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomProfesorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomLocalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaIniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaFinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vacanteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private BindingSource seccionDCBindingSource;
    }
}