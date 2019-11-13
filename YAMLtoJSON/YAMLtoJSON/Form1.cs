using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YAMLtoJSON.Convertor;

namespace YAMLtoJSON
{
    public partial class Form1 : Form
    {
        #region 属性

        public static Mutex mutex = new Mutex();
        public static AutoResetEvent resetEvent = new AutoResetEvent(false);
        public static Semaphore semaphore = new Semaphore(0, 1);
        public delegate string ConvertDelegate(object data);

        public delegate void SetOutPut(string data);
        private const string Document = @"---
            receipt:    Oz-Ware Purchase Invoice
            date:        2007-08-06
            customer:
                given:   Dorothy
                family:  Gale

            items:
                - part_no:   A4786
                  descrip:   Water Bucket (Filled)
                  price:     1.47
                  quantity:  4

                - part_no:   E1628
                  descrip:   High Heeled ""Ruby"" Slippers
                  price:     100.27
                  quantity:  1

            bill-to:  &id001
                street: |
                        123 Tornado Alley
                        Suite 16
                city:   East Westville
                state:  KS

            ship-to:  *id001

            specialDelivery:  >
                Follow the Yellow Brick
                Road to the Emerald City.
                Pay no attention to the
                man behind the curtain.
...";
    
    #endregion 属性

    #region 方法
    public Form1()
        {
            InitializeComponent();
        }

        private void SetOutPutStr(string result)
        {
            textBoxOutput.Text = result;
        }

        #endregion 方法

        #region 事件

        private void ClearInput_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
        }

        private void ClearOutput_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = "";
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            Process();
        }
        private void CopyOutput_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxOutput.Text);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion 事件

        #region 业务

        /// <summary>
        /// 处理器
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string Convertor(object data)
        {
            while (true)
            {
                resetEvent.WaitOne();
                string datastr = data as string;
                YAMLParser yaml = new YAMLParser();
                #region 方法一
                object yamlObject = yaml.ParseYamlString(datastr);
                string jsonStr1 = yaml.ToJson(datastr);
                #endregion
                #region 方法二
                JSONParser json = new JSONParser();
                string jsonStr2 = json.ParseJsonObject(yamlObject);
                #endregion
                resetEvent.Reset();
                return jsonStr1;
            }
        }

        public void Process()
        {
            Task<string> t = new Task<string>(() =>
            {
                ConvertDelegate cdelegate = new ConvertDelegate(Convertor);
                resetEvent.Set();
                IAsyncResult res = cdelegate.BeginInvoke(textBoxInput.Text, WriteFileCallback, textBoxInput.Text);
                //异步执行完成
                string resultstr = cdelegate.EndInvoke(res);
                return resultstr;
            });
            t.Start();
            string result = t.Result;
            SetOutPut stcb = new SetOutPut(SetOutPutStr);
            t.ContinueWith((str) => { this.Invoke(stcb, result); return result; });
        }

        /// <summary>
        /// 异步回调写入文件
        /// </summary>
        /// <param name="data"></param>
        public void WriteFileCallback(IAsyncResult data)
        {
            File.WriteAllText(Environment.CurrentDirectory + "\\" + Guid.NewGuid() + ".json", data.AsyncState as string);
        }
        #endregion 业务
    }
}