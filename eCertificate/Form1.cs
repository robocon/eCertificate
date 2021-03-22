using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCertificate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            notifyLabel.Text = "";
            string user = username.Text.Trim();
            string pass = password.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                notifyLabel.Text = "กรุณาใส่ชื่อผู้ใช้งานและรหัสผ่าน";
                return;
            }

            Login frm = new Login();
            frm.username = user;
            frm.password = pass;

            string json = JsonConvert.SerializeObject(frm);
            //Console.WriteLine(json);



            StringContent sC = new StringContent(json, Encoding.UTF8, "application/json");
            string content = await Task.Run(() => DoWorkJson(sC));

            if (string.IsNullOrEmpty(content))
            {

                return;
            }
                
            //Console.WriteLine(content);
            //return;
            ResLogin resUser = JsonConvert.DeserializeObject<ResLogin>(content);
            if (resUser.resStatus == "n")
            {
                notifyLabel.Text = "ชื่อผู้ใช้งานหรือรหัสผ่านผิดพลาดกรุณาลองใหม่อีกครั้ง";
            }
            else
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.fullname = resUser.fullname;
                f2.level = resUser.level;
                f2.hosId = resUser.hos_id;
                f2.hosName = resUser.hosName;
                f2.ShowDialog();
            }

        }

        public async Task<string> DoWorkJson(StringContent sC)
        {
            string content = "";
            try
            {
                HttpClient httpClient = new HttpClient();
                var response = await httpClient.PostAsync("https://e-medical-certificate.com/api/login", sC);
                //var response = await httpClient.PostAsync("http://localhost/emedical/api/login", sC);
                response.EnsureSuccessStatusCode();
                content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                //content = "DoWorkJson " + ex.Message;
                //content = "";
                notifyLabel.Text = "ไม่สามารถติดต่อกับเซิฟเวอร์ได้";
                //return;
            }
            return content;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

    public class Login
    {
        public string username { set; get; }
        public string password { set; get; }
    }

    public class ResLogin
    {
        public string resStatus { set; get; }
        public int id { set; get; }
        public string username { set; get; }
        public string email { set; get; }
        public string fullname { set; get; }
        public string level { set; get; }
        public string hos_id { set; get; }
        public string hosName { set; get; }
    }
}
