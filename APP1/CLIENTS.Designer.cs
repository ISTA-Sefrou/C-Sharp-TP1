namespace APP1
{
    partial class CLIENTS
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCIN = new System.Windows.Forms.TextBox();
            this.textBoxNOM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPRENOM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDS = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIN :";
            // 
            // textBoxCIN
            // 
            this.textBoxCIN.Location = new System.Drawing.Point(125, 7);
            this.textBoxCIN.Name = "textBoxCIN";
            this.textBoxCIN.Size = new System.Drawing.Size(138, 20);
            this.textBoxCIN.TabIndex = 1;
            // 
            // textBoxNOM
            // 
            this.textBoxNOM.Location = new System.Drawing.Point(125, 54);
            this.textBoxNOM.Name = "textBoxNOM";
            this.textBoxNOM.Size = new System.Drawing.Size(138, 20);
            this.textBoxNOM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOM :";
            // 
            // textBoxPRENOM
            // 
            this.textBoxPRENOM.Location = new System.Drawing.Point(125, 102);
            this.textBoxPRENOM.Name = "textBoxPRENOM";
            this.textBoxPRENOM.Size = new System.Drawing.Size(138, 20);
            this.textBoxPRENOM.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRENOM :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DATE NAISSANCE :";
            // 
            // dateTimePickerDS
            // 
            this.dateTimePickerDS.Location = new System.Drawing.Point(125, 152);
            this.dateTimePickerDS.Name = "dateTimePickerDS";
            this.dateTimePickerDS.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDS.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "AJOUTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "SUPPRIMER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "MODIFIER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CLIENTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 344);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerDS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPRENOM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNOM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCIN);
            this.Controls.Add(this.label1);
            this.Name = "CLIENTS";
            this.Text = "CLIENTS";
            this.Load += new System.EventHandler(this.CLIENTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCIN;
        private System.Windows.Forms.TextBox textBoxNOM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPRENOM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}