﻿namespace Test_Institutec2
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
            label1 = new Label();
            dtgEspecialistas = new DataGridView();
            Profesor = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label4 = new Label();
            button1 = new Button();
            cboEspecialidad = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgEspecialistas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 2;
            label1.Text = "SELECCIONE ESPECIALIDAD:";
            // 
            // dtgEspecialistas
            // 
            dtgEspecialistas.AllowUserToAddRows = false;
            dtgEspecialistas.AllowUserToDeleteRows = false;
            dtgEspecialistas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgEspecialistas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgEspecialistas.BackgroundColor = SystemColors.ScrollBar;
            dtgEspecialistas.BorderStyle = BorderStyle.None;
            dtgEspecialistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEspecialistas.Columns.AddRange(new DataGridViewColumn[] { Profesor });
            dtgEspecialistas.Location = new Point(30, 51);
            dtgEspecialistas.Name = "dtgEspecialistas";
            dtgEspecialistas.ReadOnly = true;
            dtgEspecialistas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgEspecialistas.RowHeadersVisible = false;
            dtgEspecialistas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgEspecialistas.RowTemplate.Height = 25;
            dtgEspecialistas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEspecialistas.Size = new Size(610, 345);
            dtgEspecialistas.TabIndex = 3;
            dtgEspecialistas.TabStop = false;
            // 
            // Profesor
            // 
            Profesor.DataPropertyName = "Fullname";
            Profesor.HeaderText = "PROFESOR";
            Profesor.Name = "Profesor";
            Profesor.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 420);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 9;
            label2.Text = "REGISTROS:";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Window;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(533, 411);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 33);
            label4.TabIndex = 10;
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.Location = new Point(506, 464);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(134, 42);
            button1.TabIndex = 11;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Location = new Point(207, 17);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(192, 23);
            cboEspecialidad.TabIndex = 12;
            // 
            // FrmConsulta2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 526);
            Controls.Add(cboEspecialidad);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dtgEspecialistas);
            Controls.Add(label1);
            Name = "FrmConsulta2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de profesores especialistas";
            ((System.ComponentModel.ISupportInitialize)dtgEspecialistas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dtgEspecialistas;
        private Label label2;
        private Label label4;
        private Button button1;
        private DataGridViewTextBoxColumn Profesor;
        private ComboBox cboEspecialidad;
    }
}