using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Panel_C_
{
    public partial class Form1 : Form
    {
        IWebDriver driver;
        //Bu iki değişken kayıt edip etmediğini kontrol etmek için
        private bool isTextBoxSaved = false;
        private bool isCheckboxListSaved = false;
        private string filePath;  //dosya yolu
        public Form1()
        {
            InitializeComponent();
        }

        // Loglama işlemi için bir sınıf ekliyoruz
        public static class Logger
        {
            private static string logFilePath = "error_log.txt";
            public static void LogError(string message, Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"Timestamp: {DateTime.Now}");
                    writer.WriteLine($"Error Message: {message}");
                    writer.WriteLine($"Exception: {ex.Message}");
                    writer.WriteLine("--------------------------------------------------");
                }
            }
        }

        // Dinamik bekleme fonksiyonu
        private static void WaitForElement(IWebDriver driver, string xpath)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            }
            catch (Exception ex)
            {
                Logger.LogError($"Element not found: {xpath}", ex);
            }
        }

        //Genel selenium işlemleri
        public class SeleniumCustomMethods
        {
            public static void Click(IWebDriver driver, By locator)
            {
                driver.FindElement(locator).Click();
            }
            public static void EnterText(IWebDriver driver, By locator, string text)
            {
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }
        }

        //Giriş İşlemi
        private static void Login(IWebDriver driver, string username, string password)
        {
            try
            {
                WaitForElement(driver, "//*[@id=\"loginForm\"]/div/div[1]/div/label/input");
                SeleniumCustomMethods.EnterText(driver, By.XPath("//*[@id=\"loginForm\"]/div/div[1]/div/label/input"), username);

                WaitForElement(driver, "//*[@id=\"loginForm\"]/div/div[2]/div/label/input");
                SeleniumCustomMethods.EnterText(driver, By.XPath("//*[@id=\"loginForm\"]/div/div[2]/div/label/input"), password);

                WaitForElement(driver, "//*[@id=\"loginForm\"]/div/div[3]/button");
                SeleniumCustomMethods.Click(driver, By.XPath("//*[@id=\"loginForm\"]/div/div[3]/button"));
            }
            catch (Exception ex)
            {
                Logger.LogError("Error during login.", ex);
            }
        }

        // Takip etme işlemi
        private static void FollowUser(IWebDriver driver)
        {
            try
            {
                WaitForElement(driver, "//div[text()='Takip Et']");
                SeleniumCustomMethods.Click(driver, By.XPath("//div[text()='Takip Et']"));
                WaitForElement(driver, "//div[text()='Takiptesin']");
            }
            catch (NoSuchElementException ex)
            {
                Logger.LogError("Follow button not found.", ex);
            }
            catch (Exception ex)
            {
                Logger.LogError("Error while trying to follow user.", ex);
            }
        }
        // Yorum yapma işlemi
        private static void SendMessage(IWebDriver driver, string message)
        {
            try
            {
                WaitForElement(driver, "//textarea[@class='x1i0vuye xvbhtw8 x1ejq31n xd10rxx x1sy0etr x17r0tee x5n08af x78zum5 x1iyjqo2 x1qlqyl8 x1d6elog xlk1fp6 x1a2a7pz xexx8yu x4uap5 x18d9i69 xkhd6sd xtt52l0 xnalus7 xs3hnx8 x1bq4at4 xaqnwrm']");
                SeleniumCustomMethods.Click(driver, By.XPath("//textarea[@class='x1i0vuye xvbhtw8 x1ejq31n xd10rxx x1sy0etr x17r0tee x5n08af x78zum5 x1iyjqo2 x1qlqyl8 x1d6elog xlk1fp6 x1a2a7pz xexx8yu x4uap5 x18d9i69 xkhd6sd xtt52l0 xnalus7 xs3hnx8 x1bq4at4 xaqnwrm']"));
                SeleniumCustomMethods.EnterText(driver, By.XPath("//textarea[@class='x1i0vuye xvbhtw8 x1ejq31n xd10rxx x1sy0etr x17r0tee x5n08af x78zum5 x1iyjqo2 x1qlqyl8 x1d6elog xlk1fp6 x1a2a7pz xexx8yu x4uap5 x18d9i69 xkhd6sd xtt52l0 xnalus7 xs3hnx8 x1bq4at4 xaqnwrm focus-visible']"), message);
                driver.FindElement(By.XPath("//textarea[@class='x1i0vuye xvbhtw8 x1ejq31n xd10rxx x1sy0etr x17r0tee x5n08af x78zum5 x1iyjqo2 x1qlqyl8 x1d6elog xlk1fp6 x1a2a7pz xexx8yu x4uap5 x18d9i69 xkhd6sd xtt52l0 xnalus7 xs3hnx8 x1bq4at4 xaqnwrm focus-visible']")).SendKeys(OpenQA.Selenium.Keys.Return);
            }
            catch (NoSuchElementException ex)
            {
                Logger.LogError("Message text area not found.", ex);
            }
            catch (Exception ex)
            {
                Logger.LogError("Error while sending message.", ex);
            }
        }
        // Beğenme işlemi
        private static void LikePost(IWebDriver driver)
        {
            try
            {
                WaitForElement(driver, "//span[@class='xp7jhwk']");
                SeleniumCustomMethods.Click(driver, By.XPath("//span[@class='xp7jhwk']"));
                SeleniumCustomMethods.Click(driver, By.XPath("//span[@class='xp7jhwk']"));
            }
            catch (Exception ex)
            {
                Logger.LogError("Error while liking a post.", ex);
            }
        }

        //Buttonlara basınca panellerin gözüküp gözükmemesini ayarlama
        private void SetMessagePanelVisibility(bool IsVisible)
        {
            kln_lbl.Visible = !IsVisible;
            kln_txt.Visible = !IsVisible;
            sfr_txt.Visible = !IsVisible;
            sfr_lbl.Visible = !IsVisible;
            baslat_btn.Visible = !IsVisible;
            syc_lbl.Visible = !IsVisible;
            bgn_btn.Visible = !IsVisible;
            bgn_ckb.Visible = !IsVisible;
            tkp_ckb.Visible = !IsVisible;
            yrm_ckb.Visible = !IsVisible;
            yrm_btn.Visible = !IsVisible;
            insta_txt.Visible = !IsVisible;
            insta_lbl.Visible = !IsVisible;
            tkp_btn.Visible = !IsVisible;
            gnd_cmbbox.Visible = !IsVisible;
            yrm_syc_txt.Visible = !IsVisible;
            yrm_syc_lbl.Visible = !IsVisible;
            yrm_syc_chk.Visible = !IsVisible;
            yrm_ekl_btn.Visible = IsVisible;
            yrm_ckr_btn.Visible = IsVisible;
            yrm_tmz_btn.Visible = IsVisible;
            msj_chkbox.Visible = IsVisible;
            msj_txt.Visible = IsVisible;
        }

        //Kullanıcı adı, şifreler ve yorumları kaydetme
        private void Form1_Load(object sender, EventArgs e)
        {
            // Uygulama başlatıldığında kaydedilen verileri geri yükle
            kln_txt.Text = Properties.Settings.Default.Username;
            sfr_txt.Text = Properties.Settings.Default.Password;

            // CheckedListBox öğelerini ayarlardan geri yükler
            string[] items = Properties.Settings.Default.ListItems.Split(';');
            msj_chkbox.Items.AddRange(items);

            // Seçili öğeleri geri yükler
            string[] selectedItems = Properties.Settings.Default.SelectedItems.Split(';');
            for (int i = 0; i < msj_chkbox.Items.Count; i++)
            {
                if (Array.Exists(selectedItems, element => element == msj_chkbox.Items[i].ToString()))
                {
                    msj_chkbox.SetItemChecked(i, true);
                }
            }
        }
        // Form kapanırken verilerin kaydedilip kaydedilmediğini kontrol eder
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            // Hem TextBox hem de CheckedListBox verileri kaydedilmemişse
            if (!isTextBoxSaved && !isCheckboxListSaved)
            {
                DialogResult result = MessageBox.Show("Kullanıcı Bilgileri Ve Yorum Listesi Kaydedilmedi.\nÇıkmak İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;    //Formun kapatılmasını iptal et
                }
            }
            //Sadece textbox verileri kaydedilmişse
            else if (!isTextBoxSaved)
            {
                DialogResult result = MessageBox.Show("Kullanıcı Bilgileri Kaydedilmedi.\nÇıkmak İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;    //Formun kapatılmasını iptal et
                }
            }
            //Sadece checkboxlist verileri kaydedilmemişse
            else if (!isCheckboxListSaved)
            {
                DialogResult result = MessageBox.Show("Yorum Listesi Kaydedilmedi.\nÇıkmak İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;    //Formun kapatılmasını iptal et
                }
            }
        }
        private void kyt_btn_Click(object sender, EventArgs e)
        {
            //Eğer ana sayfada ise kullanıcı adı ve şifredeki bilgileri kaydet
            if (ana_btn.BackColor == Color.LightGray)
            {
                // Kullanıcı adı ve şifreyi kaydet
                Properties.Settings.Default.Username = kln_txt.Text;
                Properties.Settings.Default.Password = sfr_txt.Text;

                isTextBoxSaved = true;      //Textbox verileri kaydedildi
                MessageBox.Show("Kullanıcı Adı Ve Şifreler Başarıyla Kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //ana sayfada değil yorum seçme kısmındaysa checkboxlis'deki elemanları kaydet
            else
            {
                // CheckedListBox öğelerini kaydet
                string listItems = string.Join(";", msj_chkbox.Items.Cast<string>());
                Properties.Settings.Default.ListItems = listItems;

                // Seçili öğeleri kaydet
                string selectedItems = string.Join(";", msj_chkbox.CheckedItems.Cast<string>());
                Properties.Settings.Default.SelectedItems = selectedItems;

                isCheckboxListSaved = true;     //Checkboxlist verileri kaydedildi
                MessageBox.Show("Yorumlar Başarıyla Kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Ayarları kalıcı olarak kaydet
            Properties.Settings.Default.Save();
        }

        private void msj_btn_Click(object sender, EventArgs e)
        {
            if (msj_btn.BackColor == Color.White)
            {
                ana_btn.BackColor = Color.White;
                msj_btn.BackColor = Color.LightGray;
                SetMessagePanelVisibility(true);
            }
        }

        private void yrm_ekl_btn_Click_1(object sender, EventArgs e)
        {
            string msj_text = msj_txt.Text;
            if (string.IsNullOrWhiteSpace(msj_text))
            {
                MessageBox.Show("Önce Yorum Yazmalısınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                int CheckText = msj_chkbox.Items.IndexOf(msj_text);
                if (CheckText == -1)
                {
                    msj_chkbox.Items.Add(msj_text);
                    msj_txt.Text = "";
                    msj_txt.Focus();
                }
                else
                {
                    MessageBox.Show("Eklemek İstediğiniz Yorum Listede Zaten Var.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msj_txt.Text = "";
                    msj_txt.Focus();
                }
            }
            // Eklenen mesajları otomatik olarak seçili hale getir
            for (int i = 0; i < msj_chkbox.Items.Count; i++)
                msj_chkbox.SetItemChecked(i, true);
        }

        private void yrm_ckr_btn_Click(object sender, EventArgs e)
        {
            int SelectCheckbox = msj_chkbox.SelectedIndex;
            if (SelectCheckbox == -1)
            {
                MessageBox.Show("Önce Çıkarılacak Elemanı Seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                msj_chkbox.Items.RemoveAt(SelectCheckbox);
        }

        private void yrm_tmz_btn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Listedeki Tüm Yorumlar Silenecek. \nDevam Etmek İstediğinize Emin Misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
                msj_chkbox.Items.Clear();
        }

        private void ana_btn_Click(object sender, EventArgs e)
        {
            if (msj_btn.BackColor == Color.LightGray)
            {
                msj_btn.BackColor = Color.White;
                ana_btn.BackColor = Color.LightGray;
                SetMessagePanelVisibility(false);
            }
        }

        private void kln_txt_TextChanged(object sender, EventArgs e)
        {
            yrm_syc_lbl.Text = Convert.ToString(kln_txt.Lines.Count() + " Kişiden Kaç Tanesi Yorum Atsın");
            if (kln_txt.Text.Split('\n').Length > 19)
                kln_txt.ScrollBars = ScrollBars.Both;
            else
                kln_txt.ScrollBars = ScrollBars.None;

        }

        private void sfr_text_TextChanged(object sender, EventArgs e)
        {
            if (sfr_txt.Text.Split('\n').Length > 19)
                sfr_txt.ScrollBars = ScrollBars.Both;
            else
                sfr_txt.ScrollBars = ScrollBars.None;

        }

        private void bgn_btn_Click(object sender, EventArgs e)
        {
            if (bgn_ckb.Checked == false)
                bgn_ckb.Checked = true;
            else
                bgn_ckb.Checked = false;
        }

        private void tkp_btn_Click(object sender, EventArgs e)
        {
            if (tkp_ckb.Checked == false)
                tkp_ckb.Checked = true;
            else
                tkp_ckb.Checked = false;
        }

        private void yrm_btn_Click(object sender, EventArgs e)
        {
            if (yrm_ckb.Checked == false)
            {
                if (msj_chkbox.Items.Count == 0)
                {
                    MessageBox.Show("Önce Yorum Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    msj_btn.PerformClick();
                }
                else if (msj_chkbox.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Önce Yorum Seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    msj_btn.PerformClick();
                }
                else
                {
                    yrm_ckb.Checked = true;
                    yrm_syc_txt.Visible = true;
                    yrm_syc_lbl.Visible = true;
                    yrm_syc_chk.Visible = true;
                }
            }
            else
            {
                yrm_ckb.Checked = false;
                yrm_syc_txt.Visible = false;
                yrm_syc_lbl.Visible = false;
                yrm_syc_chk.Visible = false;
            }
        }

        private void yrm_syc_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (yrm_syc_chk.CheckState == CheckState.Checked)
            {
                yrm_syc_txt.Enabled = false;
                yrm_syc_txt.Text = Convert.ToString(kln_txt.Lines.Count());
            }
            else
            {
                yrm_syc_txt.Enabled = true;
            }
        }

        private void gnd_cmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gnd_cmbbox.SelectedIndex == 0)
                insta_lbl.Text = "Profil URL'sini Girin:";
            else
                insta_lbl.Text = "Gönderinin URL'sini Girin:";
        }

        private void baslat_btn_Click(object sender, EventArgs e)
        {
            int kln_toplam = kln_txt.Lines.Count();
            int sfr_toplam = sfr_txt.Lines.Count();
            if (gnd_cmbbox.SelectedItem == null)
            {
                MessageBox.Show("Önce İşlemin Nasıl Seçilçeğini Belirleyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gnd_cmbbox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(insta_txt.Text))
            {
                MessageBox.Show("Önce Seçtiğiniz İşlemin Linkini Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                insta_txt.Clear();
                insta_txt.Focus();
            }
            else if (string.IsNullOrWhiteSpace(kln_txt.Text) || string.IsNullOrWhiteSpace(sfr_txt.Text))
                MessageBox.Show("Önce Kullanıcı Adı Veya Şifre Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (kln_toplam != sfr_toplam)
                MessageBox.Show("Kullanıcı Adı İle Şifreler Aynı Sayıda Değil!!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int nullCheckCount = 0;
                bool klnNullCheck = false, sfrNullCheck = false;
                while (nullCheckCount <= kln_toplam - 1)
                {
                    string name = kln_txt.Lines[nullCheckCount];
                    string password = sfr_txt.Lines[nullCheckCount];
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        klnNullCheck = true;
                        break;  // Kullanıcı adı boşsa döngüyü sonlandır
                    }
                    if (string.IsNullOrWhiteSpace(password))
                    {
                        sfrNullCheck = true;
                        break;  // Şifre boşsa döngüyü sonlandır
                    }
                    nullCheckCount++;   // Sayaç artırılıyor
                }
                if (klnNullCheck)
                {
                    MessageBox.Show("Önce Kullanıcı Adı Kısmındaki Boş Yerleri Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (sfrNullCheck)
                {
                    MessageBox.Show("Önce Şifre Kısmındaki Boş Yerleri Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (bgn_ckb.Checked == true || yrm_ckb.Checked == true || tkp_ckb.Checked == true)
                {
                    DialogResult report = MessageBox.Show("Hatalı Yapılan Giriş Çıkış İşlemlerinin Raporunu Tutmak İstiyor Musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (report == DialogResult.Yes)
                    {
                        using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                        {
                            if (folderDialog.ShowDialog() == DialogResult.OK)
                            {
                                string selectedPath = folderDialog.SelectedPath; //seçilen dizin
                                filePath = Path.Combine(selectedPath, "Hatalı Girişler.txt");  // Dosya yolunu oluştur
                                MessageBox.Show("Dosya yolu seçildi: " + filePath, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    ChromeOptions options = new ChromeOptions();
                    options.AddUserProfilePreference("profile.managed_default_content_settings.images", 2);  // Görsel yüklemesini devre dışı bırak
                    options.AddArgument("--disable-blink-features=AutomationControlled"); // Bot tespitini azaltmak için gerçek tarayıcı kullancak
                    Random rnd = new Random();    //Rasgele sayı üretmek için
                    int waitTime = rnd.Next(2000, 5000);   //2 ile 5 saniye arası rasgele süre tut (İşlemler arası bot algılamasını azaltma için)
                    int waitTimeLogin = rnd.Next(5000, 10000);    //5 ile 10 saniye arası rasgele süre tut (Giriş bekleme arası bot algılamasını azaltma için)
                    int rnd_number = rnd.Next(msj_chkbox.CheckedItems.Count);   //yorumları rasgele seçmek için seçili yorum kadar rasgele sayı üret
                    int wrongLoginCount = 0;
                    driver = new ChromeDriver(options);     //Tarayıcıyı aç
                    driver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/");   //Giriş yapabilmek için Instagram giriş sayfasına gidilir
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);     //10 sn içinde sayfa yüklenmesini bekle
                    for (int i = 0; i <= kln_toplam - 1; i++)
                    {
                        int j = i - 1;
                        syc_lbl.Text = "Toplam Hesap: " + kln_toplam + " Tamamlanan hesaplar: " + j;
                        Login(driver, kln_txt.Lines[i], sfr_txt.Lines[i]);
                        Thread.Sleep(waitTimeLogin);    //Giriş yapılıp yapılmadığını anlamak ve bot olduğu anlaşılmasını zorlamak
                        bool LoginCheck = driver.FindElements(By.XPath("//*[@id=\"loginForm\"]/div/div[3]/button")).Count > 0;  //Eğer halen giriş yap var ise true ol
                        if (LoginCheck == true)
                        {
                            string name = kln_txt.Lines[i];
                            string password = sfr_txt.Lines[i];
                            driver.Navigate().GoToUrl("https://www.instagram.com/accounts/logout/");   //Nolur ne olmaz çıkış işlemi gecekleştirelim.
                            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                            string directory = Path.GetDirectoryName(filePath);
                            if (!string.IsNullOrEmpty(directory))    // Dizini al ve eğer null değilse oluştur
                            {
                                Directory.CreateDirectory(directory);   // Dizini oluştur
                            }
                            // Dosyayı oluştur ve kullanıcı bilgilerini yaz
                            using (StreamWriter sw = new StreamWriter(filePath, true)) // 'true' append modunda açar
                            {
                                sw.WriteLine($"{name} - {password}"); // İsim ve şifreyi yan yana yaz
                            }
                            LoginCheck = false;
                            wrongLoginCount++;
                        }
                        else
                        {

                            driver.Navigate().GoToUrl(insta_txt.Text);
                            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                            if (gnd_cmbbox.SelectedIndex == 0)
                            {
                                if (tkp_ckb.Checked == true)
                                {
                                    FollowUser(driver);
                                    Thread.Sleep(waitTime);
                                }
                                if (bgn_ckb.Checked == true || yrm_ckb.Checked == true)
                                {
                                    WaitForElement(driver, "//div[@class='_aagw']");
                                    SeleniumCustomMethods.Click(driver, By.XPath("//div[@class='_aagw']"));
                                    driver.Navigate().Refresh();
                                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                                    if (bgn_ckb.Checked == true)
                                    {
                                        LikePost(driver);
                                        Thread.Sleep(waitTime);
                                    }
                                    if (yrm_ckb.Checked == true)
                                    {
                                        if (i <= Convert.ToInt32(yrm_syc_txt.Text))
                                        {
                                            string message = msj_chkbox.Items[rnd_number].ToString();
                                            SendMessage(driver, message);
                                            Thread.Sleep(waitTime);
                                        }

                                    }
                                }
                            }
                            else
                            {
                                if (bgn_ckb.Checked == true)
                                {
                                    LikePost(driver);
                                    Thread.Sleep(waitTime);
                                }
                                if (yrm_ckb.Checked == true)
                                {
                                    if (i <= Convert.ToInt32(yrm_syc_txt.Text))
                                    {
                                        string message = msj_chkbox.Items[rnd_number].ToString();
                                        SendMessage(driver, message);
                                        Thread.Sleep(waitTime);
                                    }
                                }
                                if (tkp_ckb.Checked == true)
                                {
                                    driver.FindElement(By.XPath("//span[@class='_ap3a _aaco _aacw _aacx _aad7 _aade']")).Click();
                                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                                    FollowUser(driver);
                                    Thread.Sleep(waitTime);
                                }
                            }
                            // Çıkış işlemi yerine tarayıcıyı kapatmadan yeni bir hesaba giriş yapma stratejisi
                            driver.Navigate().GoToUrl("https://www.instagram.com/accounts/logout/");
                        }
                    }
                    driver.Quit();
                    syc_lbl.Text = "Tamamlanan Hesaplar: " + kln_toplam + " Giriş Yapılamayanlar:" + wrongLoginCount;
                    if (report == DialogResult.Yes)
                    {
                        DialogResult reportCheck = MessageBox.Show("İşlemler Tamamlandı.\nRapor " + filePath + " Yoluna Kaydedildi.Gormek İstermisiniz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (reportCheck == DialogResult.Yes)
                        {
                            if (File.Exists(filePath))
                            {
                                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                            }
                            else
                            {
                                MessageBox.Show("Dosya Bulunamadı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("İşlemler Tamamlandı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                    MessageBox.Show("Önce Yapılmasını İstediğiniz İşlemleri Seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

