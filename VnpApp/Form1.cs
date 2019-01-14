using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VnpApp
{
    public partial class Form1 : Form
    {
        private string UserName = string.Empty;

        private string PassWord = string.Empty;
        string stbed = string.Empty;
        bool checkStop = false; 
        bool checkLoop = true;
        int countLB = 0;
        int indexUser = 0;
        int countUserSearch = 0;
        //  string ScriptGetNumber = "document.getElementById('lblKetqua').getElementsByTagName('tr')[1].getElementsByTagName('td')[1].innerText";

        public Form1()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.loadPage();
            this.AddListUser();
            LoadUser();
        }

        public void loadPage()
        {
            webBrowser1.Navigate("http://10.149.34.168/ccbs/login.htm");
        }

        private void LoadUser()
        {
            string[] User = new string[2];
            if (File.Exists("./User/User.txt"))
            {
                User = File.ReadAllLines("./User/User.txt");
            }
            UserName = User[0];
            PassWord = User[1];

            textBox1.Text = UserName;
            textBox2.Text = PassWord;

            txtTime.Text = "7000";

        }

        public void AddListUser()
        {
            cboUserFind.Items.Add("tuyennt_hcm");
            cboUserFind.Items.Add("dtt_phuongnth_hcm");
            cboUserFind.Items.Add("ngocdq_hcm");
            cboUserFind.Items.Add("trinnm_hcm");
            cboUserFind.Items.Add("nhuttt_hcm");
            cboUserFind.Items.Add("tripv_hcm");
            cboUserFind.Items.Add("chinhnv_hcm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Object[] objArray = new Object[2];
            objArray[0] = "1";
            objArray[1] = "10";
            webBrowser2.Document.InvokeScript("layds_thuebao2", objArray);
        }


        private void LoadPageFindNumber()
        {
            webBrowser2.Navigate("http://10.149.34.168/ccbs/main?1iutlomLork=vzzh5rgvnj5inutyu5otjk~");
            webBrowser4.Navigate("http://10.149.34.168/ccbs/main?1iutlomLork=vzzh5rgvnj5inutyu5otjk~");
        }

        private void LoadPageRegister()
        {
            webBrowser3.Navigate("http://10.149.34.168/ccbs/main?1iutlomLork=VZZH5jqeinutyu%7Fk{ig{5otjk~");
        }

        public void login(string user, string pass)
        {
            while (webBrowser1.Document.GetElementById("btnLogin") == null)
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }

            var userElements = webBrowser1.Document.GetElementById("username");
            var passElements = webBrowser1.Document.GetElementById("passWord");
            var clickElements = webBrowser1.Document.GetElementById("btnLogin");
            userElements.InnerText = user;
            passElements.InnerText = pass;
            clickElements.InvokeMember("click");


            while (webBrowser1.Document.GetElementById("ab") == null)
            {
                Application.DoEvents();
                Thread.Sleep(200);

            }
            this.LoadPageChild();
        }
        public void login2(string user, string pass)
        {
            while (webBrowser1.Document.GetElementById("btnLogin") == null)
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }

            var userElements = webBrowser1.Document.GetElementById("username");
            var passElements = webBrowser1.Document.GetElementById("passWord");
            var clickElements = webBrowser1.Document.GetElementById("btnLogin");
            userElements.InnerText = user;
            passElements.InnerText = pass;
            clickElements.InvokeMember("click");


            while (webBrowser1.Document.GetElementById("ab") == null)
            {
                Application.DoEvents();
                Thread.Sleep(500);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            login(user, pass);

        }

        private void AddScriptFind(string name)
        {
            string script = "var Objects=new Array,Fields=new Array,pNum=1,pRec=10,iFlag=1;function form_load()" +
             "{Objects=[\"txtSoTB\",\"cboLoaiSo\",\"cmdTimkiem\"],Fields=[\"SO_TB\",\"KIEU_SO\",null],change_subrange()," +
             "check_flag()}function getDsKHoa(){DataRemoting.getDoc('neo.numstore.doc_layds_khoa(\"" + name + "\")',DOC_layds_khoa)}var DOC_layds_khoa=function(o){$(\"ajaxKhoa\").innerHTML=o};" +
             "function check_flag(){DataRemoting.getValue(\"neo.numstore.doc_flag(5)\",flag_func)}" +
             "var flag_func=function(o){iFlag=\"1\"==o?1:2};function layds_thuebao2(o,e){document.getElementById('cboTrangthai').options[2].selected = 'selected';if(check_flag(),1==iFlag)" +
             "if(1==$(\"cboTrangthai\").value)var a='neo.numstore.doc_layds_thuebao_dk(\"'+$(\"txtSoTB\").value+'\"," +
             "\"'+$(\"cboLoaiSo\").value+'\",\"'+$(\"cboSubRange\").value+'\",\"'+$(\"cboTrangthai\").value+'\",\"" + name + "\",\"'+o+'\",\"'+e+'\")';else a='neo.numstore.doc_layds_thuebao_1(\"'+$(\"txtSoTB\").value+'\"," +
             "\"'+$(\"cboLoaiSo\").value+'\",\"'+$(\"cboSubRange\").value+'\",\"'+$(\"cboTrangthai\").value+'\",\"" + name + "\",\"'+o+'\",\"'+e+'\")';else a='neo.numstore.doc_layds_thuebao_api(\"'+$(\"txtSoTB\").value+'\"," +
             "\"'+$(\"cboLoaiSo\").value+'\",\"'+$(\"cboSubRange\").value+'\",\"'+$(\"cboTrangthai\").value+'\",\"" + name + "\"" +
             ",\"'+o+'\",\"'+e+'\")';pNum=o,pRec=e,$(\"ajaxKetqua\").style.height=0,DataRemoting.getDoc(a,DOC_layds_thuebao)," +
             "$(\"lblKetqua\").innerHTML=\"<font color=red><b>&#272;ang th&#7921;c hi&#7879;n ...</b></font>\"}" +
             "var DOC_layds_thuebao=function(o){if($(\"ajaxKetqua\").style.height=0,$(\"ajaxKetqua\").innerHTML=o,1==iFlag)" +
             "var e='neo.numstore.doc_layth_thuebao(\"'+$(\"txtSoTB\").value+'\",\"'+$(\"cboLoaiSo\").value+'\"," +
             "\"'+pNum+'\",\"'+pRec+'\")';else e='neo.numstore.doc_layth_thuebao_api(\"'+pNum+'\",\"'+pRec+'\")';" +
             "DataRemoting.getDoc(e,DOC_layth_thuebao)},DOC_layth_thuebao=function(o){$(\"ajaxKetquaTH\").innerHTML=o," +
             "$(\"lblKetqua\").innerHTML=\"\"};function foward_dangky(o,e,a,n,t,u,i)" +
             "{0==i?window.location=\"/ccbs/main?1y\u007fyezksvrgzkelork=rg\u007fu{z5iihy5zvreiihy&1iutlomLork=rgvvnok" +
             "{5otjk~&yuezh=\"+o+\"&zkteqok{yu=\"+Url.encode_1252(e)+\"&i{uiezuoznok{=\"+Url.encode_1252(a)+\"&zmey{j" +
             "{tm=\"+Url.encode_1252(n)+\"&jgziui=\"+Url.encode_1252(t)+\"&notnzn{iens=\"+Url.encode_1252(u):" +
             "alert(Url.decode_1252(\"Thu&#234; bao &#273;&#227; &#273;&#259;ng k&#253;\"))}function foward_thongtin(o,e)" +
             "{1==e?(openWindow(\"frmthongtin\",\"/ccbs/main?1iutlomLork=jgtmq\u007f5lxsznutmzot&yuezh=\"+o,\"frmthongtin\",500," +
             "150,\"menubar=no,toolbar=no,location=no,status=yes,scrollbars=no,resizable=yes\"),frmkmtc.focus()):" +
             "alert(\"Thue bao dang trong kho! \")}function forward_chitiet_tintuc(o){" +
             "window.location=\"/ccbs/main?1y\u007fyezksvrgzkelork=rg\u007fu{z5iihy5zvreiihy&1iutlomLork=zotz{i5otjk~&tk}e" +
             "oj=\"+o}function change_subrange(){var o='neo.numstore.doc_layds_kieuso_new(\"'+$(\"cboSubRange\").value+'\")';" +
             "DataRemoting.getDoc(o,function(o){$(\"kieuso_s\").innerHTML=o})}";

            HtmlDocument doc = webBrowser2.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text", script);
            head.AppendChild(s);
        }

        private void ClickFind(int page)
        {
            Object[] objArray = new Object[2];
            objArray[0] = page.ToString();
            objArray[1] = "10";
            webBrowser2.Document.InvokeScript("layds_thuebao2", objArray);
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            checkLoop = false;
            checkStop = true;
            while (checkStop)
            {

                Application.DoEvents();
            }
            btnStop.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            login(user, pass);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://10.149.34.168/ccbs/login.htm");
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            File.WriteAllText("./User/User.txt", textBox1.Text + Environment.NewLine + textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadPageChild()
        {
            lblUserFind.Text = cboUserFind.Items[0].ToString();
            this.LoadPageFindNumber();
            this.LoadPageRegister();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblUserFind.Text = cboUserFind.Items[0].ToString();
            this.LoadPageFindNumber();
            this.LoadPageRegister();
        }

        public void TranNumber()
        {
            int waitLoad = 0;

            while (webBrowser2.Document.GetElementById("lblKetqua").GetElementsByTagName("b").Count == 1)
            {
                waitLoad++;
                Application.DoEvents();
            }

            try
            {
                stbed = string.Empty;
                var length = webBrowser2.Document.GetElementById("table_phieu").GetElementsByTagName("tr").Count;
                string stb = string.Empty;
                string status = string.Empty;
                for (var i = 1; i < length; i++)
                {
                    stb = webBrowser2.Document.GetElementById("table_phieu").GetElementsByTagName("tr")[i].GetElementsByTagName("td")[1].InnerText;
                    status = webBrowser2.Document.GetElementById("table_phieu").GetElementsByTagName("tr")[i].GetElementsByTagName("td")[2].InnerText;
                    if (status == "Trong kho")
                    {
                        webBrowser3.Document.GetElementById("txtsomay").InnerHtml = stb;
                        stbed = stb;
                        if (!string.IsNullOrEmpty(stb)) {

                            string scriptSL3 = "action();";
                            HtmlDocument doc3 = webBrowser3.Document;
                            HtmlElement head3 = doc3.GetElementsByTagName("head")[0];
                            HtmlElement s3 = doc3.CreateElement("script");
                            s3.SetAttribute("text", scriptSL3);
                            head3.AppendChild(s3);
                        }
                        int waitLoad24 = 0;
                        while (true)
                        {
                            waitLoad24++;
                            Application.DoEvents();
                            Thread.Sleep(60);
                            if (waitLoad24 == 100) { break; }
                        }
                    }
                }

                if (length == 11)
                {
                    int waitLoad23 = 0;
                    while (true)
                    {
                        waitLoad23++;
                        Application.DoEvents();
                        Thread.Sleep(65);
                        if (waitLoad23 == 100) { break; }
                    }
                    countLB++;
                    ClickFind(countLB);
                    TranNumber();
                }
            }
            catch
            {
                webBrowser1.Document.ExecCommand("ClearAuthenticationCache", false, null);
 
                string[] theCookies = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
               /* foreach (string currentFile in theCookies)
                {
                    try
                    {
                        System.IO.File.Delete(currentFile);
                    }
                    catch (Exception ex)
                    {
                    }
                }*/
                this.loadPage();
                int waitLoad2 = 0;
                while (true)
                {
                    waitLoad2++;
                    Application.DoEvents();
                    Thread.Sleep(1);
                    if (waitLoad2 == 1000) { break; }
                }

                string user = textBox1.Text;
                string pass = textBox2.Text;
                login2(user, pass);

                int waitLoad3 = 0;
                while (true)
                {
                    waitLoad3++;
                    Application.DoEvents();
                    Thread.Sleep(1);
                    if (waitLoad2 == 1000) { break; }
                }
              //  webBrowser2.Navigate("http://10.149.34.168/ccbs/main?1iutlomLork=vzzh5rgvnj5inutyu5otjk~");
                btnFind_Click(new object(), new EventArgs());
            }

        }
        private void autoFind()
        {
            if (indexUser < cboUserFind.Items.Count)
            {
                AddScriptFind(cboUserFind.Items[indexUser].ToString());
                lblUserFind.Text = cboUserFind.Items[indexUser].ToString();
                Thread.Sleep(300);

                countLB++;
                ClickFind(countLB);

                TranNumber();
                countUserSearch++;
                if (countUserSearch > 4988)
                {
                    indexUser++;
                }
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            btnStop.Visible = true;
            checkLoop = true;
            checkStop = false;
            stbed = string.Empty;
            webBrowser3.Document.GetElementById("txtsomay").InnerHtml = string.Empty;
            AddFilerHide();
            while (checkLoop && string.IsNullOrEmpty(stbed))
            {
                countLB = 0;
                autoFind();
                int waitLoad = 0;
                while (true)
                {
                    waitLoad++;
                    Application.DoEvents();
                    Thread.Sleep(1);
                    if (waitLoad == 7000) { break; }
                }

            }

            //  autoFind();


        }

        private void cboUserFind_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddFilerHide()
        {
            string scriptSL = "document.getElementById('cboSubRange').options[" + webBrowser4.Document.GetElementById("cboSubRange").GetAttribute("selectedIndex")
              + "].selected = 'selected';change_subrange();setTimeout(function(){" + "document.getElementById('cboLoaiSo').options[" + webBrowser4.Document.GetElementById("cboLoaiSo").GetAttribute("selectedIndex") + "].selected = 'selected';" + "},300);";
            //document.getElementById('cboLoaiSo').options[" + webBrowser4.Document.GetElementById("cboLoaiSo").GetAttribute("selectedIndex") +"].selected = 'selected';
            HtmlDocument doc = webBrowser2.Document;
            HtmlElement head = doc.GetElementsByTagName("head")[0];
            HtmlElement s = doc.CreateElement("script");
            s.SetAttribute("text", scriptSL);
            head.AppendChild(s);
            int waitLoad = 0;
            while (true)
            {
                waitLoad++;
                Application.DoEvents();
                Thread.Sleep(1);
                if (waitLoad == 300) { break; }
            }
            webBrowser2.Document.GetElementById("txtSoTB").InnerText = webBrowser4.Document.GetElementById("txtSoTB").GetAttribute("value");
        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        /*private void button1_Click_2(object sender, EventArgs e)
{
   string scriptSL = "document.getElementById('cboSubRange').options[" + webBrowser4.Document.GetElementById("cboSubRange").GetAttribute("selectedIndex")
       + "].selected = 'selected';change_subrange();setTimeout(function(){" + "document.getElementById('cboLoaiSo').options[" + webBrowser4.Document.GetElementById("cboLoaiSo").GetAttribute("selectedIndex") + "].selected = 'selected';" + "},300);";
   //document.getElementById('cboLoaiSo').options[" + webBrowser4.Document.GetElementById("cboLoaiSo").GetAttribute("selectedIndex") +"].selected = 'selected';
   HtmlDocument doc = webBrowser2.Document;
   HtmlElement head = doc.GetElementsByTagName("head")[0];
   HtmlElement s = doc.CreateElement("script");
   s.SetAttribute("text", scriptSL);
   head.AppendChild(s);
   webBrowser2.Document.GetElementById("txtSoTB").InnerText = webBrowser4.Document.GetElementById("txtSoTB").GetAttribute("value");
}*/
    }
}
