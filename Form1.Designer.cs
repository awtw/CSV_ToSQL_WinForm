namespace CsvToSql
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Open = new System.Windows.Forms.Button();
            this.Inesrt = new System.Windows.Forms.Button();
            this.database = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(988, 403);
            this.dataGridView1.TabIndex = 0;
            // 
            // Open
            // 
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Open.Location = new System.Drawing.Point(935, 452);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 33);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Inesrt
            // 
            this.Inesrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Inesrt.Location = new System.Drawing.Point(839, 452);
            this.Inesrt.Name = "Inesrt";
            this.Inesrt.Size = new System.Drawing.Size(75, 33);
            this.Inesrt.TabIndex = 2;
            this.Inesrt.Text = "Insert";
            this.Inesrt.UseVisualStyleBackColor = true;
            this.Inesrt.Click += new System.EventHandler(this.Inesrt_Click);
            // 
            // database
            // 
            this.database.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.database.Location = new System.Drawing.Point(702, 452);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(121, 33);
            this.database.TabIndex = 3;
            this.database.Text = "Go To database";
            this.database.UseVisualStyleBackColor = true;
            this.database.Click += new System.EventHandler(this.database_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 511);
            this.Controls.Add(this.database);
            this.Controls.Add(this.Inesrt);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Inesrt;
        private System.Windows.Forms.Button database;
    }
}

