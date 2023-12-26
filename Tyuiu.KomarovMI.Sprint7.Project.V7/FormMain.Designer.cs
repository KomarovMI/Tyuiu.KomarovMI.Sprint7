
namespace Tyuiu.KomarovMI.Sprint7.Project.V7
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonRules_KMI = new System.Windows.Forms.Button();
            this.labelName_KMI = new System.Windows.Forms.Label();
            this.pictureBox_KMI = new System.Windows.Forms.PictureBox();
            this.buttonAboutme_KMI = new System.Windows.Forms.Button();
            this.buttonOpen_KMI = new System.Windows.Forms.Button();
            this.openFileDialog_KMI = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_KMI = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_KMI)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRules_KMI
            // 
            this.buttonRules_KMI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRules_KMI.BackColor = System.Drawing.Color.White;
            this.buttonRules_KMI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRules_KMI.BackgroundImage")));
            this.buttonRules_KMI.ForeColor = System.Drawing.Color.Black;
            this.buttonRules_KMI.Location = new System.Drawing.Point(105, 437);
            this.buttonRules_KMI.Name = "buttonRules_KMI";
            this.buttonRules_KMI.Size = new System.Drawing.Size(60, 60);
            this.buttonRules_KMI.TabIndex = 0;
            this.buttonRules_KMI.Text = "\r\n";
            this.toolTip_KMI.SetToolTip(this.buttonRules_KMI, "Рукаводство пользования");
            this.buttonRules_KMI.UseVisualStyleBackColor = false;
            this.buttonRules_KMI.Click += new System.EventHandler(this.buttonRules_KMI_Click);
            // 
            // labelName_KMI
            // 
            this.labelName_KMI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelName_KMI.AutoSize = true;
            this.labelName_KMI.BackColor = System.Drawing.Color.White;
            this.labelName_KMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName_KMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelName_KMI.Location = new System.Drawing.Point(189, 29);
            this.labelName_KMI.Name = "labelName_KMI";
            this.labelName_KMI.Size = new System.Drawing.Size(165, 24);
            this.labelName_KMI.TabIndex = 1;
            this.labelName_KMI.Text = "Домоуправление";
            this.labelName_KMI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox_KMI
            // 
            this.pictureBox_KMI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox_KMI.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_KMI.Image")));
            this.pictureBox_KMI.Location = new System.Drawing.Point(105, 81);
            this.pictureBox_KMI.Name = "pictureBox_KMI";
            this.pictureBox_KMI.Size = new System.Drawing.Size(333, 294);
            this.pictureBox_KMI.TabIndex = 2;
            this.pictureBox_KMI.TabStop = false;
            // 
            // buttonAboutme_KMI
            // 
            this.buttonAboutme_KMI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAboutme_KMI.BackColor = System.Drawing.Color.White;
            this.buttonAboutme_KMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAboutme_KMI.ForeColor = System.Drawing.Color.Aqua;
            this.buttonAboutme_KMI.Location = new System.Drawing.Point(23, 437);
            this.buttonAboutme_KMI.Name = "buttonAboutme_KMI";
            this.buttonAboutme_KMI.Size = new System.Drawing.Size(60, 60);
            this.buttonAboutme_KMI.TabIndex = 3;
            this.buttonAboutme_KMI.Text = "?";
            this.toolTip_KMI.SetToolTip(this.buttonAboutme_KMI, "О программе");
            this.buttonAboutme_KMI.UseVisualStyleBackColor = false;
            this.buttonAboutme_KMI.Click += new System.EventHandler(this.buttonAboutme_KMI_Click);
            // 
            // buttonOpen_KMI
            // 
            this.buttonOpen_KMI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen_KMI.BackColor = System.Drawing.Color.Turquoise;
            this.buttonOpen_KMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen_KMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonOpen_KMI.Location = new System.Drawing.Point(193, 437);
            this.buttonOpen_KMI.Name = "buttonOpen_KMI";
            this.buttonOpen_KMI.Size = new System.Drawing.Size(346, 60);
            this.buttonOpen_KMI.TabIndex = 4;
            this.buttonOpen_KMI.Text = "Открыть";
            this.buttonOpen_KMI.UseVisualStyleBackColor = false;
            this.buttonOpen_KMI.Click += new System.EventHandler(this.buttonChooseFile_KMI_Click);
            // 
            // openFileDialog_KMI
            // 
            this.openFileDialog_KMI.FileName = "openFileDialog_KMI";
            // 
            // toolTip_KMI
            // 
            this.toolTip_KMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolTip_KMI.IsBalloon = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 514);
            this.Controls.Add(this.buttonOpen_KMI);
            this.Controls.Add(this.buttonAboutme_KMI);
            this.Controls.Add(this.pictureBox_KMI);
            this.Controls.Add(this.labelName_KMI);
            this.Controls.Add(this.buttonRules_KMI);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(567, 553);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_KMI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRules_KMI;
        private System.Windows.Forms.Label labelName_KMI;
        private System.Windows.Forms.PictureBox pictureBox_KMI;
        private System.Windows.Forms.Button buttonAboutme_KMI;
        private System.Windows.Forms.Button buttonOpen_KMI;
        private System.Windows.Forms.OpenFileDialog openFileDialog_KMI;
        private System.Windows.Forms.ToolTip toolTip_KMI;
    }
}

