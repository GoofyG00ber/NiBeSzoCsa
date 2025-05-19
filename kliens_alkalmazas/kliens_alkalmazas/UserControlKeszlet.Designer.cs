namespace kliens_alkalmazas
{
    partial class UserControlKeszlet
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
            this.listBoxBeszallitok = new System.Windows.Forms.ListBox();
            this.buttonCsv = new System.Windows.Forms.Button();
            this.buttonOsszes = new System.Windows.Forms.Button();
            this.labelBeszallitok = new System.Windows.Forms.Label();
            this.textBoxPlusz = new System.Windows.Forms.TextBox();
            this.buttonPlusz = new System.Windows.Forms.Button();
            this.labelPlusz = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(165, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // listBoxBeszallitok
            // 
            this.listBoxBeszallitok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxBeszallitok.FormattingEnabled = true;
            this.listBoxBeszallitok.ItemHeight = 20;
            this.listBoxBeszallitok.Location = new System.Drawing.Point(165, 552);
            this.listBoxBeszallitok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxBeszallitok.Name = "listBoxBeszallitok";
            this.listBoxBeszallitok.Size = new System.Drawing.Size(270, 124);
            this.listBoxBeszallitok.TabIndex = 1;
            this.listBoxBeszallitok.SelectedIndexChanged += new System.EventHandler(this.listBoxBeszallitok_SelectedIndexChanged);
            // 
            // buttonCsv
            // 
            this.buttonCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCsv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCsv.Location = new System.Drawing.Point(940, 701);
            this.buttonCsv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCsv.Name = "buttonCsv";
            this.buttonCsv.Size = new System.Drawing.Size(255, 55);
            this.buttonCsv.TabIndex = 2;
            this.buttonCsv.Text = "Rendelendő termékek exportálása";
            this.buttonCsv.UseVisualStyleBackColor = false;
            this.buttonCsv.Click += new System.EventHandler(this.buttonCsv_Click);
            // 
            // buttonOsszes
            // 
            this.buttonOsszes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOsszes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOsszes.Location = new System.Drawing.Point(165, 701);
            this.buttonOsszes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOsszes.Name = "buttonOsszes";
            this.buttonOsszes.Size = new System.Drawing.Size(269, 55);
            this.buttonOsszes.TabIndex = 3;
            this.buttonOsszes.Text = "Összes termék";
            this.buttonOsszes.UseVisualStyleBackColor = false;
            this.buttonOsszes.Click += new System.EventHandler(this.buttonOsszes_Click);
            // 
            // labelBeszallitok
            // 
            this.labelBeszallitok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBeszallitok.AutoSize = true;
            this.labelBeszallitok.Location = new System.Drawing.Point(165, 514);
            this.labelBeszallitok.Name = "labelBeszallitok";
            this.labelBeszallitok.Size = new System.Drawing.Size(85, 20);
            this.labelBeszallitok.TabIndex = 4;
            this.labelBeszallitok.Text = "Beszállítók";
            // 
            // textBoxPlusz
            // 
            this.textBoxPlusz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPlusz.Location = new System.Drawing.Point(444, 650);
            this.textBoxPlusz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPlusz.Name = "textBoxPlusz";
            this.textBoxPlusz.Size = new System.Drawing.Size(86, 26);
            this.textBoxPlusz.TabIndex = 5;
            // 
            // buttonPlusz
            // 
            this.buttonPlusz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlusz.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPlusz.Location = new System.Drawing.Point(554, 645);
            this.buttonPlusz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPlusz.Name = "buttonPlusz";
            this.buttonPlusz.Size = new System.Drawing.Size(79, 39);
            this.buttonPlusz.TabIndex = 7;
            this.buttonPlusz.Text = "+";
            this.buttonPlusz.UseVisualStyleBackColor = false;
            this.buttonPlusz.Click += new System.EventHandler(this.buttonPlusz_Click);
            // 
            // labelPlusz
            // 
            this.labelPlusz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPlusz.AutoSize = true;
            this.labelPlusz.Location = new System.Drawing.Point(441, 609);
            this.labelPlusz.Name = "labelPlusz";
            this.labelPlusz.Size = new System.Drawing.Size(132, 20);
            this.labelPlusz.TabIndex = 8;
            this.labelPlusz.Text = "Készlet frissítése:";
            // 
            // UserControlKeszlet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.labelPlusz);
            this.Controls.Add(this.buttonPlusz);
            this.Controls.Add(this.textBoxPlusz);
            this.Controls.Add(this.labelBeszallitok);
            this.Controls.Add(this.buttonOsszes);
            this.Controls.Add(this.buttonCsv);
            this.Controls.Add(this.listBoxBeszallitok);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlKeszlet";
            this.Size = new System.Drawing.Size(1289, 798);
            this.Load += new System.EventHandler(this.UserControlKeszlet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBoxBeszallitok;
        private System.Windows.Forms.Button buttonCsv;
        private System.Windows.Forms.Button buttonOsszes;
        private System.Windows.Forms.Label labelBeszallitok;
        private System.Windows.Forms.TextBox textBoxPlusz;
        private System.Windows.Forms.Button buttonPlusz;
        private System.Windows.Forms.Label labelPlusz;
    }
}
