
namespace SheetOfPaperCopy
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.paper2 = new SheetOfPaperCopy.UserControlSheetOfPaper();
            this.paper1 = new SheetOfPaperCopy.UserControlSheetOfPaper();
            this.paper3 = new SheetOfPaperCopy.UserControlSheetOfPaper();
            this.paper4 = new SheetOfPaperCopy.UserControlSheetOfPaper();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(317, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(374, 364);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // paper2
            // 
            this.paper2.Location = new System.Drawing.Point(12, 197);
            this.paper2.Name = "paper2";
            this.paper2.Size = new System.Drawing.Size(299, 179);
            this.paper2.TabIndex = 2;
            this.paper2.drawLine += new SheetOfPaperCopy.UserControlSheetOfPaper.delegateLine(this.userControlSheetOfPaper_drawLine);
            // 
            // paper
            // 
            this.paper1.Location = new System.Drawing.Point(12, 12);
            this.paper1.Name = "paper";
            this.paper1.Size = new System.Drawing.Size(299, 179);
            this.paper1.TabIndex = 0;
            this.paper1.drawLine += new SheetOfPaperCopy.UserControlSheetOfPaper.delegateLine(this.userControlSheetOfPaper_drawLine);
            // 
            // userControlSheetOfPaper1
            // 
            this.paper3.Location = new System.Drawing.Point(697, 12);
            this.paper3.Name = "userControlSheetOfPaper1";
            this.paper3.Size = new System.Drawing.Size(299, 179);
            this.paper3.TabIndex = 3;
            this.paper3.drawLine += new SheetOfPaperCopy.UserControlSheetOfPaper.delegateLine(this.userControlSheetOfPaper_drawLine);
            // 
            // userControlSheetOfPaper2
            // 
            this.paper4.Location = new System.Drawing.Point(697, 197);
            this.paper4.Name = "userControlSheetOfPaper2";
            this.paper4.Size = new System.Drawing.Size(299, 179);
            this.paper4.TabIndex = 4;
            this.paper4.drawLine += new SheetOfPaperCopy.UserControlSheetOfPaper.delegateLine(this.userControlSheetOfPaper_drawLine);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 388);
            this.Controls.Add(this.paper4);
            this.Controls.Add(this.paper3);
            this.Controls.Add(this.paper2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.paper1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlSheetOfPaper paper1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private UserControlSheetOfPaper paper2;
        private UserControlSheetOfPaper paper3;
        private UserControlSheetOfPaper paper4;
    }
}

