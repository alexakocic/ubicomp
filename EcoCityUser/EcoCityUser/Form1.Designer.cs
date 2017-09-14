namespace EcoCityUser
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.labCategory = new System.Windows.Forms.Label();
            this.labDateTime = new System.Windows.Forms.Label();
            this.labLatLong = new System.Windows.Forms.Label();
            this.labDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnCreateUserInput);
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(108, 141);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(182, 21);
            this.cmb_category.TabIndex = 2;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(108, 51);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(182, 70);
            this.txt_description.TabIndex = 3;
            this.txt_description.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Location = new System.Drawing.Point(482, 47);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(78, 17);
            this.labTitle.TabIndex = 6;
            this.labTitle.Text = "Data sent";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(390, 108);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(52, 13);
            this.lab1.TabIndex = 7;
            this.lab1.Text = "Category:";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(383, 142);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(59, 13);
            this.lab2.TabIndex = 8;
            this.lab2.Text = "Date Time:";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(388, 178);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(54, 13);
            this.lab3.TabIndex = 9;
            this.lab3.Text = "Lat/Long:";
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Location = new System.Drawing.Point(379, 215);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(63, 13);
            this.lab4.TabIndex = 10;
            this.lab4.Text = "Description:";
            // 
            // labCategory
            // 
            this.labCategory.AutoSize = true;
            this.labCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCategory.Location = new System.Drawing.Point(475, 103);
            this.labCategory.Name = "labCategory";
            this.labCategory.Size = new System.Drawing.Size(0, 20);
            this.labCategory.TabIndex = 11;
            // 
            // labDateTime
            // 
            this.labDateTime.AutoSize = true;
            this.labDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDateTime.Location = new System.Drawing.Point(475, 137);
            this.labDateTime.Name = "labDateTime";
            this.labDateTime.Size = new System.Drawing.Size(0, 20);
            this.labDateTime.TabIndex = 12;
            // 
            // labLatLong
            // 
            this.labLatLong.AutoSize = true;
            this.labLatLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLatLong.Location = new System.Drawing.Point(475, 173);
            this.labLatLong.Name = "labLatLong";
            this.labLatLong.Size = new System.Drawing.Size(0, 20);
            this.labLatLong.TabIndex = 13;
            // 
            // labDesc
            // 
            this.labDesc.AutoSize = true;
            this.labDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDesc.Location = new System.Drawing.Point(475, 210);
            this.labDesc.Name = "labDesc";
            this.labDesc.Size = new System.Drawing.Size(0, 20);
            this.labDesc.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 339);
            this.Controls.Add(this.labDesc);
            this.Controls.Add(this.labLatLong);
            this.Controls.Add(this.labDateTime);
            this.Controls.Add(this.labCategory);
            this.Controls.Add(this.lab4);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Create input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label labCategory;
        private System.Windows.Forms.Label labDateTime;
        private System.Windows.Forms.Label labLatLong;
        private System.Windows.Forms.Label labDesc;
    }
}

