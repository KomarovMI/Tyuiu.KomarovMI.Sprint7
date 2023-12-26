
namespace Tyuiu.KomarovMI.Sprint7.Project.V7
{
    partial class FormAboutme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutme));
            this.pictureBoxMyFace = new System.Windows.Forms.PictureBox();
            this.labelNameAboutMe_KMI = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyFace)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMyFace
            // 
            this.pictureBoxMyFace.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMyFace.Image")));
            this.pictureBoxMyFace.Location = new System.Drawing.Point(12, 23);
            this.pictureBoxMyFace.Name = "pictureBoxMyFace";
            this.pictureBoxMyFace.Size = new System.Drawing.Size(192, 233);
            this.pictureBoxMyFace.TabIndex = 0;
            this.pictureBoxMyFace.TabStop = false;
            // 
            // labelNameAboutMe_KMI
            // 
            this.labelNameAboutMe_KMI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelNameAboutMe_KMI.AutoSize = true;
            this.labelNameAboutMe_KMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameAboutMe_KMI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelNameAboutMe_KMI.Location = new System.Drawing.Point(221, 38);
            this.labelNameAboutMe_KMI.Name = "labelNameAboutMe_KMI";
            this.labelNameAboutMe_KMI.Size = new System.Drawing.Size(392, 160);
            this.labelNameAboutMe_KMI.TabIndex = 1;
            this.labelNameAboutMe_KMI.Text = "Разработчик: Комаров М.И.\r\nГруппа ПКТб-23-1\r\n\r\nПрограмма разработа в рамках изуче" +
    "ния C#\r\n\r\nТюменский Индустриальный Университет (с) 2023\r\n\r\nВШЦТ (с) 2023\r\n";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.BackColor = System.Drawing.Color.White;
            this.buttonOK.Image = ((System.Drawing.Image)(resources.GetObject("buttonOK.Image")));
            this.buttonOK.Location = new System.Drawing.Point(537, 209);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(60, 58);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormAboutme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 279);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelNameAboutMe_KMI);
            this.Controls.Add(this.pictureBoxMyFace);
            this.MinimumSize = new System.Drawing.Size(641, 318);
            this.Name = "FormAboutme";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMyFace;
        private System.Windows.Forms.Label labelNameAboutMe_KMI;
        private System.Windows.Forms.Button buttonOK;
    }
}