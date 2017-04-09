﻿namespace Calculator_New
{
    partial class FormColors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormColors));
            this.groupBoxDefaultColors = new System.Windows.Forms.GroupBox();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonTransparent = new System.Windows.Forms.Button();
            this.groupBoxDefaultColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDefaultColors
            // 
            this.groupBoxDefaultColors.Controls.Add(this.buttonTransparent);
            this.groupBoxDefaultColors.Controls.Add(this.buttonBlue);
            this.groupBoxDefaultColors.Controls.Add(this.buttonGreen);
            this.groupBoxDefaultColors.Controls.Add(this.buttonRed);
            this.groupBoxDefaultColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDefaultColors.Location = new System.Drawing.Point(13, 13);
            this.groupBoxDefaultColors.Name = "groupBoxDefaultColors";
            this.groupBoxDefaultColors.Size = new System.Drawing.Size(259, 104);
            this.groupBoxDefaultColors.TabIndex = 1;
            this.groupBoxDefaultColors.TabStop = false;
            this.groupBoxDefaultColors.Text = "Default";
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGreen.Location = new System.Drawing.Point(83, 24);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(27, 26);
            this.buttonGreen.TabIndex = 1;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRed.Location = new System.Drawing.Point(50, 24);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(27, 26);
            this.buttonRed.TabIndex = 0;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBlue.Location = new System.Drawing.Point(116, 24);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(27, 26);
            this.buttonBlue.TabIndex = 2;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonTransparent
            // 
            this.buttonTransparent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTransparent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTransparent.BackgroundImage")));
            this.buttonTransparent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTransparent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransparent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransparent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTransparent.Location = new System.Drawing.Point(17, 24);
            this.buttonTransparent.Name = "buttonTransparent";
            this.buttonTransparent.Size = new System.Drawing.Size(27, 26);
            this.buttonTransparent.TabIndex = 3;
            this.buttonTransparent.UseVisualStyleBackColor = false;
            this.buttonTransparent.Click += new System.EventHandler(this.buttonTransparent_Click);
            // 
            // FormColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBoxDefaultColors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormColors";
            this.Text = "Colors";
            this.groupBoxDefaultColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDefaultColors;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonTransparent;
    }
}