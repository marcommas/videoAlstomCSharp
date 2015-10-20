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
using System.Diagnostics;
using System.Data.SqlClient;

namespace VideoAlstom
{
    public partial class Login : Form
    {

        private int idVideo, id_alps, id_usuario;
        private string sql, de_usuario, de_local_trabalho;
        private DataTable dtSelect;
        private bool terceiro = false;

        public Login(int idVideo)
        {
            InitializeComponent();

            this.idVideo = idVideo;
        }

        //QUANDO CLICADO SÓ ACEITA NUMEROS
        private void tbMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private bool obrigatorioMatricula()
        {
            string titulo = "";
            MessageBoxButtons botao = MessageBoxButtons.OK;
            if (tbMatricula.Text == "")
            {
                MessageBox.Show("O CAMPO ALPS É OBRIGATÓRIO!", titulo, botao, MessageBoxIcon.Error);
                this.ActiveControl = tbMatricula;
                return false;
            }

            return true;
        }
        
        // QUANDO CLICADO NO BOTÃO ASSISTIR
        private void btAssistir_Click(object sender, EventArgs e)
        {
            ConsultaUsuario();
        }

        //QUANDO CLICADO NO LINK DE TERCEIRO
        private void LbTerceiro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //CONFIRME SE VC EH A PESSOA
            if (MessageBox.Show("OLÁ! CONFIRME SE VOCÊ É UM TERCEIRO", "Confirmação Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //USUÁRIO 1587 ESTÁ CADASTRADADO COMO TERCEIRO
                Inserir(1587, idVideo, 0);
                MostraVideo();
                terceiro = true;
            }
            else
            {
                tbMatricula.Clear();
                this.ActiveControl = tbMatricula;
            }

        }

