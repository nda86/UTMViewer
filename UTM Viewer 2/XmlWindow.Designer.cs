namespace UTM_Viewer_2
{
    partial class XmlWindow
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
            this.txtXmlWindow = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtXmlWindow
            // 
            this.txtXmlWindow.Location = new System.Drawing.Point(0, 0);
            this.txtXmlWindow.Name = "txtXmlWindow";
            this.txtXmlWindow.Size = new System.Drawing.Size(529, 447);
            this.txtXmlWindow.TabIndex = 0;
            this.txtXmlWindow.Text = "";
            this.txtXmlWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtXmlWindow_MouseUp);
            // 
            // XmlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.txtXmlWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "XmlWindow";
            this.Text = "XmlWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtXmlWindow;
    }
}