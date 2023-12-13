﻿namespace ProyInstitutec_GUI
{
    partial class MDIPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            menuStrip1 = new MenuStrip();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            profesorToolStripMenuItem = new ToolStripMenuItem();
            estudianteToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            carreraToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            cONSULTASToolStripMenuItem = new ToolStripMenuItem();
            aLUMNOPORNRCToolStripMenuItem = new ToolStripMenuItem();
            sALIRToolStripMenuItem2 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lbl1 = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            lISTARESPECIALISTASToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientoToolStripMenuItem, cONSULTASToolStripMenuItem, sALIRToolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1101, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { profesorToolStripMenuItem, estudianteToolStripMenuItem, salirToolStripMenuItem, carreraToolStripMenuItem, salirToolStripMenuItem1 });
            mantenimientoToolStripMenuItem.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(159, 25);
            mantenimientoToolStripMenuItem.Text = "MANTENIMIENTO";
            // 
            // profesorToolStripMenuItem
            // 
            profesorToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("profesorToolStripMenuItem.BackgroundImage");
            profesorToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            profesorToolStripMenuItem.Size = new Size(175, 26);
            profesorToolStripMenuItem.Text = "PROFESOR";
            profesorToolStripMenuItem.Click += profesorToolStripMenuItem_Click;
            // 
            // estudianteToolStripMenuItem
            // 
            estudianteToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("estudianteToolStripMenuItem.BackgroundImage");
            estudianteToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            estudianteToolStripMenuItem.Size = new Size(175, 26);
            estudianteToolStripMenuItem.Text = "ESTUDIANTE";
            estudianteToolStripMenuItem.Click += estudianteToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("salirToolStripMenuItem.BackgroundImage");
            salirToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(175, 26);
            salirToolStripMenuItem.Text = "CURSO";
            // 
            // carreraToolStripMenuItem
            // 
            carreraToolStripMenuItem.BackgroundImage = (Image)resources.GetObject("carreraToolStripMenuItem.BackgroundImage");
            carreraToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            carreraToolStripMenuItem.Name = "carreraToolStripMenuItem";
            carreraToolStripMenuItem.Size = new Size(175, 26);
            carreraToolStripMenuItem.Text = "SECCION";
            carreraToolStripMenuItem.Click += carreraToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.BackgroundImage = (Image)resources.GetObject("salirToolStripMenuItem1.BackgroundImage");
            salirToolStripMenuItem1.BackgroundImageLayout = ImageLayout.None;
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(175, 26);
            salirToolStripMenuItem1.Text = "SALIR";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // cONSULTASToolStripMenuItem
            // 
            cONSULTASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aLUMNOPORNRCToolStripMenuItem, lISTARESPECIALISTASToolStripMenuItem });
            cONSULTASToolStripMenuItem.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cONSULTASToolStripMenuItem.Name = "cONSULTASToolStripMenuItem";
            cONSULTASToolStripMenuItem.Size = new Size(116, 25);
            cONSULTASToolStripMenuItem.Text = "CONSULTAS";
            // 
            // aLUMNOPORNRCToolStripMenuItem
            // 
            aLUMNOPORNRCToolStripMenuItem.Name = "aLUMNOPORNRCToolStripMenuItem";
            aLUMNOPORNRCToolStripMenuItem.Size = new Size(250, 26);
            aLUMNOPORNRCToolStripMenuItem.Text = "ALUMNO POR NRC";
            aLUMNOPORNRCToolStripMenuItem.Click += aLUMNOPORNRCToolStripMenuItem_Click;
            // 
            // sALIRToolStripMenuItem2
            // 
            sALIRToolStripMenuItem2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sALIRToolStripMenuItem2.Name = "sALIRToolStripMenuItem2";
            sALIRToolStripMenuItem2.Size = new Size(65, 25);
            sALIRToolStripMenuItem2.Text = "SALIR";
            sALIRToolStripMenuItem2.Click += sALIRToolStripMenuItem2_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl1, lblUsuario });
            statusStrip1.Location = new Point(0, 990);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 21, 0);
            statusStrip1.Size = new Size(1101, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl1
            // 
            lbl1.BackColor = SystemColors.ActiveCaptionText;
            lbl1.ForeColor = SystemColors.ButtonHighlight;
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(50, 17);
            lbl1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = Color.Black;
            lblUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(118, 17);
            lblUsuario.Text = "toolStripStatusLabel2";
            // 
            // lISTARESPECIALISTASToolStripMenuItem
            // 
            lISTARESPECIALISTASToolStripMenuItem.Name = "lISTARESPECIALISTASToolStripMenuItem";
            lISTARESPECIALISTASToolStripMenuItem.Size = new Size(250, 26);
            lISTARESPECIALISTASToolStripMenuItem.Text = "LISTAR ESPECIALISTAS";
            lISTARESPECIALISTASToolStripMenuItem.Click += lISTARESPECIALISTASToolStripMenuItem_Click;
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DarkGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1101, 1012);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "MDIPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BIENVENIDO A INSTITUTEC";
            WindowState = FormWindowState.Maximized;
            FormClosing += MDIPrincipal_FormClosing;
            FormClosed += MDIPrincipal_FormClosed;
            Load += MDIPrincipal_Load;
            Resize += MDIPrincipal_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem profesorToolStripMenuItem;
        private ToolStripMenuItem estudianteToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem carreraToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl1;
        private ToolStripStatusLabel lblUsuario;
        private ToolStripMenuItem sALIRToolStripMenuItem2;
        private ToolStripMenuItem cONSULTASToolStripMenuItem;
        private ToolStripMenuItem aLUMNOPORNRCToolStripMenuItem;
        private ToolStripMenuItem lISTARESPECIALISTASToolStripMenuItem;
    }
}