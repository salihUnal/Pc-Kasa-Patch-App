using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;





namespace PcKasaPatchUygulaması
{

    public partial class LoginFrm : Form
    {







        public LoginFrm()
        {
            InitializeComponent();


        }

        IntroForm iform = new IntroForm();


        private SqlConnection baglan = new SqlConnection();

        private void Form2_Load(object sender, EventArgs e)
        {

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }






        public void LoginBtn_Click(object sender, EventArgs e)   //// login ekranı kodu
        {



            PcKasaUpdate yeni = new PcKasaUpdate();

            //access databaseden kullanıcı çekme kodu
            //loginfrm lgnfrm = new loginfrm();
            //oledbconnection bag = new oledbconnection("provider=microsoft.jet.oledb.4.0;data source=|datadirectory|\\users.mdb");
            //oledbcommand cmd = new oledbcommand();

            //int i = 0;
            //try
            //{



            //    if (usertxtbox.text == "" || passwordtxtbox.text == "")
            //    {
            //        messagebox.show("giriş yapmak için tüm alanları doldurmanız gerekiyor!", "hata", messageboxbuttons.ok, messageboxıcon.stop);
            //    }

            //    else { }

            //    cmd = new oledbcommand("select count(*) from users where user_name = '" + usertxtbox.text + "' and  user_password = '" + passwordtxtbox.text + "'", bag);

            //    if (bag.state == connectionstate.closed)
            //    {

            //        bag.open();
            //        i = (int)cmd.executescalar();

            //    }
            //    else { }


            //    bag.close();
            //    if (i > 0)
            //    {


            //        lgnfrm.close();
            //        yeni.topmost = true;
            //        yeni.showdialog();


            //    }



            //    else
            //    {
            //        messagebox.show("kullanıcı bilgileri veritabanında bulunamadı.\nkullanıcı adı şifrenizi kontrol edin");
            //    }

            //}

            //catch (exception ex)
            //{
            //    messagebox.show(ex.tostring());

            //}


            // Veritabanindaki kullanicilar




            //return builder.ToString();



            //  if (UserTxtBox.Text == "admin" && PasswordTxtBox.Text == "3c94f197bc76bcdd17b00ffd53644d8e")
            //  {

            //  string inputText = PasswordTxtBox.Text;

            //  var calculateHash = EasyEncryption.SHA.ComputeSHA256Hash(inputText);
            ////  MessageBox.Show(calculateHash);

            //  string textToValidate = "c";
            //  var validate = EasyEncryption.SHA.ComputeSHA256Hash(textToValidate);
            //  //if (validate == true)
            //  //{
            //  //    //SuccessLbl.Text = "Dogrulandı";
            //  //}
            //  //else if (validate != true)
            //  //{
            //  //    SuccessLbl.Text = "Doğrulanamadı";
            //  //}

            //  //if (SifrelenmisVeri != null)
            //  //    {
            //  //    MessageBox.Show(SifrelenmisVeri);
            //  this.Hide();
            //      yeni.TopMost = true;
            //      yeni.ShowDialog();

            //      //    }

            //  }



            //  else
            //  {
            //      SuccessLbl.Show();
            //      SuccessLbl.Text = "Hatalı Giriş";
            //      UserTxtBox.Clear();
            //      PasswordTxtBox.Clear();

            //  }
            String pas = "B3EA17A3C18A1EE3B1FCD42898B7667668FD754F084143E5CF5E908D24E314BC";

            if (UserTxtBox.Text == "admin" && stringTOSHA256(PasswordTxtBox.Text) == pas)

            {

                this.Hide();
                ////yeni.TopMost = true;
                yeni.ShowDialog();


            }


            else
            {
                if (UserTxtBox.Text != "admin" && stringTOSHA256(PasswordTxtBox.Text) != pas)
                {
                    MessageBox.Show("Lütfen Kullanıcı Adınızı ve Şifrenizi Kontrol Ediniz");
                }
                else if (UserTxtBox.Text != "admin")
                {
                    MessageBox.Show("Lütfen Kullanıcı Adınızı Kontrol Ediniz");
                }
                else {
                    MessageBox.Show("Lütfen Şifrenizi Kontrol Ediniz");
                }
               
            }

            static String stringTOSHA256(String myMsg)
            {
                if (myMsg == "" || myMsg == null)

                {

                    MessageBox.Show("Lütfen Şifre Giriniz!!!");
                    return "";

                }
                else

                {

                    var msgBytes =
                    Encoding.ASCII.GetBytes(myMsg);

                    var sha = new SHA256Managed();
                    var hash = sha.ComputeHash(msgBytes);

                    String pass = "";
                    foreach (byte b in hash)
                    {
                        // write as hexadecimal
                        pass += b.ToString("x2").ToUpper();
                    }

                    return pass;
                }
            }

        }









        private void CancelBtn_Click(object sender, EventArgs e)   //// cancel butonu kodu
        {
            Close();
           
            //Application.Exit();
            iform.Show();



        }

        private void girisEkranGbox_Enter(object sender, EventArgs e)   //// uygulama versiyonu için henüz çalışmıyor !!!!!!
        {
            string _s1 = Application.ProductVersion; // versiyon
            string _s2 = Application.CompanyName; // şirket bilgisi
            string _s3 = Application.ProductName; // proje adı.

        }

        private void UserTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

