namespace Tutorial5
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.stackRemoveBtn = new System.Windows.Forms.Button();
            this.stackListBox = new System.Windows.Forms.ListBox();
            this.stackAddBtn = new System.Windows.Forms.Button();
            this.stackNumberInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.queueRemoveBtn = new System.Windows.Forms.Button();
            this.queueListBox = new System.Windows.Forms.ListBox();
            this.queueAddBtn = new System.Windows.Forms.Button();
            this.queueNumberInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stackRemoveBtn);
            this.panel1.Controls.Add(this.stackListBox);
            this.panel1.Controls.Add(this.stackAddBtn);
            this.panel1.Controls.Add(this.stackNumberInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 426);
            this.panel1.TabIndex = 0;
            // 
            // stackRemoveBtn
            // 
            this.stackRemoveBtn.Location = new System.Drawing.Point(15, 388);
            this.stackRemoveBtn.Name = "stackRemoveBtn";
            this.stackRemoveBtn.Size = new System.Drawing.Size(359, 23);
            this.stackRemoveBtn.TabIndex = 4;
            this.stackRemoveBtn.Text = "odebrat";
            this.stackRemoveBtn.UseVisualStyleBackColor = true;
            this.stackRemoveBtn.Click += new System.EventHandler(this.stackRemoveBtn_Click);
            // 
            // stackListBox
            // 
            this.stackListBox.FormattingEnabled = true;
            this.stackListBox.Location = new System.Drawing.Point(15, 37);
            this.stackListBox.Name = "stackListBox";
            this.stackListBox.Size = new System.Drawing.Size(359, 342);
            this.stackListBox.TabIndex = 3;
            // 
            // stackAddBtn
            // 
            this.stackAddBtn.Location = new System.Drawing.Point(299, 9);
            this.stackAddBtn.Name = "stackAddBtn";
            this.stackAddBtn.Size = new System.Drawing.Size(75, 23);
            this.stackAddBtn.TabIndex = 2;
            this.stackAddBtn.Text = "přidat";
            this.stackAddBtn.UseVisualStyleBackColor = true;
            this.stackAddBtn.Click += new System.EventHandler(this.stackAddBtn_Click);
            // 
            // stackNumberInput
            // 
            this.stackNumberInput.Location = new System.Drawing.Point(87, 11);
            this.stackNumberInput.Name = "stackNumberInput";
            this.stackNumberInput.Size = new System.Drawing.Size(206, 20);
            this.stackNumberInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadejte číslo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.queueRemoveBtn);
            this.panel2.Controls.Add(this.queueListBox);
            this.panel2.Controls.Add(this.queueAddBtn);
            this.panel2.Controls.Add(this.queueNumberInput);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(405, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 426);
            this.panel2.TabIndex = 1;
            // 
            // queueRemoveBtn
            // 
            this.queueRemoveBtn.Location = new System.Drawing.Point(16, 388);
            this.queueRemoveBtn.Name = "queueRemoveBtn";
            this.queueRemoveBtn.Size = new System.Drawing.Size(353, 23);
            this.queueRemoveBtn.TabIndex = 4;
            this.queueRemoveBtn.Text = "odebrat";
            this.queueRemoveBtn.UseVisualStyleBackColor = true;
            this.queueRemoveBtn.Click += new System.EventHandler(this.queueRemoveBtn_Click);
            // 
            // queueListBox
            // 
            this.queueListBox.FormattingEnabled = true;
            this.queueListBox.Location = new System.Drawing.Point(16, 37);
            this.queueListBox.Name = "queueListBox";
            this.queueListBox.Size = new System.Drawing.Size(353, 342);
            this.queueListBox.TabIndex = 3;
            // 
            // queueAddBtn
            // 
            this.queueAddBtn.Location = new System.Drawing.Point(294, 9);
            this.queueAddBtn.Name = "queueAddBtn";
            this.queueAddBtn.Size = new System.Drawing.Size(75, 23);
            this.queueAddBtn.TabIndex = 2;
            this.queueAddBtn.Text = "přidat";
            this.queueAddBtn.UseVisualStyleBackColor = true;
            this.queueAddBtn.Click += new System.EventHandler(this.queueAddBtn_Click);
            // 
            // queueNumberInput
            // 
            this.queueNumberInput.Location = new System.Drawing.Point(88, 11);
            this.queueNumberInput.Name = "queueNumberInput";
            this.queueNumberInput.Size = new System.Drawing.Size(200, 20);
            this.queueNumberInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Zadejte číslo";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Zásobník a fronta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stackRemoveBtn;
        private System.Windows.Forms.ListBox stackListBox;
        private System.Windows.Forms.Button stackAddBtn;
        private System.Windows.Forms.TextBox stackNumberInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button queueRemoveBtn;
        private System.Windows.Forms.ListBox queueListBox;
        private System.Windows.Forms.Button queueAddBtn;
        private System.Windows.Forms.TextBox queueNumberInput;
        private System.Windows.Forms.Label label2;
    }
}

