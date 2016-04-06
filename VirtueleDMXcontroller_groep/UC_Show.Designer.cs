namespace VirtueleDMXcontroller_groep
{
    partial class UC_Show
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnShowAanmaken = new System.Windows.Forms.Button();
            this.btnShowAanpassen = new System.Windows.Forms.Button();
            this.btnShowVerwijderen = new System.Windows.Forms.Button();
            this.btnShowAfspelen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shows";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 292);
            this.listBox1.TabIndex = 1;
            // 
            // btnShowAanmaken
            // 
            this.btnShowAanmaken.Location = new System.Drawing.Point(6, 318);
            this.btnShowAanmaken.Name = "btnShowAanmaken";
            this.btnShowAanmaken.Size = new System.Drawing.Size(120, 45);
            this.btnShowAanmaken.TabIndex = 2;
            this.btnShowAanmaken.Text = "Show Aanmaken";
            this.btnShowAanmaken.UseVisualStyleBackColor = true;
            // 
            // btnShowAanpassen
            // 
            this.btnShowAanpassen.Location = new System.Drawing.Point(136, 318);
            this.btnShowAanpassen.Name = "btnShowAanpassen";
            this.btnShowAanpassen.Size = new System.Drawing.Size(120, 45);
            this.btnShowAanpassen.TabIndex = 2;
            this.btnShowAanpassen.Text = "Show Aanpassen";
            this.btnShowAanpassen.UseVisualStyleBackColor = true;
            // 
            // btnShowVerwijderen
            // 
            this.btnShowVerwijderen.Location = new System.Drawing.Point(6, 369);
            this.btnShowVerwijderen.Name = "btnShowVerwijderen";
            this.btnShowVerwijderen.Size = new System.Drawing.Size(120, 45);
            this.btnShowVerwijderen.TabIndex = 2;
            this.btnShowVerwijderen.Text = "Show Verwijderen";
            this.btnShowVerwijderen.UseVisualStyleBackColor = true;
            // 
            // btnShowAfspelen
            // 
            this.btnShowAfspelen.Location = new System.Drawing.Point(136, 369);
            this.btnShowAfspelen.Name = "btnShowAfspelen";
            this.btnShowAfspelen.Size = new System.Drawing.Size(120, 45);
            this.btnShowAfspelen.TabIndex = 2;
            this.btnShowAfspelen.Text = "Show Afspelen";
            this.btnShowAfspelen.UseVisualStyleBackColor = true;
            // 
            // UC_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowAfspelen);
            this.Controls.Add(this.btnShowVerwijderen);
            this.Controls.Add(this.btnShowAanpassen);
            this.Controls.Add(this.btnShowAanmaken);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_Show";
            this.Size = new System.Drawing.Size(262, 425);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnShowAanmaken;
        private System.Windows.Forms.Button btnShowAanpassen;
        private System.Windows.Forms.Button btnShowVerwijderen;
        private System.Windows.Forms.Button btnShowAfspelen;
    }
}
