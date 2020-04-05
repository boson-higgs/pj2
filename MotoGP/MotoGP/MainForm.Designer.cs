namespace MotoGP
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
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListBox();
            this.export = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(245, 44);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(114, 44);
            this.add.TabIndex = 0;
            this.add.Text = "Přidat jezdce";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(245, 103);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(114, 41);
            this.delete.TabIndex = 1;
            this.delete.Text = "Odebrat jezdce";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(12, 44);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(179, 186);
            this.list.TabIndex = 2;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(245, 163);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(114, 42);
            this.export.TabIndex = 3;
            this.export.Text = "Export do XML";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(245, 225);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(114, 45);
            this.import.TabIndex = 4;
            this.import.Text = "Import XML";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 298);
            this.Controls.Add(this.import);
            this.Controls.Add(this.export);
            this.Controls.Add(this.list);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Name = "MainForm";
            this.Text = "MotoGP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button import;
    }
}

