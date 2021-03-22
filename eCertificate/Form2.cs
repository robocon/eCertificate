using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaiNationalIDCard;

namespace eCertificate
{
    public partial class Form2 : Form
    {
        Form1 frm1 = new Form1();
        public string fullname;
        public string hosId;
        public string hosName;
        public string level;

        ThaiIDCard idcard;
        string[] cardReaders;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            showUserLogin.BeginInvoke(new MethodInvoker(delegate { showUserLogin.Text = fullname; }));
            showHosName.BeginInvoke(new MethodInvoker(delegate { showHosName.Text = hosName; }));

            userFullName.BeginInvoke(new MethodInvoker(delegate { userFullName.Text = ""; }));
            userIdcard.BeginInvoke(new MethodInvoker(delegate { userIdcard.Text = ""; }));
            userDiag.BeginInvoke(new MethodInvoker(delegate { userDiag.Text = ""; }));
            userRegular.BeginInvoke(new MethodInvoker(delegate { userRegular.Text = ""; }));
            userDoctor.BeginInvoke(new MethodInvoker(delegate { userDoctor.Text = ""; }));
            userAddress.BeginInvoke(new MethodInvoker(delegate { userAddress.Text = ""; }));
            userDateDiag.BeginInvoke(new MethodInvoker(delegate { userDateDiag.Text = ""; }));
            userHos.BeginInvoke(new MethodInvoker(delegate { userHos.Text = ""; }));

            try
            {
                Console.WriteLine("Form1 was loaded");
                idcard = new ThaiIDCard();
                cardReaders = idcard.GetReaders();
                idcard.MonitorStart(cardReaders[0].ToString());
                idcard.eventCardInserted += new handleCardInserted(CardInsertedCallback);
                idcard.eventCardRemoved += new handleCardRemoved(CardRemoveCallback);
            }
            catch (Exception ex)
            {
                notify.ForeColor = System.Drawing.Color.Red;
                notify.Text = "ไม่พบเครื่องอ่านบัตรสมาร์ตการ์ด";
            }
        }

        public async void CardInsertedCallback(Personal personal)
        {
            var person = await RunCardReadder();
            string idcard = person.Citizenid;
            searchIdCard.BeginInvoke(new MethodInvoker(delegate { searchIdCard.Text = ""; }));
            notify.ForeColor = System.Drawing.Color.Green;
            notify.BeginInvoke(new MethodInvoker(delegate { notify.Text = "กำลังอ่านบัตรสมาร์ทการ์ด"; }));
            searchUserById(idcard);
        }

        public void CardRemoveCallback()
        {
            idcard.MonitorStop(cardReaders[0].ToString());
            userFullName.BeginInvoke(new MethodInvoker(delegate { userFullName.Text = ""; }));
            userIdcard.BeginInvoke(new MethodInvoker(delegate { userIdcard.Text = ""; }));
            userDiag.BeginInvoke(new MethodInvoker(delegate { userDiag.Text = ""; }));
            userRegular.BeginInvoke(new MethodInvoker(delegate { userRegular.Text = ""; }));
            userDoctor.BeginInvoke(new MethodInvoker(delegate { userDoctor.Text = ""; }));
            userAddress.BeginInvoke(new MethodInvoker(delegate { userAddress.Text = ""; }));
            userDateDiag.BeginInvoke(new MethodInvoker(delegate { userDateDiag.Text = ""; }));
            userHos.BeginInvoke(new MethodInvoker(delegate { userHos.Text = ""; }));
        }

        public async Task<Personal> RunCardReadder()
        {
            var person = await Task.Run(() => GetPersonalCardreader());
            return person;
        }

        public Personal GetPersonalCardreader()
        {
            idcard = new ThaiIDCard();
            Personal person = idcard.readAllPhoto();
            return person;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idcard = searchIdCard.Text;
            if (string.IsNullOrEmpty(idcard) || idcard.Length != 13)
            {
                notify.ForeColor = System.Drawing.Color.Red;
                notify.BeginInvoke(new MethodInvoker(delegate { notify.Text = "กรุณาตรวจสอบเลขบัตรประชาชนอีกครั้ง"; }));
                return;
            }
            searchUserById(idcard);
        }

        public async void searchUserById(string idcard)
        {
            searchUser user = new searchUser();
            user.idcard = idcard;
            string json = JsonConvert.SerializeObject(user);
            try
            {
                StringContent sC = new StringContent(json, Encoding.UTF8, "application/json");
                string content = await Task.Run(() => searchUser(sC));
                resDataUser resUser = JsonConvert.DeserializeObject<resDataUser>(content);
                if (resUser.resStatus == "n")
                {
                    notify.BeginInvoke(new MethodInvoker(delegate { notify.Text = resUser.msg; }));
                }
                else
                {
                    notify.BeginInvoke(new MethodInvoker(delegate { notify.Text = ""; }));
                    userFullName.BeginInvoke(new MethodInvoker(delegate { userFullName.Text = resUser.fullname; }));
                    userIdcard.BeginInvoke(new MethodInvoker(delegate { userIdcard.Text = resUser.idcard; }));
                    userDiag.BeginInvoke(new MethodInvoker(delegate { userDiag.Text = resUser.diag; }));
                    userRegular.BeginInvoke(new MethodInvoker(delegate { userRegular.Text = resUser.regula; }));
                    userDoctor.BeginInvoke(new MethodInvoker(delegate { userDoctor.Text = resUser.doctor; }));
                    userAddress.BeginInvoke(new MethodInvoker(delegate { userAddress.Text = resUser.address; }));
                    userDateDiag.BeginInvoke(new MethodInvoker(delegate { userDateDiag.Text = resUser.date_add; }));
                    userHos.BeginInvoke(new MethodInvoker(delegate { userHos.Text = resUser.hosId; }));
                }
            }
            catch (Exception ex)
            {
                notify.BeginInvoke(new MethodInvoker(delegate { notify.Text = ex.Message; }));
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1.Show();
        }

        public async Task<string> searchUser(StringContent sC)
        {
            string content = "";
            try
            {
                HttpClient httpClient = new HttpClient();
                var response = await httpClient.PostAsync("https://e-medical-certificate.com/api/user", sC);
                //var response = await httpClient.PostAsync("http://localhost/emedical/api/user", sC);
                response.EnsureSuccessStatusCode();
                content = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                notify.BeginInvoke(new MethodInvoker(delegate { notify.Text = ex.Message; }));
            }
            return content;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm1.Close();
            Application.Exit();
        }
    }

    public class searchUser
    {
        public string idcard { set; get; }
    }

    public class resDataUser
    {
        public string resStatus { set; get; }
        public string fullname { set; get; }
        public string idcard { set; get; }
        public string address { set; get; }
        public string province { set; get; }
        public string diag { set; get; }
        public string regula { set; get; }
        public string doctor { set; get; }
        public string date_add { set; get; }
        public string cert { set; get; }
        public string status { set; get; }
        public string hosId { set; get; }
        public string msg { set; get; }
    }
}
