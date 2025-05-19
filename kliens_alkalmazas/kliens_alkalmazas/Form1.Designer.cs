namespace kliens_alkalmazas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonKeszlet = new System.Windows.Forms.Button();
            this.buttonRendeles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 647);
            this.panel1.TabIndex = 0;
            // 
            // buttonKeszlet
            // 
            this.buttonKeszlet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.buttonKeszlet.Location = new System.Drawing.Point(12, 69);
            this.buttonKeszlet.Name = "buttonKeszlet";
            this.buttonKeszlet.Size = new System.Drawing.Size(113, 46);
            this.buttonKeszlet.TabIndex = 1;
            this.buttonKeszlet.Text = "Készlet";
            this.buttonKeszlet.UseVisualStyleBackColor = false;
            this.buttonKeszlet.Click += new System.EventHandler(this.buttonKeszlet_Click);
            // 
            // buttonRendeles
            // 
            this.buttonRendeles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(204)))));
            this.buttonRendeles.Location = new System.Drawing.Point(12, 128);
            this.buttonRendeles.Name = "buttonRendeles";
            this.buttonRendeles.Size = new System.Drawing.Size(113, 46);
            this.buttonRendeles.TabIndex = 2;
            this.buttonRendeles.Text = "Rendelések";
            this.buttonRendeles.UseVisualStyleBackColor = false;
            this.buttonRendeles.Click += new System.EventHandler(this.buttonRendeles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1194, 647);
            this.Controls.Add(this.buttonRendeles);
            this.Controls.Add(this.buttonKeszlet);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BakeBeam Készlet & Rendelés Kezelő";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonKeszlet;
        private System.Windows.Forms.Button buttonRendeles;
    }
}

