using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace HA
{
    public partial class Form2 : Form
    {
        class User
        {
            public string name;//имя и фамилия пользователя
        }

        class UserInf
        {
            public string icon;//адрес изображения
            public string name;
            public string email;
            public int unread;//кол-во непрочитанных сообщений
            public int friends;
            public float rating;//рейтинг
        }

        public Form2(string fi)
        {
            InitializeComponent();
            User user = new User() { name = fi };
            WebClient client = new WebClient();
            string url = "http://194.87.99.14/auth";
            string enterstr = JsonConvert.SerializeObject(user);
            string jwt = client.UploadString(url, enterstr);
            //Задание 2
            url = "http://194.87.99.14/user";
            string respose = client.UploadString(url, jwt);
            UserInf userInf = JsonConvert.DeserializeObject<UserInf>(respose);

            picture.ImageLocation = userInf.icon;
            messages.Text += userInf.name;
            mail.Text += userInf.email;
            raiting.Text += userInf.rating;
            countmess.Text += userInf.unread;
            friends.Text += userInf.friends;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
