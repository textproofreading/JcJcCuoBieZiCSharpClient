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
using System.IO;
using System.Net.Http;

using Newtonsoft.Json;  //<---------------------------------  using Newtonsoft.Json;  
using System.Web.Script.Serialization;

namespace JcJcCuoBieZiDotNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                var reqparm = new System.Collections.Specialized.NameValueCollection();
                reqparm.Add("check_mode", "advanced");
                reqparm.Add("action", "show");

                reqparm.Add("username", "tester");
                reqparm.Add("content", textBox1.Text);
                byte[] responsebytes = client.UploadValues("http://www.cuobiezi.net/api/v1/zh_spellcheck/json", "POST", reqparm);  
                string responsebody = Encoding.UTF8.GetString(responsebytes);

                MessageBox.Show(responsebody);
            }




        }

        /**
         * 
         * 参考 
         * http://blog.csdn.net/sajiazaici/article/details/77647625
         * 
         */
        private void button2_Click(object sender, EventArgs e)
        {


            if (true)
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://api.CuoBieZi.net/spellcheck/json_check/json_phrase");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        username = "tester",
                        content = this.textBox1.Text,
                        biz_type = "show",
                        mode = "advanced",
                    });

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();


                    RootObject rb_json = JsonConvert.DeserializeObject<RootObject>(result);
                    foreach (Case ep in rb_json.Cases)
                    {
                        //Console.WriteLine(ep.age);
                        string postContentOne = "";
                        postContentOne = ep.Error + " -> " + ep.Tips;
                        MessageBox.Show(postContentOne);
                    }



                }

                return;
            }
            if (true)
            {



                string strURL = "http://api.CuoBieZi.net/spellcheck/json_check/json_phrase";

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(strURL);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                //

                //jsonParas = "{'content': '" + textBox1.Text + "' , 'mode' : 'advanced' , 'biz_type' : 'show', 'user_name' : 'tester' }";



                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"content\":\"" + textBox1.Text + "\"," +
                        "\"mode\":\"advanced\"," +
                        "\"biz_type\":\"show\"," +
                                  "\"username\":\"tester\"}";

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    string postContentResult = streamReader.ReadToEnd();




                    RootObject rb_json = JsonConvert.DeserializeObject<RootObject>(postContentResult);
                    foreach (Case ep in rb_json.Cases)
                    {
                        //Console.WriteLine(ep.age);
                        string postContentOne = "";
                        postContentOne = ep.Error + " -> " + ep.Tips;
                        MessageBox.Show(postContentOne);
                    }





                }


            }
            if (true)
            {
                return;
            }
            if (true)
            {
                //////
                // public string Post(string Url, string jsonParas)
                //{
                string strURL = "http://api.CuoBieZi.net/spellcheck/json_check/json_phrase";

                //创建一个HTTP请求 
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
                //Post请求方式 
                request.Method = "POST";
                //内容类型
                request.ContentType = "application/x-www-form-urlencoded";

                //设置参数，并进行URL编码 

                string jsonParas = "{\"content\": \"" + textBox1.Text + "\",\"mode\": \"advanced\",\"biz_type\": \"show\", \"username\":\"tester\"}";




                string paraUrlCoded = jsonParas;//System.Web.HttpUtility.UrlEncode(jsonParas);   

                byte[] payload;
                //将Json字符串转化为字节 
                payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
                //设置请求的ContentLength  
                request.ContentLength = payload.Length;
                //发送请求，获得请求流 

                Stream writer;
                try
                {
                    writer = request.GetRequestStream();//获取用于写入请求数据的Stream对象
                }
                catch (Exception)
                {
                    writer = null;
                    Console.Write("连接服务器失败!");
                }
                //将请求参数写入流
                writer.Write(payload, 0, payload.Length);
                writer.Close();//关闭请求流

                String strValue = "";//strValue为http响应所返回的字符流
                HttpWebResponse response;
                try
                {
                    //获得响应流
                    response = (HttpWebResponse)request.GetResponse();
                }
                catch (WebException ex)
                {
                    response = ex.Response as HttpWebResponse;
                }

                Stream s = response.GetResponseStream();


                //Stream postData = Request.InputStream;
                StreamReader sRead = new StreamReader(s);
                string postContent = sRead.ReadToEnd();
                sRead.Close();



                RootObject rb = JsonConvert.DeserializeObject<RootObject>(postContent);
                foreach (Case ep in rb.Cases)
                {
                    //Console.WriteLine(ep.age);
                    postContent = "";
                    postContent = ep.Error + " -> " + ep.Tips;
                    MessageBox.Show(postContent);
                }





                //{"Cases":[{"Error":"中国人民共和国","Tips":"中华人民共和国","Sentence":"腾讯今年中国人民共和国下半年上世纪将在微信账户钱包帐户的“九宫格”中开设快速的笑着保险入口，","ErrInfo":"","Pos":4,"MarkType":19,"ErrLevel":1}]}


                Console.WriteLine(postContent);

                //return postContent;//返回Json数据
                //}


                //接收
                //获取post过来的json数据结构
                //Stream postData = Request.InputStream;
                //StreamReader sRead = new StreamReader(postData);
                //string postContent = sRead.ReadToEnd();
                //sRead.Close();

                //////
            }

        }
    }


    public class Case
    {
        public string Error;
        public string Tips;
        public string Sentence;
        public int Pos;
        public int ErrLevel;

    }


    public class RootObject
    {
        //public string companyID { get; set; }
        public List<Case> Cases { get; set; }
        //public List<Manager> manager { get; set; }
    }



}
