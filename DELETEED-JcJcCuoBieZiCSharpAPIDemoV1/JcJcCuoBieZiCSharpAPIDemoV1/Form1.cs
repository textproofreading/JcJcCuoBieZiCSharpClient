using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text;  // for class Encoding
using System.IO;
using System.Diagnostics;
using mshtml;



/**
 * 
 * git@code.csdn.net:proofreading/jcjc_cuobiezi_net.git
 * https://github.com/textproofreading/JcJcCuoBieZiCSharpClient.git
 * 
 * https://github.com/textproofreading/JcJcCuoBieZiCSharpClient
 * */
namespace JcJcCuoBieZiCSharpAPIDemoV1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //MessageBox.Show("a");
        }

        private void buttonGoToHome_Click(object sender, EventArgs e)
        {
            gotoHomePage();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {

            
            this.webBrowserMain.Navigate("about:blank");
            //this.webBrowserMain.Document.OpenNew(False).Write("<html><body><div id=""editable"">Edit this text</div></body></html>");
            //this.webBrowserMain.Document.OpenNew(false).Write("");

            webBrowserMain.Navigate("about:blank");
            Application.DoEvents();


                string readme = "<br /><br /><br /><br /><br /><br /><br />本程序是JcJc错别字识别的大众版，如果程序不能正常工作，请咨询QQ：914946414 。 <br />";

                //readme += "<a target=\"_blank\" href=\"http://wpa.qq.com/msgrd?v=3&uin=914946414&site=qq&menu=yes\"><img border=\"0\" src=\"http://wpa.qq.com/pa?p=2:914946414:53\" alt=\"JcJc 错别字检查\" title=\"JcJc 错别字检查\"/></a>";
                webBrowserMain.Document.OpenNew(false).Write("<html><body contentEditable='true'><div id=\"editable\">开始编辑"+readme+"</div></body></html>");


            foreach (HtmlElement el in webBrowserMain.Document.All)
            {
                el.SetAttribute("unselectable", "on");
                el.SetAttribute("contenteditable", "false");
            }

            webBrowserMain.Document.Body.SetAttribute("width", this.Width.ToString() + "px");
            webBrowserMain.Document.Body.SetAttribute("height", "100%");
            webBrowserMain.Document.Body.SetAttribute("contenteditable", "true");

                var doc = webBrowserMain.Document.DomDocument as mshtml.IHTMLDocument2;
                if (doc != null && doc.body != null)
                {
                    ((mshtml.HTMLBody)doc.body).contentEditable = "true";
                }


                {
                    var htmlDoc = webBrowserMain.Document.DomDocument as IHTMLDocument2;
                    htmlDoc.body.setAttribute("contenteditable", "true");
                    htmlDoc.designMode = "On";

                }

                /*
                {
                    WebBrowser browser = webBrowserMain as WebBrowser;
                    if (browser != null)
                    {
                        Boolean designMode = (Boolean)args.NewValue;
                        if (designMode)
                        {
                            browser.LoadCompleted += (s, e) =>
                            {
                                var htmlDoc = (s as WebBrowser).Document as IHTMLDocument2;
                                htmlDoc.body.setAttribute("contenteditable", "true");
                                htmlDoc.designMode = "On";
                            };
                        }
                        else
                        {
                            browser.LoadCompleted += (s, e) =>
                            {
                                var htmlDoc = (s as WebBrowser).Document as IHTMLDocument2;
                                htmlDoc.body.setAttribute("contenteditable", "false");
                                htmlDoc.designMode = "Off";
                            };
                        }
                    }
                }
                */
                //webBrowserMain.Document.DomDocument.GetType().GetProperty("designMode").SetValue(webBrowserMain.Document.DomDocument, "On", null);

                //Type type = webBrowserMain.Document.DomDocument.GetType();

                //System.Reflection.PropertyInfo pi = type.GetProperties("designMode");
                //System.Reflection.PropertyInfo pi = type.GetProperties(System.ComponentModel.Design.Designm);
                //if (null != pi)
                {
                  //  MessageBox.Show("set on");
                  //  pi.SetValue(webBrowserMain.Document.DomDocument, "On", null);
                }
                webBrowserMain.Document.ExecCommand("EditMode", true, null);






                webBrowserMain.IsWebBrowserContextMenuEnabled = false;

            //gotoHomePage();
            //this.splitContainerMain.Panel1.Height = 100;
            //this.splitContainerMain.SplitPanels["Panel1"].SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Absolute;
            //this.splitContainerMain.SplitPanels["Panel1"].SizeInfo.AbsoluteSize = new Size(150, 0);

            //this.splitContainerMain.Panel1.
            //this.splitContainerMain.splitte
            this.splitContainerMain.Panel1MinSize = 10;
            this.splitContainerMain.Panel1Collapsed = true;


            }
            catch (Exception ex)
            {
                
                // Get stack trace for the exception with source file information
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                MessageBox.Show(frame.ToString());
                MessageBox.Show(ex.Source);
                MessageBox.Show( Convert.ToString(line)  );
            }
        }
        public int GetLineNumber(Exception ex)
        {
            var lineNumber = 0;
            const string lineSearch = ":line ";
            var index = ex.StackTrace.LastIndexOf(lineSearch);
            if (index != -1)
            {
                var lineNumberText = ex.StackTrace.Substring(index + lineSearch.Length);
                if (int.TryParse(lineNumberText, out lineNumber))
                {
                }
            }
            return lineNumber;
        }


        private void gotoHomePage()
        {
            this.webBrowserMain.Navigate("http://www.CuoBieZi.net");
        }

        private void buttonOpenPanelMain1_Click(object sender, EventArgs e)
        {
            if (this.splitContainerMain.Panel1Collapsed)
            {
                this.splitContainerMain.Panel1Collapsed = false;
            }
            else
            {
                this.splitContainerMain.Panel1Collapsed = true;
            }
            
        }

        private void buttonBeginCheck_Click(object sender, EventArgs e)
        {
            string Content =  "";
            {

                StreamReader sr = new StreamReader(this.webBrowserMain.DocumentStream, Encoding.GetEncoding("UTF-8"));
                string source = sr.ReadToEnd();

                //string htmlContent = this.webBrowserMain.DocumentText;
                string htmlContent = source;// this.webBrowserMain.DocumentText;
                Content = htmlContent;


                int htmlBeginPos = Content.IndexOf("<HTML>");
                if (htmlBeginPos > 0)
                {
                    Content = Content.Substring(htmlBeginPos, Content.Length-htmlBeginPos);
                }
                Content = Content.Replace("<HTML>", "");
                Content = Content.Replace("</HTML>", "");
                //
                Content = Content.Replace("<BODY>", "");
                Content = Content.Replace("</BODY>", "");
                //
                Content = Content.Replace("<HEAD>", "");
                Content = Content.Replace("</HEAD>", "");

                int b = Content.IndexOf("<META");
                if (b > 0)
                {
                    int ex = Content.IndexOf(">", b + 1);
                    if(ex > b)
                    {
                        Content = Content.Substring(ex + 1, Content.Length - (ex + 1));
                    }
                }

                b = Content.IndexOf("<META");
                if (b > 0)
                {
                    int ex = Content.IndexOf(">", b + 1);
                    if (ex > b)
                    {
                        Content = Content.Substring(ex + 1, Content.Length - (ex + 1));
                    }
                }




                b = Content.IndexOf("<BODY");
                if (b > 0)
                {
                    int ex = Content.IndexOf(">", b + 1);
                    if (ex > b)
                    {
                        Content = Content.Substring(ex + 1, Content.Length - (ex + 1));
                    }
                }

                b = Content.IndexOf("<DIV");
                if (b > 0)
                {
                    int ex = Content.IndexOf(">", b + 1);
                    if (ex > b)
                    {
                        Content = Content.Substring(ex + 1, Content.Length - (ex + 1));
                    }
                }


                MessageBox.Show(Content);
            }
            //提交到服务器
            //获得结果
            //展示结果



            var postData = "content=" + Uri.EscapeDataString(Content);
            //postData += "&thing2=world";
            // var data = Encoding.ASCII.GetBytes(postData);
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);



            var request = (HttpWebRequest)WebRequest.Create("http://api.ens.cuobiezi.net/api/v1/zh_spellcheck/check");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            var byteArrayNew = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = byteArrayNew.Length;

            using (var stream = request.GetRequestStream())
            {
                //stream.Write(data, 0, data.Length);
                stream.Write(byteArrayNew, 0, byteArrayNew.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();
            PreViewCuoBieZi newForm = new PreViewCuoBieZi();
            
            string linkStr = "";
            linkStr = "";


            //https://obfuscar.codeplex.com/

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            //MessageBox.Show(responseString);
            string styleTxt = "<style type=\"text/css\">  .cbznet_error { font - family: Simsun, \"新宋体\", \"Microsoft Yahei\",\"微软雅黑\", sans - serif;          font - size:100 %; text-decoration: underline; color:red;    }\n  .cbznet_hint { font - family:  \"Microsoft Yahei\",\"微软雅黑\", sans - serif;          font - size:100 %; text-decoration: underline;     } \n  .cbznet_other { font - family:  \"新宋体\", \"Microsoft Yahei\",\"微软雅黑\", sans - serif;          font - size:110 %; text-decoration: underline;     } </style> \n";
            newForm.webBrowserPreView.Navigate("about:blank");
            newForm.webBrowserPreView.Document.OpenNew(false).Write("<html><head>" + linkStr + "\n" + styleTxt+"</head><body>"+responseString+"</div></body></html>");
            //<div id=\"editable\">

            newForm.ShowDialog();

        }

        private void webBrowserMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}




