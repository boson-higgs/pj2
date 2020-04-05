namespace MotoGP
{
    partial class DetailJezdceEditaceForm
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
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.team = new System.Windows.Forms.TextBox();
            this.isfactory = new System.Windows.Forms.CheckBox();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(116, 51);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 0;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(116, 80);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(100, 20);
            this.surname.TabIndex = 1;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(116, 118);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 20);
            this.number.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Příjmení";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Závodní číslo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tým";
            // 
            // team
            // 
            this.team.Location = new System.Drawing.Point(116, 166);
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(100, 20);
            this.team.TabIndex = 7;
            // 
            // isfactory
            // 
            this.isfactory.AutoSize = true;
            this.isfactory.Location = new System.Drawing.Point(222, 169);
            this.isfactory.Name = "isfactory";
            this.isfactory.Size = new System.Drawing.Size(83, 17);
            this.isfactory.TabIndex = 8;
            this.isfactory.Text = "Tovární tým";
            this.isfactory.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(126, 229);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 9;
            this.save.Text = "Uložit";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // DetailJezdceEditaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 268);
            this.Controls.Add(this.save);
            this.Controls.Add(this.isfactory);
            this.Controls.Add(this.team);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Name = "DetailJezdceEditaceForm";
            this.Text = "Detail jezdce";
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox team;
        private System.Windows.Forms.CheckBox isfactory;
        private System.Windows.Forms.Button save;
    }
}