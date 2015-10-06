using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using AxWMPLib;

namespace VideoAlstom
{
    public partial class Login : Form
    {

        private int idVideo;

        public Login(int idVideo)
        {
            InitializeComponent();
            this.idVideo = idVideo;
        }

        private bool obrigatorioMatricula()
        {
            /*string titulo = "";
            MessageBoxButtons botao = MessageBoxButtons.OK;

            if (tbMatricula.Text == "")
            {
                MessageBox.Show("O CAMPO MATRÍCULA É OBRIGATÓRIO!", titulo, botao, MessageBoxIcon.Error);
                this.ActiveControl = tbMatricula;
                return false;
            }*/

            return true;
        }

        private void btAssistir_Click(object sender, EventArgs e)
        {
            //Esconde Janela
            //this.Hide();
            if (obrigatorioMatricula())
            {
                switch (idVideo)
                {
                    case 1:
                        axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video1.avi";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        break;

                    case 2:
                        axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video2.avi";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        break;

                    case 3:
                        axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video3.avi";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        break;

                    case 4:
                        axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video4.avi";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        break;

                    case 5:
                        axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video5.avi";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        break;

                    case 6:
                        axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video6.avi";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        break;

                    case 7:
                        axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video7.avi";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        break;

                    case 8:
                        axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video8.avi";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        break;

                    case 9:
                        axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video9.avi";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        break;

                    case 10:
                        axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video10.avi";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        break;
                }
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded )
            {
               
                MessageBox.Show("123123").ToString();
                this.Hide();
            }
        }





    }
}
