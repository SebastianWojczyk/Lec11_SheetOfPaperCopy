
namespace SheetOfPaperCopy
{
    partial class UserControlSheetOfPaper
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
            this.pictureBoxSheet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSheet
            // 
            this.pictureBoxSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSheet.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSheet.Name = "pictureBoxSheet";
            this.pictureBoxSheet.Size = new System.Drawing.Size(299, 218);
            this.pictureBoxSheet.TabIndex = 0;
            this.pictureBoxSheet.TabStop = false;
            this.pictureBoxSheet.SizeChanged += new System.EventHandler(this.pictureBoxSheet_SizeChanged);
            this.pictureBoxSheet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSheet_MouseDown);
            this.pictureBoxSheet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSheet_MouseMove);
            // 
            // UserControlSheetOfPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxSheet);
            this.Name = "UserControlSheetOfPaper";
            this.Size = new System.Drawing.Size(299, 218);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSheet;
    }
}
