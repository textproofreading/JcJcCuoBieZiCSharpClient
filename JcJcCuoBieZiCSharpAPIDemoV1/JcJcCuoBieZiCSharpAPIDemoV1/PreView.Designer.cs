namespace JcJcCuoBieZiCSharpAPIDemoV1
{
    partial class PreViewCuoBieZi
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
            this.webBrowserPreView = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserPreView
            // 
            this.webBrowserPreView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserPreView.Location = new System.Drawing.Point(0, 0);
            this.webBrowserPreView.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPreView.Name = "webBrowserPreView";
            this.webBrowserPreView.Size = new System.Drawing.Size(1023, 713);
            this.webBrowserPreView.TabIndex = 0;
            // 
            // PreViewCuoBieZi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 713);
            this.Controls.Add(this.webBrowserPreView);
            this.Name = "PreViewCuoBieZi";
            this.Text = "错别字察看窗口";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser webBrowserPreView;
    }
}