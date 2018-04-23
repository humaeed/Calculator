namespace Calculator
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.HFileBox = new System.Windows.Forms.RichTextBox();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HFileBox
            // 
            this.HFileBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HFileBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.HFileBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HFileBox.Location = new System.Drawing.Point(5, 5);
            this.HFileBox.Name = "HFileBox";
            this.HFileBox.ReadOnly = true;
            this.HFileBox.Size = new System.Drawing.Size(321, 357);
            this.HFileBox.TabIndex = 0;
            this.HFileBox.Text = "There is no history yet";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.Control;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Location = new System.Drawing.Point(286, -1);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(40, 37);
            this.delete.TabIndex = 34;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.DeleteHistory);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 361);
            this.ControlBox = false;
            this.Controls.Add(this.delete);
            this.Controls.Add(this.HFileBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryForm";
            this.Text = "History";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox HFileBox;
        private System.Windows.Forms.Button delete;
    }
}