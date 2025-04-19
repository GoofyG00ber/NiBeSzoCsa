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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(389, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // listBoxBeszallitok
            // 
            this.listBoxBeszallitok.FormattingEnabled = true;
            this.listBoxBeszallitok.ItemHeight = 16;
            this.listBoxBeszallitok.Location = new System.Drawing.Point(433, 69);
            this.listBoxBeszallitok.Name = "listBoxBeszallitok";
            this.listBoxBeszallitok.Size = new System.Drawing.Size(240, 100);
            this.listBoxBeszallitok.TabIndex = 1;
            this.listBoxBeszallitok.SelectedIndexChanged += new System.EventHandler(this.listBoxBeszallitok_SelectedIndexChanged);
            // 
            // buttonCsv
            // 
            this.buttonCsv.Location = new System.Drawing.Point(433, 314);
            this.buttonCsv.Name = "buttonCsv";
            this.buttonCsv.Size = new System.Drawing.Size(240, 59);
            this.buttonCsv.TabIndex = 2;
            this.buttonCsv.Text = "Rendelendő termékek exportálása";
            this.buttonCsv.UseVisualStyleBackColor = true;
            this.buttonCsv.Click += new System.EventHandler(this.buttonCsv_Click);
            // 
            // buttonOsszes
            // 
            this.buttonOsszes.Location = new System.Drawing.Point(433, 196);
            this.buttonOsszes.Name = "buttonOsszes";
            this.buttonOsszes.Size = new System.Drawing.Size(239, 44);
            this.buttonOsszes.TabIndex = 3;
            this.buttonOsszes.Text = "Összes termék";
            this.buttonOsszes.UseVisualStyleBackColor = true;
            this.buttonOsszes.Click += new System.EventHandler(this.buttonOsszes_Click);
            // 
            // UserControlKeszlet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.buttonOsszes);
            this.Controls.Add(this.buttonCsv);
            this.Controls.Add(this.listBoxBeszallitok);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControlKeszlet";
            this.Size = new System.Drawing.Size(687, 529);
            this.Load += new System.EventHandler(this.UserControlKeszlet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBoxBeszallitok;
        private System.Windows.Forms.Button buttonCsv;
        private System.Windows.Forms.Button buttonOsszes;
    }
}
