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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonKeszlet = new System.Windows.Forms.Button();
            this.buttonRendeles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(131, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 426);
            this.panel1.TabIndex = 0;
            // 
            // buttonKeszlet
            // 
            this.buttonKeszlet.Location = new System.Drawing.Point(12, 59);
            this.buttonKeszlet.Name = "buttonKeszlet";
            this.buttonKeszlet.Size = new System.Drawing.Size(113, 46);
            this.buttonKeszlet.TabIndex = 1;
            this.buttonKeszlet.Text = "Készlet";
            this.buttonKeszlet.UseVisualStyleBackColor = true;
            this.buttonKeszlet.Click += new System.EventHandler(this.buttonKeszlet_Click);
            // 
            // buttonRendeles
            // 
            this.buttonRendeles.Location = new System.Drawing.Point(12, 128);
            this.buttonRendeles.Name = "buttonRendeles";
            this.buttonRendeles.Size = new System.Drawing.Size(113, 46);
            this.buttonRendeles.TabIndex = 2;
            this.buttonRendeles.Text = "Rendelések";
            this.buttonRendeles.UseVisualStyleBackColor = true;
            this.buttonRendeles.Click += new System.EventHandler(this.buttonRendeles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRendeles);
            this.Controls.Add(this.buttonKeszlet);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonKeszlet;
        private System.Windows.Forms.Button buttonRendeles;
    }
}