        private void ConsultaUsuario()
        {
            if (obrigatorioMatricula())
            {
                id_alps = Convert.ToInt32(tbMatricula.Text.ToString());

                sql = "SELECT ID_USUARIO, DE_USUARIO, ID_ALPS, CD_ESTABELECIMENTO, DE_LOCAL_TRABALHO ";
                sql += " FROM USUARIO ";
                sql += " WHERE ID_ALPS = " + id_alps +" ;";

                dtSelect = ComandoSql.Consulta(sql);
                //SE EXISTIR O USUÁRIO, ELE PEGA OS VALORES DO SELECT, INSERE NO BANCO QUE ASSISTIU E MOSTRA O VIDEO
                if (dtSelect.Rows.Count != 0)
                {
                    id_usuario = Convert.ToInt32(dtSelect.Rows[0].ItemArray[0].ToString());
                    de_usuario = dtSelect.Rows[0].ItemArray[1].ToString();
                    id_alps = Convert.ToInt32(dtSelect.Rows[0].ItemArray[2].ToString());
                    de_local_trabalho = dtSelect.Rows[0].ItemArray[3].ToString();

                    //CONFIRME SE VC EH A PESSOA
                    if (MessageBox.Show("OLÁ! CONFIRME SE VOCÊ É O USUÁRIO " + de_usuario, "Confirmação Usuário", MessageBoxButtons.YesNo,  MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Inserir(id_usuario, idVideo, id_alps);
                        MostraVideo();
                    }
                    else 
                    {
                        tbMatricula.Clear();
                        this.ActiveControl = tbMatricula;
                    }

                }
                else 
                {
                    MessageBox.Show("USUÁRIO INVÁLIDO!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbMatricula.Clear();
                    this.ActiveControl = tbMatricula;
                }
            }
        }

        private void Inserir(int id_usuario, int id_video, int id_alps)
        {
            sql = " INSERT INTO VISUALIZACAO (";
            sql += " ID_USUARIO";
            sql += " ,ID_VIDEO";
            sql += " ,ID_ALPS";
            sql += " ,DT_CADASTRO";
            sql += " )";
            sql += " VALUES";
            sql += " (";
            sql += " " + id_usuario;
            sql += "," + id_video;
            sql += "," + id_alps;
            sql += " ,GETDATE()";
            sql += " );";

            ComandoSql.Query(sql);
        }

        private void MostraVideo()
        {
            switch (idVideo)
            {                  
                case 1:
                    axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video1.mp4";                   
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;

                case 2:
                    axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video2.mp4";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;

                case 3:
                    axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video3.mp4";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;

                case 4:
                    axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video4.mp4";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;

                case 5:
                    axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video5.mp4";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;

                case 6:
                    axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video6.wmv";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;

                case 7:
                    axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video7.mp4";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;

                case 8:
                    axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video8.mp4";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;

                case 9:
                    axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video9.mp4";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;

                case 10:
                    axWindowsMediaPlayer1.URL = "C:\\videoAlstom\\video10.mp4";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;
            }
        }

      

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {

            //QUANDO VIDEO FOR PARADO
            if (  axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused )
            {
                //O VIDEO FOI PARADO, PARA CONTINUAR PRECISA CLICAR EM OK
                if ( MessageBox.Show("Video Parado. Clique aqui para continuar!", "",
                    MessageBoxButtons.OK , MessageBoxIcon.Information) == DialogResult.OK )
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }

            //QUANDO O VIDEO ACABAR
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
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
            Font FonteArialBlack11 = new System.Drawing.Font("Arial Black", 11);
            Font FonteArialBlack13 = new System.Drawing.Font("Arial Black", 13);
            Font FonteArial11 = new System.Drawing.Font("Arial", 11);

            Font FonteArial8 = new System.Drawing.Font("Arial", 8);

            //CRIA LINHA PONTILHADA
            float[] dashValues = { 5, 5, 5, 5 };
            Pen blackPen = new Pen(Color.Black, 1);
            blackPen.DashPattern = dashValues;

            //INFORMAÇÕES DO ALUNO
            g.DrawString("SEMANA INTEGRADA DA", FonteArialBlack11, Brushes.Blue, 36, 0);
            g.DrawString("QUALIDADE E SIPATMA 2015", FonteArialBlack11, Brushes.Blue, 20, 20);
            g.DrawString("'PREVENÇÃO E ATITUDE'", FonteArialBlack11, Brushes.Blue, 35, 40);


            //DEPENDENDO DO VIDEO SERÁ UMA IMPRESSÃO DIFERENTE
            switch (idVideo)
            {
                case 1:
                    g.DrawString("Video Treinamento: EPCs", FonteArialBlack11, Brushes.Blue, 0, 80);
                    g.DrawString("'SEGURANÇA PASSE ADIANTE'", FonteArialBlack11, Brushes.Blue, 0, 100);
                    break;

                case 2:
                    g.DrawString("Video Treinamento: EPCs", FonteArialBlack11, Brushes.Blue, 0, 80);
                    g.DrawString("'PREVENÇÃO DE ACIDENTES'", FonteArialBlack11, Brushes.Blue, 0, 100);
                    break;

                case 3:
                    g.DrawString("Video Treinamento: EPCs", FonteArialBlack11, Brushes.Blue, 0, 80);
                    g.DrawString("'SEGURANÇA NO TRÂNSITO'", FonteArialBlack11, Brushes.Blue, 0, 100);
                    break;

                case 4:
                    g.DrawString("Video Treinamento: EPCs", FonteArialBlack11, Brushes.Blue, 0, 80);
                    g.DrawString("'ATENÇÃO À SINALIZAÇÃO (EPCs)'", FonteArialBlack11, Brushes.Blue, 0, 100);
                    break;

                case 5:
                    g.DrawString("Video Treinamento: EPCs", FonteArialBlack11, Brushes.Blue, 0, 80);
                    g.DrawString("'SEGURANÇA NO TRANSPORTE'", FonteArialBlack11, Brushes.Blue, 0, 100);
                    break;

                case 6:
                    g.DrawString("Video Treinamento: Qualidade", FonteArialBlack11, Brushes.Blue, 0, 80);
                    g.DrawString("'CUSTO DA NÃO QUALIDADE'", FonteArialBlack11, Brushes.Blue, 0, 100);
                    break;

                case 7:
                    g.DrawString("Video Treinamento: Qualidade", FonteArialBlack11, Brushes.Blue, 0, 80);
                    g.DrawString("'FERRAMENTAS DA QUALIDADE'", FonteArialBlack11, Brushes.Blue, 0, 100);
                    break;

                case 8:
                    g.DrawString("Video Treinamento: Qualidade", FonteArialBlack11, Brushes.Blue, 0, 80);
                    g.DrawString("'MELHORIA CONTÍNUA'", FonteArialBlack11, Brushes.Blue, 0, 100);
                    break;

                case 9:
                    g.DrawString("Video Treinamento: Qualidade", FonteArialBlack11, Brushes.Blue, 0, 80);
                    g.DrawString("'LIÇÕES APRENDIDAS'", FonteArialBlack11, Brushes.Blue, 0, 100);
                    break;

                case 10:
                    g.DrawString("Video Treinamento: Qualidade", FonteArialBlack11, Brushes.Blue, 0, 80);
                    g.DrawString("'EXCELÊNCIA OPERACIONAL'", FonteArialBlack11, Brushes.Blue, 0, 100);
                    break;
            }

            //SE NÃO FOR TERICEIRO IMPRIME ISSO
            if (!terceiro)
            {
                g.DrawString("ALPS (Número do crachá): " + id_alps, FonteArial11, Brushes.Blue, 0, 140);
                g.DrawString(de_usuario, FonteArial11, Brushes.Blue, 0, 160);
            }
            else
            {
                //IMPRIME QUANDO FOR TERCEIRO
                g.DrawString("USUÁRIO: TERCEIRO", FonteArial11, Brushes.Blue, 0, 160);
            }

           
            g.DrawString("Assistido em: " + DateTime.Now, FonteArial11, Brushes.Blue, 0, 180);

            g.DrawString("GUARDE ESTE CUPOM", FonteArial8, Brushes.Blue, 73, 260);
            g.DrawString("VALE COMO ATIVIDADE EXTRA", FonteArial8, Brushes.Blue, 50, 280);
        }


    }
   
}
