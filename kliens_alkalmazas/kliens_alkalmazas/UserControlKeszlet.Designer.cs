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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(916, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // listBoxBeszallitok
            // 
            this.listBoxBeszallitok.FormattingEnabled = true;
            this.listBoxBeszallitok.ItemHeight = 16;
            this.listBoxBeszallitok.Location = new System.Drawing.Point(38, 442);
            this.listBoxBeszallitok.Name = "listBoxBeszallitok";
            this.listBoxBeszallitok.Size = new System.Drawing.Size(240, 100);
            this.listBoxBeszallitok.TabIndex = 1;
            this.listBoxBeszallitok.SelectedIndexChanged += new System.EventHandler(this.listBoxBeszallitok_SelectedIndexChanged);
            // 
            // buttonCsv
            // 
            this.buttonCsv.Location = new System.Drawing.Point(727, 561);
            this.buttonCsv.Name = "buttonCsv";
            this.buttonCsv.Size = new System.Drawing.Size(227, 44);
            this.buttonCsv.TabIndex = 2;
            this.buttonCsv.Text = "Rendelendő termékek exportálása";
            this.buttonCsv.UseVisualStyleBackColor = true;
            this.buttonCsv.Click += new System.EventHandler(this.buttonCsv_Click);
            // 
            // buttonOsszes
            // 
            this.buttonOsszes.Location = new System.Drawing.Point(39, 561);
            this.buttonOsszes.Name = "buttonOsszes";
            this.buttonOsszes.Size = new System.Drawing.Size(239, 44);
            this.buttonOsszes.TabIndex = 3;
            this.buttonOsszes.Text = "Összes termék";
            this.buttonOsszes.UseVisualStyleBackColor = true;
            this.buttonOsszes.Click += new System.EventHandler(this.buttonOsszes_Click);
            // 
            // labelBeszallitok
            // 
            this.labelBeszallitok.AutoSize = true;
            this.labelBeszallitok.Location = new System.Drawing.Point(35, 411);
            this.labelBeszallitok.Name = "labelBeszallitok";
            this.labelBeszallitok.Size = new System.Drawing.Size(72, 16);
            this.labelBeszallitok.TabIndex = 4;
            this.labelBeszallitok.Text = "Beszállítók";
            // 
            // textBoxPlusz
            // 
            this.textBoxPlusz.Location = new System.Drawing.Point(395, 520);
            this.textBoxPlusz.Name = "textBoxPlusz";
            this.textBoxPlusz.Size = new System.Drawing.Size(77, 22);
            this.textBoxPlusz.TabIndex = 5;
            // 
            // buttonPlusz
            // 
            this.buttonPlusz.Location = new System.Drawing.Point(492, 516);
            this.buttonPlusz.Name = "buttonPlusz";
            this.buttonPlusz.Size = new System.Drawing.Size(70, 31);
            this.buttonPlusz.TabIndex = 7;
            this.buttonPlusz.Text = "+";
            this.buttonPlusz.UseVisualStyleBackColor = true;
            this.buttonPlusz.Click += new System.EventHandler(this.buttonPlusz_Click);
            // 
            // labelPlusz
            // 
            this.labelPlusz.AutoSize = true;
            this.labelPlusz.Location = new System.Drawing.Point(392, 487);
            this.labelPlusz.Name = "labelPlusz";
            this.labelPlusz.Size = new System.Drawing.Size(109, 16);
            this.labelPlusz.TabIndex = 8;
            this.labelPlusz.Text = "Készlet frissítése:";
            // 
            // UserControlKeszlet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.labelPlusz);
            this.Controls.Add(this.buttonPlusz);
            this.Controls.Add(this.textBoxPlusz);
            this.Controls.Add(this.labelBeszallitok);
            this.Controls.Add(this.buttonOsszes);
            this.Controls.Add(this.buttonCsv);
            this.Controls.Add(this.listBoxBeszallitok);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControlKeszlet";
            this.Size = new System.Drawing.Size(1146, 638);
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
