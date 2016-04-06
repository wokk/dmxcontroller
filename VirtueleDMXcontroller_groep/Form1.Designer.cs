namespace VirtueleDMXcontroller_groep
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
            this.uC_toestel1 = new VirtueleDMXcontroller_groep.UC_toestel();
            this.uC_Scene1 = new VirtueleDMXcontroller_groep.UC_Scene();
            this.uC_Show1 = new VirtueleDMXcontroller_groep.UC_Show();
            this.SuspendLayout();
            // 
            // uC_toestel1
            // 
            this.uC_toestel1.Location = new System.Drawing.Point(12, 12);
            this.uC_toestel1.Name = "uC_toestel1";
            this.uC_toestel1.Size = new System.Drawing.Size(263, 410);
            this.uC_toestel1.TabIndex = 0;
            // 
            // uC_Scene1
            // 
            this.uC_Scene1.Location = new System.Drawing.Point(281, 12);
            this.uC_Scene1.Name = "uC_Scene1";
            this.uC_Scene1.Size = new System.Drawing.Size(550, 458);
            this.uC_Scene1.TabIndex = 1;
            // 
            // uC_Show1
            // 
            this.uC_Show1.Location = new System.Drawing.Point(837, 12);
            this.uC_Show1.Name = "uC_Show1";
            this.uC_Show1.Size = new System.Drawing.Size(262, 425);
            this.uC_Show1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 477);
            this.Controls.Add(this.uC_Show1);
            this.Controls.Add(this.uC_Scene1);
            this.Controls.Add(this.uC_toestel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_toestel uC_toestel1;
        private UC_Scene uC_Scene1;
        private UC_Show uC_Show1;
    }
}

