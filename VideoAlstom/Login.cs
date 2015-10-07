using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using WMPLib;
using AxWMPLib;

namespace VideoAlstom
{
    public partial class Login : Form
    {

        private int idVideo;

        private AxWindowsMediaPlayer _player;
      

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
            //QUANDO O VIDEO ESTIVER RODANDO
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //axWindowsMediaPlayer1.fullScreen = true;
                //_player.uiMode = "none";
                //axWindowsMediaPlayer1.uiMode = "none";
                //axWindowsMediaPlayer1.settings.volume = 100;
                  
            }

            //QUANDO O VIDEO ACABAR
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded )
            {
               
                //IMPRIME 
                PrintDocument document = new PrintDocument();
                document.PrintPage += new PrintPageEventHandler(impressaoConf);
                document.Print();


                this.Hide();
            }
        }

        private void impressaoConf (object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush Brush = new SolidBrush(Color.Black);
            Font FonteArialBlack = new System.Drawing.Font("Arial Black", 11);
            Font FonteArial = new System.Drawing.Font("Arial", 11);

            //CRIA LINHA PONTILHADA
            float[] dashValues = { 5, 5, 5, 5 };
            Pen blackPen = new Pen(Color.Black, 1);
            blackPen.DashPattern = dashValues;

            //INFORMAÇÕES DO ALUNO
            g.DrawString("Obrigado por assistir!", FonteArialBlack, Brushes.Blue, 0, 0);

            g.DrawString("Nome: ", FonteArialBlack, Brushes.Blue, 0, 20);
            //g.DrawLine(new Pen(Brushes.Black, 3), new Point(0, 85), new Point(830, 85));

            //DEPENDENDO DO VIDEO SERÁ UMA IMPRESSÃO DIFERENTE
            switch (idVideo)
            {
                case 1:
                    g.DrawString("Video: Video1", FonteArialBlack, Brushes.Blue, 0, 40);
                    break;

                case 2:
                    g.DrawString("Video: Video2", FonteArialBlack, Brushes.Blue, 0, 40);
                    break;

                case 3:
                    g.DrawString("Video: Video3", FonteArialBlack, Brushes.Blue, 0, 40);
                    break;

                case 4:
                    g.DrawString("Video: Video4", FonteArialBlack, Brushes.Blue, 0, 40);
                    break;

                case 5:
                    g.DrawString("Video: Video5", FonteArialBlack, Brushes.Blue, 0, 40);
                    break;

                case 6:
                    g.DrawString("Video: Video6", FonteArialBlack, Brushes.Blue, 0, 40);
                    break;

                case 7:
                    g.DrawString("Video: Video7", FonteArialBlack, Brushes.Blue, 0, 40);
                    break;

                case 8:
                    g.DrawString("Video: Video8", FonteArialBlack, Brushes.Blue, 0, 40);
                    break;

                case 9:
                    g.DrawString("Video: Video9", FonteArialBlack, Brushes.Blue, 0, 40);
                    break;

                case 10:
                    g.DrawString("Video: Video10", FonteArialBlack, Brushes.Blue, 0, 40);
                    break;
            }
            
        }




    }
}
