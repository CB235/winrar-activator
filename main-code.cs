using System.Net;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Winrar_Cracker



{


    public partial class Form1 : Form
    {






        public Form1()
        {
            InitializeComponent();
        }

        public Boolean x64 = true;
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//main button
        {

            if (Environment.Is64BitOperatingSystem)
            {
                x64 = true;
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://github.com/bitcookies/winrar-keygen/releases/download/v2.0.2/winrar-keygen-x64.exe", "winrarkeygen.exe");
                    
                }

                //https://github.com/bitcookies/winrar-keygen/releases/download/v2.0.2/winrar-keygen-x64.exe
            }
            else
            {
                x64 = false;
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://github.com/bitcookies/winrar-keygen/releases/download/v2.0.2/winrar-keygen-x86.exe", "winrarkeygen.exe");
                    label3.Text = "Progress: Downloading Winrar Key generator...";
                }

                //https://github.com/bitcookies/winrar-keygen/releases/download/v2.0.2/winrar-keygen-x86.exe

            }//checks to see if system is 32 or 64 bit, downloads suitable winrar keygen from github

            string field1, field2;
            var chars = "abcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[8];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            field1 = new String(stringChars);
            field2 = field1 + ".com";

            
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd ";
            startInfo.Arguments = $"/c winrarkeygen.exe \"{field1}\" \"{field2}\" > rarreg.key";
            process.StartInfo = startInfo;
            process.Start();//yay it works
            label3.Text = "Progress: Generating licence key...";



            progressBar1.Style = ProgressBarStyle.Marquee;



            //start to copy the reg key over to winrar directory
            string fileToCopy = Directory.GetCurrentDirectory()+"\\rarreg.key";
            string destinationDirectory = $"c:\\Users\\{Environment.UserName}\\AppData\\Roaming\\WinRAR\\";


            try
            {
            File.Copy(fileToCopy, destinationDirectory + Path.GetFileName(fileToCopy));
            MessageBox.Show("Winrar activation complete!");


            }
            catch (System.IO.IOException)
            {
                File.Delete(destinationDirectory + "rarreg.key");
                try
                {
                    File.Copy(fileToCopy, destinationDirectory + Path.GetFileName(fileToCopy));//completed
                    MessageBox.Show("Winrar activation complete!");
                    progressBar1.Style = ProgressBarStyle.Continuous;//signify its finished
                    progressBar1.MarqueeAnimationSpeed = 0;
                    label3.Text = "Progress: Completed!";


                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("A unexpected error occured.");//if someting goes wrong
                    return;
                }
                
            }





        }

        private void label4_Click(object sender, EventArgs e)
        {
            //debug thing becasuse cant find conasole
        }

        

        private void progressBar1_Click_1(object sender, EventArgs e)
        {
            //a
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //progress label
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/CB235/winrar-activator") { UseShellExecute = true });
            //visit winrar cracket github
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //visit bitcookies github
            Process.Start(new ProcessStartInfo("http://github.com/bitcookies") { UseShellExecute = true });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //visit cb235 github
            Process.Start(new ProcessStartInfo("http://github.com/cb235") { UseShellExecute = true });
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           Process.Start(new ProcessStartInfo("https://github.com/bitcookies/winrar-keygen") { UseShellExecute = true });//visit winrar keygen github

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
