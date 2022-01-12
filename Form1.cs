using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getJokeBtn_Click(object sender, EventArgs e)
        {
            JokeBox.Text = GetJokes(); 
        }

        public static string GetJokes()
        {
            string url = "http://api.icndb.com/jokes/random";
            System.Net.HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                Console.WriteLine(response);
                Joke2 joke = JsonConvert.DeserializeObject<Joke2>(response);

                return joke.value.joke;
            }
        }
    }
}
