
namespace Tyuiu.KomarovMI.Sprint7.Project.V7
{
    partial class FormRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRules));
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxRules_KMI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonOK.Image")));
            this.buttonOK.Location = new System.Drawing.Point(695, 368);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(60, 60);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxRules_KMI
            // 
            this.textBoxRules_KMI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxRules_KMI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxRules_KMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRules_KMI.Location = new System.Drawing.Point(12, 44);
            this.textBoxRules_KMI.Multiline = true;
            this.textBoxRules_KMI.Name = "textBoxRules_KMI";
            this.textBoxRules_KMI.Size = new System.Drawing.Size(784, 270);
            this.textBoxRules_KMI.TabIndex = 1;
            this.textBoxRules_KMI.Text = resources.GetString("textBoxRules_KMI.Text");
            // 
            // FormRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxRules_KMI);
            this.Controls.Add(this.buttonOK);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormRules";
            this.Text = "Руководство";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxRules_KMI;
    }
}