namespace kliens_alkalmazas
{
    partial class UserControlRendeles
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTermekek = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSzallitas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(411, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelTermekek
            // 
            this.labelTermekek.AutoSize = true;
            this.labelTermekek.Location = new System.Drawing.Point(444, 67);
            this.labelTermekek.Name = "labelTermekek";
            this.labelTermekek.Size = new System.Drawing.Size(69, 16);
            this.labelTermekek.TabIndex = 3;
            this.labelTermekek.Text = "Termékek";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(444, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 100);
            this.listBox1.TabIndex = 5;
            // 
            // buttonSzallitas
            // 
            this.buttonSzallitas.Location = new System.Drawing.Point(459, 381);
            this.buttonSzallitas.Name = "buttonSzallitas";
            this.buttonSzallitas.Size = new System.Drawing.Size(133, 30);
            this.buttonSzallitas.TabIndex = 6;
            this.buttonSzallitas.Text = "Szállításra kész";
            this.buttonSzallitas.UseVisualStyleBackColor = true;
            this.buttonSzallitas.Click += new System.EventHandler(this.buttonSzallitas_Click);
            // 
            // UserControlRendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.buttonSzallitas);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelTermekek);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControlRendeles";
            this.Size = new System.Drawing.Size(621, 580);
            this.Load += new System.EventHandler(this.UserControlRendeles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTermekek;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSzallitas;
    }
}
