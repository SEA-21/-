using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


// К сожалению я не успела доделать работу. Из-за технических проблем поздно начала делать.

namespace БиблиотекаСтудент
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public string defpath = "users.xml"; // переменная простоты изменения пути к Xml файлу в дальнейшем

        private void Form1_Load(object sender, EventArgs e) // для того, чтобы создать xml файл если его ещё нет
        {
            if (!File.Exists(defpath))
                CreateXMLDocument(defpath);
        }

        private void CreateXMLDocument(string filepath) //создание xml при запуске
        {
            XmlTextWriter xtw = new XmlTextWriter(filepath, Encoding.UTF32);
            xtw.WriteStartDocument();
            xtw.WriteStartElement("users");
            xtw.WriteEndDocument();
            xtw.Close();
        }

        private string MaxID(string filepath) //вычисление max id
        {
            List<int> idList = new List<int>();
            int id;
            XmlDocument xd = new XmlDocument();
            FileStream fs = new FileStream(filepath, FileMode.Open);
            xd.Load(fs);
            XmlNodeList list = xd.GetElementsByTagName("user");
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    XmlElement user = (XmlElement)xd.GetElementsByTagName("user")[i];
                    id = Convert.ToInt32(user.GetAttribute("id"));
                    idList.Add(id);
                }
                int result = 0;
                foreach (int j in idList)
                    if (j > result)
                        result = j;
                result++;
                fs.Close();
                return result.ToString();
            }
            else
            {
                fs.Close();
                return "1";
            }
        }

        private void WriteToXMLDocument(string filepath, string name, string pwd) //добавление записи
        {
            if (!File.Exists(defpath))
                CreateXMLDocument(defpath);
            string id = MaxID(filepath);
            XmlDocument xd = new XmlDocument();
            FileStream fs = new FileStream(filepath, FileMode.Open);
            xd.Load(fs);

            XmlElement user = xd.CreateElement("user");
            user.SetAttribute("id", id);

            XmlElement login = xd.CreateElement("login");
            XmlElement pass = xd.CreateElement("password");

            XmlText tLogin = xd.CreateTextNode(name);
            XmlText tPassword = xd.CreateTextNode(pwd);

            login.AppendChild(tLogin);
            pass.AppendChild(tPassword);

            user.AppendChild(login);
            user.AppendChild(pass);

            xd.DocumentElement.AppendChild(user);

            fs.Close();
            xd.Save(filepath);
        }

        private void registerbutton_Click(object sender, EventArgs e) // событие для кнопки регистрации
        {
            if (!(loginregbox.Text == "") & !(passregbox.Text == ""))
                WriteToXMLDocument(defpath, loginregbox.Text, passregbox.Text);
            else MessageBox.Show("Введите имя пользователя и пароль");
        }

        private void ReadXMLDocument(string filepath, string loget, string passget) // событие входа
        {
            string name, pwd;
            XmlDocument xd = new XmlDocument();
            FileStream fs = new FileStream(filepath, FileMode.Open);
            xd.Load(fs);
            XmlNodeList list = xd.GetElementsByTagName("user");
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement user = (XmlElement)xd.GetElementsByTagName("login")[i];
                XmlElement pass = (XmlElement)xd.GetElementsByTagName("password")[i];
                name = user.InnerText;
                pwd = pass.InnerText;
                if ((loget == name) & (passget == pwd))
                {
                    MessageBox.Show("Успешный вход");
                    break;
                }
                else if (i == list.Count - 1) MessageBox.Show("Неверный логин или пароль");
            }
            fs.Close();
        }

        private void enterbutton_Click(object sender, EventArgs e) // событие для кнопки входа
        {
            if (!(loginenbox.Text == "") & !(passenbox.Text == ""))
            {
                ReadXMLDocument(defpath, loginenbox.Text, passenbox.Text);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
