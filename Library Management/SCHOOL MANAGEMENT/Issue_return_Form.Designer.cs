namespace SCHOOL_MANAGEMENT
{
    partial class Issue_return_Form
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
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button3;
            System.Windows.Forms.Button button4;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbookid = new System.Windows.Forms.ComboBox();
            this.txtmemid = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeluniversity = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtmemname = new System.Windows.Forms.ComboBox();
            this.txtbookname = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(250, 268);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(135, 31);
            button1.TabIndex = 4;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(48, 268);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(135, 31);
            button2.TabIndex = 53;
            button2.Text = "SHOW ISSUE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(632, 268);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(135, 31);
            button3.TabIndex = 54;
            button3.Text = "SHOW RETURN";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(443, 268);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(135, 31);
            button4.TabIndex = 55;
            button4.Text = "BACK";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MEMBER ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "BOOK ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbookid
            // 
            this.txtbookid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtbookid.FormattingEnabled = true;
            this.txtbookid.Location = new System.Drawing.Point(196, 174);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(121, 24);
            this.txtbookid.TabIndex = 2;
            this.txtbookid.SelectedIndexChanged += new System.EventHandler(this.txtbook_SelectedIndexChanged);
            // 
            // txtmemid
            // 
            this.txtmemid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtmemid.FormattingEnabled = true;
            this.txtmemid.Location = new System.Drawing.Point(196, 141);
            this.txtmemid.Name = "txtmemid";
            this.txtmemid.Size = new System.Drawing.Size(121, 24);
            this.txtmemid.TabIndex = 3;
            this.txtmemid.SelectedIndexChanged += new System.EventHandler(this.txtid_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 38);
            this.panel2.TabIndex = 39;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(337, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISSUE AND RETURN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labeluniversity);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 54);
            this.panel1.TabIndex = 38;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labeluniversity
            // 
            this.labeluniversity.AutoSize = true;
            this.labeluniversity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluniversity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labeluniversity.Location = new System.Drawing.Point(272, 14);
            this.labeluniversity.Name = "labeluniversity";
            this.labeluniversity.Size = new System.Drawing.Size(332, 25);
            this.labeluniversity.TabIndex = 4;
            this.labeluniversity.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(719, 182);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtmemname
            // 
            this.txtmemname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtmemname.FormattingEnabled = true;
            this.txtmemname.Location = new System.Drawing.Point(599, 141);
            this.txtmemname.Name = "txtmemname";
            this.txtmemname.Size = new System.Drawing.Size(121, 24);
            this.txtmemname.TabIndex = 48;
            this.txtmemname.SelectedIndexChanged += new System.EventHandler(this.txtmemname_SelectedIndexChanged);
            // 
            // txtbookname
            // 
            this.txtbookname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtbookname.FormattingEnabled = true;
            this.txtbookname.Location = new System.Drawing.Point(599, 174);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(121, 24);
            this.txtbookname.TabIndex = 47;
            this.txtbookname.SelectedIndexChanged += new System.EventHandler(this.txtbookname_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "BOOK NAME";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "MEMBER NAME";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtcategory
            // 
            this.txtcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcategory.FormattingEnabled = true;
            this.txtcategory.Location = new System.Drawing.Point(421, 212);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(121, 24);
            this.txtcategory.TabIndex = 50;
            this.txtcategory.SelectedIndexChanged += new System.EventHandler(this.txtcategory_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "BOOK CATEGORY";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ISSUE",
            "RETURN"});
            this.comboBox1.Location = new System.Drawing.Point(409, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 52;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "OPTION";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LIBRARY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(841, 563);
            this.Controls.Add(button4);
            this.Controls.Add(button3);
            this.Controls.Add(button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmemname);
            this.Controls.Add(this.txtbookname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(button1);
            this.Controls.Add(this.txtmemid);
            this.Controls.Add(this.txtbookid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LIBRARY";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LIBRARY_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtbookid;
        private System.Windows.Forms.ComboBox txtmemid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeluniversity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox txtmemname;
        private System.Windows.Forms.ComboBox txtbookname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtcategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
    }
}