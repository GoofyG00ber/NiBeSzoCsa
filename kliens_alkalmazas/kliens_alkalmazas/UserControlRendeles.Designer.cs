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
            this.buttonFrissites = new System.Windows.Forms.Button();
            this.comboBoxStatusz = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(139)))), ((int)(((byte)(142)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(150, 69);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(893, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // labelTermekek
            // 
            this.labelTermekek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTermekek.AutoSize = true;
            this.labelTermekek.Location = new System.Drawing.Point(147, 437);
            this.labelTermekek.Name = "labelTermekek";
            this.labelTermekek.Size = new System.Drawing.Size(69, 16);
            this.labelTermekek.TabIndex = 3;
            this.labelTermekek.Text = "Termékek";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(150, 469);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(453, 100);
            this.listBox1.TabIndex = 5;
            // 
            // buttonFrissites
            // 
            this.buttonFrissites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFrissites.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFrissites.Location = new System.Drawing.Point(803, 542);
            this.buttonFrissites.Name = "buttonFrissites";
            this.buttonFrissites.Size = new System.Drawing.Size(133, 30);
            this.buttonFrissites.TabIndex = 6;
            this.buttonFrissites.Text = "Státusz frissítése";
            this.buttonFrissites.UseVisualStyleBackColor = false;
            this.buttonFrissites.Click += new System.EventHandler(this.buttonSzallitas_Click);
            // 
            // comboBoxStatusz
            // 
            this.comboBoxStatusz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatusz.FormattingEnabled = true;
            this.comboBoxStatusz.Location = new System.Drawing.Point(632, 542);
            this.comboBoxStatusz.Name = "comboBoxStatusz";
            this.comboBoxStatusz.Size = new System.Drawing.Size(152, 24);
            this.comboBoxStatusz.TabIndex = 7;
            // 
            // UserControlRendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.comboBoxStatusz);
            this.Controls.Add(this.buttonFrissites);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelTermekek);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControlRendeles";
            this.Size = new System.Drawing.Size(1078, 619);
            this.Load += new System.EventHandler(this.UserControlRendeles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTermekek;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonFrissites;
        private System.Windows.Forms.ComboBox comboBoxStatusz;
    }
}
