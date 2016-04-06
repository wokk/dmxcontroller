namespace VirtueleDMXcontroller_groep
{
    partial class UC_toestel
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
            this.lbToestellen = new System.Windows.Forms.ListBox();
            this.btnToestelAanmaken = new System.Windows.Forms.Button();
            this.btnToestelVerwijderen = new System.Windows.Forms.Button();
            this.btnAanSceneToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toestellen";
            // 
            // lbToestellen
            // 
            this.lbToestellen.FormattingEnabled = true;
            this.lbToestellen.ItemHeight = 16;
            this.lbToestellen.Location = new System.Drawing.Point(6, 20);
            this.lbToestellen.Name = "lbToestellen";
            this.lbToestellen.Size = new System.Drawing.Size(250, 292);
            this.lbToestellen.TabIndex = 1;
            // 
            // btnToestelAanmaken
            // 
            this.btnToestelAanmaken.Location = new System.Drawing.Point(6, 318);
            this.btnToestelAanmaken.Name = "btnToestelAanmaken";
            this.btnToestelAanmaken.Size = new System.Drawing.Size(125, 45);
            this.btnToestelAanmaken.TabIndex = 2;
            this.btnToestelAanmaken.Text = "Toestel Aanmaken";
            this.btnToestelAanmaken.UseVisualStyleBackColor = true;
            // 
            // btnToestelVerwijderen
            // 
            this.btnToestelVerwijderen.Location = new System.Drawing.Point(131, 318);
            this.btnToestelVerwijderen.Name = "btnToestelVerwijderen";
            this.btnToestelVerwijderen.Size = new System.Drawing.Size(125, 45);
            this.btnToestelVerwijderen.TabIndex = 2;
            this.btnToestelVerwijderen.Text = "Toestel Verwijderen";
            this.btnToestelVerwijderen.UseVisualStyleBackColor = true;
            // 
            // btnAanSceneToevoegen
            // 
            this.btnAanSceneToevoegen.Location = new System.Drawing.Point(6, 369);
            this.btnAanSceneToevoegen.Name = "btnAanSceneToevoegen";
            this.btnAanSceneToevoegen.Size = new System.Drawing.Size(250, 38);
            this.btnAanSceneToevoegen.TabIndex = 3;
            this.btnAanSceneToevoegen.Text = "Aan Scene Toevoegen";
            this.btnAanSceneToevoegen.UseVisualStyleBackColor = true;
            // 
            // UC_toestel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAanSceneToevoegen);
            this.Controls.Add(this.btnToestelVerwijderen);
            this.Controls.Add(this.btnToestelAanmaken);
            this.Controls.Add(this.lbToestellen);
            this.Controls.Add(this.label1);
            this.Name = "UC_toestel";
            this.Size = new System.Drawing.Size(263, 410);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbToestellen;
        private System.Windows.Forms.Button btnToestelAanmaken;
        private System.Windows.Forms.Button btnToestelVerwijderen;
        private System.Windows.Forms.Button btnAanSceneToevoegen;
    }
}
