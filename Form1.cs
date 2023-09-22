using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;

namespace TRPO_LR_VODA
{
    public partial class Form1 : Form
    {
        int credit;
        double litr;
        IWavePlayer waveOutDevice = new WaveOut();
        IWavePlayer waveOutDeviceS = new WaveOut();
        IWavePlayer waveOutDeviceF = new WaveOut();
        public Form1()
        {
            InitializeComponent();
            credit = 0;
            litr = 0;
            pb5done.Visible = false;
            pbbut5.Visible = false;
            b05.FlatStyle = FlatStyle.Flat;
            b1.FlatStyle = FlatStyle.Flat;
            b15.FlatStyle = FlatStyle.Flat;
            b5.FlatStyle = FlatStyle.Flat;
            b19.FlatStyle = FlatStyle.Flat;
            bstaroy.FlatStyle = FlatStyle.Flat;
            bbeztary.FlatStyle = FlatStyle.Flat;
            buttonNaliv.FlatStyle = FlatStyle.Flat;
            b05.FlatAppearance.BorderSize = 1;
            b1.FlatAppearance.BorderSize = 1;
            b15.FlatAppearance.BorderSize = 1;
            b5.FlatAppearance.BorderSize = 1;
            b19.FlatAppearance.BorderSize = 1;
            bstaroy.FlatAppearance.BorderSize = 1;
            bbeztary.FlatAppearance.BorderSize = 1;
            buttonNaliv.FlatAppearance.BorderSize = 1;
            b05.FlatAppearance.BorderColor = Color.IndianRed;
            b1.FlatAppearance.BorderColor = Color.IndianRed;
            b5.FlatAppearance.BorderColor = Color.IndianRed;
            b15.FlatAppearance.BorderColor = Color.IndianRed;
            b19.FlatAppearance.BorderColor = Color.IndianRed;
            bstaroy.FlatAppearance.BorderColor = Color.IndianRed;
            bbeztary.FlatAppearance.BorderColor = Color.IndianRed;
            buttonNaliv.FlatAppearance.BorderColor = Color.IndianRed;
            labelFakeCredit.Visible = false;
            labelCredit.Visible = false;
            pbgoodday.Visible = false;
        }

        private void pb1tab_Click(object sender, EventArgs e)
        {
            pb1tab.Visible = false;
        }

        private void b05_Click(object sender, EventArgs e)
        {
            groupBoxLitrazh.Visible = false;
            litr = 0.5;
            pbbut5.Image = Image.FromFile("D:\\Downloads\\10\\10\\05.gif");
            pb5done.Image = Image.FromFile("D:\\Downloads\\10\\10\\05d.png");
        }

        private void b15_Click(object sender, EventArgs e)
        {
            groupBoxLitrazh.Visible = false;
            litr = 1.5;
            pbbut5.Image = Image.FromFile("D:\\Downloads\\10\\10\\15.gif");
            pb5done.Image = Image.FromFile("D:\\Downloads\\10\\10\\15d.png");
        }

        private void b5_Click(object sender, EventArgs e)
        {
            groupBoxLitrazh.Visible = false;
            litr = 5;
            pbbut5.Image = Image.FromFile("D:\\Downloads\\10\\10\\5.gif");
            pb5done.Image = Image.FromFile("D:\\Downloads\\10\\10\\5d.png");
        }

        private void b1_Click(object sender, EventArgs e)
        {
            groupBoxLitrazh.Visible = false;
            litr = 1;
            pbbut5.Image = Image.FromFile("D:\\Downloads\\10\\10\\1.gif");
            pb5done.Image = Image.FromFile("D:\\Downloads\\10\\10\\1d.png");
        }

        private void b19_Click(object sender, EventArgs e)
        {
            groupBoxLitrazh.Visible = false;
            litr = 19;
            pbbut5.Image = Image.FromFile("D:\\Downloads\\10\\10\\19.gif");
            pb5done.Image = Image.FromFile("D:\\Downloads\\10\\10\\19d.png");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void bstaroy_Click(object sender, EventArgs e)
        {
            groupBoxTara.Visible = false;
            switch (litr)
            {
                case 1:
                    credit = 50; break;
                case 0.5:
                    credit = 35; break;                
                case 1.5:
                    credit = 65; break;
                case 5:
                    credit = 110; break;
                case 19:
                    credit = 250; break;
                default:
                    labelFakeCredit.Visible = true;
                    Thread.Sleep(4000);
                    exit_Click(sender, e);
                    labelFakeCredit.Visible = false;
                    break;
            }
            labelCredit.Visible = true;
            labelCredit.Text = $"Credit = {Convert.ToString(credit)}";
        }

        private void bbeztary_Click(object sender, EventArgs e)
        {
            groupBoxTara.Visible = false;
            switch (litr)
            {
                case 1:
                    credit = 35; break;
                case 0.5:
                    credit = 20; break;
                case 1.5:
                    credit = 45; break;
                case 5:
                    credit = 66; break;
                case 19:
                    credit = 95; break;
                default:
                    labelFakeCredit.Visible = true;
                    Thread.Sleep(4000);
                    exit_Click(sender, e);
                    break;
            }
            labelCredit.Visible = true;
            labelCredit.Text = $"Credit = {Convert.ToString(credit)}";
        }

        private async void pbPayCard_Click(object sender, EventArgs e)
        {
            if(credit!=0 && litr != 0)
            {
                AudioFileReader audioFileReaderS = new AudioFileReader("D:\\Downloads\\10\\10\\paysuccess.mp3");
                waveOutDeviceS.Init(audioFileReaderS);
                waveOutDeviceS.Play();
                await Task.Delay(1000);
                labelCredit.Text = "Успешно";
                waveOutDeviceS.Stop();
                audioFileReaderS.Dispose();
                waveOutDeviceS.Dispose();
                groupBoxCard.Visible = false;
            }
        }

        private async void buttonNaliv_Click(object sender, EventArgs e)
        {
            pbnaliv.Visible = false;
            AudioFileReader audioFileReaderN = new AudioFileReader("D:\\Downloads\\10\\10\\sound.mp3");
            waveOutDevice.Init(audioFileReaderN);
            waveOutDevice.Play();
            pictureBox4.Image = Image.FromFile("D:\\Downloads\\10\\10\\process.gif");
            pbbut5.Visible = true;
            labelCredit.Text = "";
            await Task.Delay(5000);
            waveOutDevice.Stop();
            audioFileReaderN.Dispose();
            waveOutDevice.Dispose();
            pbbut5.Visible = false;
            pb5done.Visible = true;
            gbprocess.Visible = false;
        }

        private async void pbwordCardError_Click(object sender, EventArgs e)
        {
            AudioFileReader audioFileReaderF = new AudioFileReader("D:\\Downloads\\10\\10\\payfail.mp3");
            waveOutDeviceF.Init(audioFileReaderF);
            waveOutDeviceF.Play();
            labelCredit.Text = "";
            labelFakeCredit.Visible = true;
            await Task.Delay(2000);
            waveOutDeviceF.Stop();
            audioFileReaderF.Dispose();
            waveOutDeviceF.Dispose();
            exit_Click(sender, e);
        }

        private async void pb5done_Click(object sender, EventArgs e)
        {
            pb5done.Visible = false;
            pbtakewater.Visible= false;
            pbgoodday.Visible = true;
            await Task.Delay(3000);
            exit_Click(sender, e);
        }
    }
}
