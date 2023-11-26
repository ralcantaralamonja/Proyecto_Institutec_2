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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodSeccion = new System.Windows.Forms.TextBox();
            this.dgtSeccion = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.seccionDCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idCodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProfesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomLocalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaIniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgtSeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionDCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FILTRO SECCION:";
            // 
            // txtCodSeccion
            // 
            this.txtCodSeccion.Location = new System.Drawing.Point(146, 19);
            this.txtCodSeccion.Name = "txtCodSeccion";
            this.txtCodSeccion.Size = new System.Drawing.Size(243, 20);
            this.txtCodSeccion.TabIndex = 1;
            this.txtCodSeccion.TextChanged += new System.EventHandler(this.txtCodSeccion_TextChanged);
            // 
            // dgtSeccion
            // 
            this.dgtSeccion.AllowUserToAddRows = false;
            this.dgtSeccion.AllowUserToDeleteRows = false;
            this.dgtSeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgtSeccion.AutoGenerateColumns = false;
            this.dgtSeccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtSeccion.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgtSeccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgtSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtSeccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCodsDataGridViewTextBoxColumn,
            this.nomCurDataGridViewTextBoxColumn,
            this.nomProfesorDataGridViewTextBoxColumn,
            this.nomLocalDataGridViewTextBoxColumn,
            this.diaDataGridViewTextBoxColumn,
            this.horaIniDataGridViewTextBoxColumn,
            this.horaFinDataGridViewTextBoxColumn,
            this.vacanteDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgtSeccion.DataSource = this.seccionDCBindingSource;
            this.dgtSeccion.Location = new System.Drawing.Point(29, 92);
            this.dgtSeccion.Name = "dgtSeccion";
            this.dgtSeccion.ReadOnly = true;
            this.dgtSeccion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgtSeccion.RowHeadersVisible = false;
            this.dgtSeccion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgtSeccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtSeccion.Size = new System.Drawing.Size(941, 464);
            this.dgtSeccion.TabIndex = 2;
            this.dgtSeccion.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(644, 664);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(115, 36);
            this.btnActualizar.TabIndex = 57;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(504, 664);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(115, 36);
            this.btnInsertar.TabIndex = 58;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(854, 664);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 36);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "SALIR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(799, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "REGISTROS:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.BackColor = System.Drawing.SystemColors.Window;
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(878, 581);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(92, 29);
            this.lblRegistros.TabIndex = 0;
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // seccionDCBindingSource
            // 
            this.seccionDCBindingSource.DataSource = typeof(Test_Institutec.ProxySeccion.SeccionDC);
            // 
            // idCodsDataGridViewTextBoxColumn
            // 
            this.idCodsDataGridViewTextBoxColumn.DataPropertyName = "IdCods";
            this.idCodsDataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.idCodsDataGridViewTextBoxColumn.Name = "idCodsDataGridViewTextBoxColumn";
            this.idCodsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomCurDataGridViewTextBoxColumn
            // 
            this.nomCurDataGridViewTextBoxColumn.DataPropertyName = "NomCur";
            this.nomCurDataGridViewTextBoxColumn.HeaderText = "CURSO";
            this.nomCurDataGridViewTextBoxColumn.Name = "nomCurDataGridViewTextBoxColumn";
            this.nomCurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomProfesorDataGridViewTextBoxColumn
            // 
            this.nomProfesorDataGridViewTextBoxColumn.DataPropertyName = "nomProfesor";
            this.nomProfesorDataGridViewTextBoxColumn.HeaderText = "PROFESOR";
            this.nomProfesorDataGridViewTextBoxColumn.Name = "nomProfesorDataGridViewTextBoxColumn";
            this.nomProfesorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomLocalDataGridViewTextBoxColumn
            // 
            this.nomLocalDataGridViewTextBoxColumn.DataPropertyName = "nomLocal";
            this.nomLocalDataGridViewTextBoxColumn.HeaderText = "LOCAL";
            this.nomLocalDataGridViewTextBoxColumn.Name = "nomLocalDataGridViewTextBoxColumn";
            this.nomLocalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaDataGridViewTextBoxColumn
            // 
            this.diaDataGridViewTextBoxColumn.DataPropertyName = "dia";
            this.diaDataGridViewTextBoxColumn.HeaderText = "DIA";
            this.diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            this.diaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaIniDataGridViewTextBoxColumn
            // 
            this.horaIniDataGridViewTextBoxColumn.DataPropertyName = "HoraIni";
            this.horaIniDataGridViewTextBoxColumn.HeaderText = "HORA INICIO";
            this.horaIniDataGridViewTextBoxColumn.Name = "horaIniDataGridViewTextBoxColumn";
            this.horaIniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaFinDataGridViewTextBoxColumn
            // 
            this.horaFinDataGridViewTextBoxColumn.DataPropertyName = "HoraFin";
            this.horaFinDataGridViewTextBoxColumn.HeaderText = "HORA FIN";
            this.horaFinDataGridViewTextBoxColumn.Name = "horaFinDataGridViewTextBoxColumn";
            this.horaFinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vacanteDataGridViewTextBoxColumn
            // 
            this.vacanteDataGridViewTextBoxColumn.DataPropertyName = "Vacante";
            this.vacanteDataGridViewTextBoxColumn.HeaderText = "VACANTE";
            this.vacanteDataGridViewTextBoxColumn.Name = "vacanteDataGridViewTextBoxColumn";
            this.vacanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 722);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dgtSeccion);
            this.Controls.Add(this.txtCodSeccion);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " MANTENIMIENTO SECCION";
            this.Load += new System.EventHandler(this.FrmSeccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtSeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionDCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodSeccion;
        private System.Windows.Forms.DataGridView dgtSeccion;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.BindingSource seccionDCBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProfesorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomLocalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaIniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}