namespace JcJcCuoBieZiCSharpAPIDemoV1
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerBody = new System.Windows.Forms.SplitContainer();
            this.webBrowserMain = new System.Windows.Forms.WebBrowser();
            this.buttonBeginCheck = new System.Windows.Forms.Button();
            this.buttonOpenPanelMain1 = new System.Windows.Forms.Button();
            this.buttonGoToHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBody)).BeginInit();
            this.splitContainerBody.Panel1.SuspendLayout();
            this.splitContainerBody.Panel2.SuspendLayout();
            this.splitContainerBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Location = new System.Drawing.Point(0, 651);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(909, 22);
            this.statusStripMain.TabIndex = 0;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerBody);
            this.splitContainerMain.Size = new System.Drawing.Size(909, 651);
            this.splitContainerMain.SplitterDistance = 62;
            this.splitContainerMain.TabIndex = 1;
            // 
            // splitContainerBody
            // 
            this.splitContainerBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBody.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBody.Name = "splitContainerBody";
            // 
            // splitContainerBody.Panel1
            // 
            this.splitContainerBody.Panel1.Controls.Add(this.webBrowserMain);
            // 
            // splitContainerBody.Panel2
            // 
            this.splitContainerBody.Panel2.Controls.Add(this.buttonBeginCheck);
            this.splitContainerBody.Panel2.Controls.Add(this.buttonOpenPanelMain1);
            this.splitContainerBody.Panel2.Controls.Add(this.buttonGoToHome);
            this.splitContainerBody.Size = new System.Drawing.Size(909, 585);
            this.splitContainerBody.SplitterDistance = 792;
            this.splitContainerBody.TabIndex = 0;
            // 
            // webBrowserMain
            // 
            this.webBrowserMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMain.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMain.Name = "webBrowserMain";
            this.webBrowserMain.Size = new System.Drawing.Size(792, 585);
            this.webBrowserMain.TabIndex = 0;
            this.webBrowserMain.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserMain_DocumentCompleted);
            // 
            // buttonBeginCheck
            // 
            this.buttonBeginCheck.Location = new System.Drawing.Point(5, 92);
            this.buttonBeginCheck.Name = "buttonBeginCheck";
            this.buttonBeginCheck.Size = new System.Drawing.Size(104, 26);
            this.buttonBeginCheck.TabIndex = 2;
            this.buttonBeginCheck.Text = "开始检查";
            this.buttonBeginCheck.UseVisualStyleBackColor = true;
            this.buttonBeginCheck.Click += new System.EventHandler(this.buttonBeginCheck_Click);
            // 
            // buttonOpenPanelMain1
            // 
            this.buttonOpenPanelMain1.Location = new System.Drawing.Point(5, 61);
            this.buttonOpenPanelMain1.Name = "buttonOpenPanelMain1";
            this.buttonOpenPanelMain1.Size = new System.Drawing.Size(104, 26);
            this.buttonOpenPanelMain1.TabIndex = 1;
            this.buttonOpenPanelMain1.Text = "展开菜单";
            this.buttonOpenPanelMain1.UseVisualStyleBackColor = true;
            this.buttonOpenPanelMain1.Click += new System.EventHandler(this.buttonOpenPanelMain1_Click);
            // 
            // buttonGoToHome
            // 
            this.buttonGoToHome.Location = new System.Drawing.Point(5, 29);
            this.buttonGoToHome.Name = "buttonGoToHome";
            this.buttonGoToHome.Size = new System.Drawing.Size(104, 26);
            this.buttonGoToHome.TabIndex = 0;
            this.buttonGoToHome.Text = "错别字网首页";
            this.buttonGoToHome.UseVisualStyleBackColor = true;
            this.buttonGoToHome.Click += new System.EventHandler(this.buttonGoToHome_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 673);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusStripMain);
            this.Name = "FormMain";
            this.Text = "CuoBieZi.net JcJc错别字";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerBody.Panel1.ResumeLayout(false);
            this.splitContainerBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBody)).EndInit();
            this.splitContainerBody.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerBody;
        private System.Windows.Forms.WebBrowser webBrowserMain;
        private System.Windows.Forms.Button buttonGoToHome;
        private System.Windows.Forms.Button buttonOpenPanelMain1;
        private System.Windows.Forms.Button buttonBeginCheck;
    }
}

