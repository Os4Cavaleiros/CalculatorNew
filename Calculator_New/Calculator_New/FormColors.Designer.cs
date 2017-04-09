namespace Calculator_New
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
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.groupBoxDefaultColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDefaultColors
            // 
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
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRed.Location = new System.Drawing.Point(16, 24);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(27, 26);
            this.buttonRed.TabIndex = 0;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGreen.Location = new System.Drawing.Point(49, 24);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(27, 26);
            this.buttonGreen.TabIndex = 1;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
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
    }
}