namespace PSS_ITWORKS.Presentation_Layer
{
    partial class Testing
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
            this.Test_btn = new System.Windows.Forms.Button();
            this.Test_dgv = new System.Windows.Forms.DataGridView();
            this.Strategy_cmb = new System.Windows.Forms.ComboBox();
            this.Method_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id_txt = new System.Windows.Forms.TextBox();
            this.filter_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Test_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Test_btn
            // 
            this.Test_btn.Location = new System.Drawing.Point(62, 268);
            this.Test_btn.Name = "Test_btn";
            this.Test_btn.Size = new System.Drawing.Size(122, 29);
            this.Test_btn.TabIndex = 0;
            this.Test_btn.Text = "Test";
            this.Test_btn.UseVisualStyleBackColor = true;
            this.Test_btn.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Test_dgv
            // 
            this.Test_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Test_dgv.Location = new System.Drawing.Point(295, 75);
            this.Test_dgv.Name = "Test_dgv";
            this.Test_dgv.Size = new System.Drawing.Size(456, 302);
            this.Test_dgv.TabIndex = 1;
            // 
            // Strategy_cmb
            // 
            this.Strategy_cmb.FormattingEnabled = true;
            this.Strategy_cmb.Location = new System.Drawing.Point(62, 75);
            this.Strategy_cmb.Name = "Strategy_cmb";
            this.Strategy_cmb.Size = new System.Drawing.Size(197, 21);
            this.Strategy_cmb.TabIndex = 2;
            // 
            // Method_cmb
            // 
            this.Method_cmb.FormattingEnabled = true;
            this.Method_cmb.Location = new System.Drawing.Point(62, 123);
            this.Method_cmb.Name = "Method_cmb";
            this.Method_cmb.Size = new System.Drawing.Size(196, 21);
            this.Method_cmb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stratagy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Method";
            // 
            // Id_txt
            // 
            this.Id_txt.Location = new System.Drawing.Point(62, 172);
            this.Id_txt.Name = "Id_txt";
            this.Id_txt.Size = new System.Drawing.Size(100, 20);
            this.Id_txt.TabIndex = 6;
            // 
            // filter_txt
            // 
            this.filter_txt.Location = new System.Drawing.Point(62, 226);
            this.filter_txt.Name = "filter_txt";
            this.filter_txt.Size = new System.Drawing.Size(100, 20);
            this.filter_txt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filter";
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filter_txt);
            this.Controls.Add(this.Id_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Method_cmb);
            this.Controls.Add(this.Strategy_cmb);
            this.Controls.Add(this.Test_dgv);
            this.Controls.Add(this.Test_btn);
            this.Name = "Testing";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Test_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Test_btn;
        private System.Windows.Forms.DataGridView Test_dgv;
        private System.Windows.Forms.ComboBox Strategy_cmb;
        private System.Windows.Forms.ComboBox Method_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Id_txt;
        private System.Windows.Forms.TextBox filter_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}