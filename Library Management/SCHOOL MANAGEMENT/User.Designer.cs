namespace SCHOOL_MANAGEMENT
{
    partial class User
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
            System.Windows.Forms.Button button4;
            this.txtcategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbookname = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeluniversity = new System.Windows.Forms.Label();
            this.txtbookid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(251, 219);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(135, 31);
            button1.TabIndex = 60;
            button1.Text = "REQUEST";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(444, 219);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(135, 31);
            button4.TabIndex = 74;
            button4.Text = "BACK";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtcategory
            // 
            this.txtcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcategory.FormattingEnabled = true;
            this.txtcategory.Location = new System.Drawing.Point(422, 163);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(121, 24);
            this.txtcategory.TabIndex = 69;
            this.txtcategory.SelectedIndexChanged += new System.EventHandler(this.txtcategory_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "BOOK CATEGORY";
            // 
            // txtbookname
            // 
            this.txtbookname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtbookname.FormattingEnabled = true;
            this.txtbookname.Location = new System.Drawing.Point(600, 125);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(121, 24);
            this.txtbookname.TabIndex = 66;
            this.txtbookname.SelectedIndexChanged += new System.EventHandler(this.txtbookname_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "BOOK NAME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-1, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 38);
            this.panel2.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(291, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "VIEW / REQUEST BOOK";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labeluniversity);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 54);
            this.panel1.TabIndex = 61;
            // 
            // labeluniversity
            // 
            this.labeluniversity.AutoSize = true;
            this.labeluniversity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluniversity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labeluniversity.Location = new System.Drawing.Point(246, 16);
            this.labeluniversity.Name = "labeluniversity";
            this.labeluniversity.Size = new System.Drawing.Size(332, 25);
            this.labeluniversity.TabIndex = 4;
            this.labeluniversity.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // txtbookid
            // 
            this.txtbookid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtbookid.FormattingEnabled = true;
            this.txtbookid.Location = new System.Drawing.Point(197, 125);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(121, 24);
            this.txtbookid.TabIndex = 58;
            this.txtbookid.SelectedIndexChanged += new System.EventHandler(this.txtbookid_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "BOOK ID";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(809, 304);
            this.Controls.Add(button4);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbookname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(button1);
            this.Controls.Add(this.txtbookid);
            this.Controls.Add(this.label2);
            this.Name = "User";
            this.Text = "Viewvook";
            this.Load += new System.EventHandler(this.Viewbook_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox txtcategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtbookname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeluniversity;
        private System.Windows.Forms.ComboBox txtbookid;
        private System.Windows.Forms.Label label2;
    }
}