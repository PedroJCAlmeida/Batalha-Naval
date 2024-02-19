using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace batalha_naval
{
    public partial class Form3 : Form
    {
        int qtd_encuracados = 0;
        int qtd_hidroavioes = 0;
        int qtd_cruzadores = 0;
        int qtd_submarinos = 0;
        string ocupado = "Já há uma embarcação nesse espaço";
        string erro = "Não é possível posicionar a embarção. \nO espaço que ocupa é maior que o espaço disponível";
        string erro_coordenada = "Coordenada Inválida\nInserir conforme exemplo:\n''A1''";

        string pavioes = "Porta Aviões Abatido";
        string encuracados = "Encuraçado Abatido";
        string hidroavioes = "Hidroavião Abatido";
        string cruzadores = "Cruzador Abatido";
        string submarinos = "Submarino Abatido";
        string bomba = "B O M B A ! ! !", agua = "ÁGUA";
        string venceu = "Parabéns. Ganhaste a batalha ! ! !", perdeu = "Perdeste a batalha. Tente outra vez";
        


        int qtdm_pavioes = 0, qtdj_pavieos = 0;
        int qtdm_encuracados = 0, qtdj_encuracados = 0;
        int qtdm_encuracados2 = 0, qtdj_encuracados2 = 0;
        int qtdm_hidroavioes = 0, qtdj_hidroavioes= 0;
        int qtdm_hidroavioes2 = 0, qtdj_hidroavioes2 = 0;
        int qtdm_hidroavioes3 = 0, qtdj_hidroavioes3 = 0;
        int qtdm_cruzadores = 0, qtdj_cruzadores = 0;
        int qtdm_cruzadores2 = 0, qtdj_cruzadores2 = 0;
        int qtdm_cruzadores3 = 0, qtdj_cruzadores3 = 0;
        int qtdm_submarinos = 0, qtdj_submarinos = 0;
        int qtd_ataque = 0, cont_jogada = 0;
        
        int ataque;


        public Form3()
        {
            InitializeComponent();
            btn_inicarbatalha.Visible = false;
            
        }
        public Form3(string nome_jogador)
        {
            InitializeComponent();
            lbl_jogador.Text = nome_jogador;
            btn_inicarbatalha.Visible = false;
            

        }
        public void button1_Click(object sender, EventArgs e)
        {
            tb_coordenadas.Text = tb_coordenadas.Text.ToUpper();
            if (cbx_embarcacao.SelectedItem == null)
            {
                MessageBox.Show("Escolher o tipo de embarcação");
            }
            else if(cbx_embarcacao.SelectedItem.ToString() == "Porta aviões")
            {
                
                if(tb_coordenadas.Text == "A1")
                {
                    if(lbl_a1.BackColor == Color.Black || lbl_b1.BackColor == Color.Black || lbl_c1.BackColor == Color.Black || lbl_d1.BackColor == Color.Black || lbl_e1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a1.BackColor = Color.Black;
                        lbl_b1.BackColor = Color.Black;
                        lbl_c1.BackColor = Color.Black;
                        lbl_d1.BackColor = Color.Black;
                        lbl_e1.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }                    
                }
                else if (tb_coordenadas.Text == "B1")
                {
                    if (lbl_b1.BackColor == Color.Black || lbl_c1.BackColor == Color.Black || lbl_d1.BackColor == Color.Black || lbl_e1.BackColor == Color.Black || lbl_f1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b1.BackColor = Color.Black;
                        lbl_c1.BackColor = Color.Black;
                        lbl_d1.BackColor = Color.Black;
                        lbl_e1.BackColor = Color.Black;
                        lbl_f1.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "C1")
                {
                    if (lbl_c1.BackColor == Color.Black || lbl_d1.BackColor == Color.Black || lbl_e1.BackColor == Color.Black || lbl_f1.BackColor == Color.Black || lbl_g1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c1.BackColor = Color.Black;
                        lbl_d1.BackColor = Color.Black;
                        lbl_e1.BackColor = Color.Black;
                        lbl_f1.BackColor = Color.Black;
                        lbl_g1.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }                    
                }
                else if (tb_coordenadas.Text == "D1")
                {
                    if (lbl_d1.BackColor == Color.Black || lbl_e1.BackColor == Color.Black || lbl_f1.BackColor == Color.Black || lbl_g1.BackColor == Color.Black || lbl_h1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d1.BackColor = Color.Black;
                        lbl_e1.BackColor = Color.Black;
                        lbl_f1.BackColor = Color.Black;
                        lbl_g1.BackColor = Color.Black;
                        lbl_h1.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }                    
                }
                else if (tb_coordenadas.Text == "E1")
                {
                    if (lbl_e1.BackColor == Color.Black || lbl_f1.BackColor == Color.Black || lbl_g1.BackColor == Color.Black || lbl_h1.BackColor == Color.Black || lbl_i1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e1.BackColor = Color.Black;
                        lbl_f1.BackColor = Color.Black;
                        lbl_g1.BackColor = Color.Black;
                        lbl_h1.BackColor = Color.Black;
                        lbl_i1.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }                    
                }
                else if (tb_coordenadas.Text == "F1")
                {
                    if (lbl_f1.BackColor == Color.Black || lbl_g1.BackColor == Color.Black || lbl_h1.BackColor == Color.Black || lbl_i1.BackColor == Color.Black || lbl_j1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f1.BackColor = Color.Black;
                        lbl_g1.BackColor = Color.Black;
                        lbl_h1.BackColor = Color.Black;
                        lbl_i1.BackColor = Color.Black;
                        lbl_j1.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }                    
                }
                else if (tb_coordenadas.Text == "G1" || tb_coordenadas.Text == "H1" || tb_coordenadas.Text == "I1" || tb_coordenadas.Text == "J1")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A2")
                {
                    if (lbl_a2.BackColor == Color.Black || lbl_b2.BackColor == Color.Black || lbl_c2.BackColor == Color.Black || lbl_d2.BackColor == Color.Black || lbl_e2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a2.BackColor = Color.Black;
                        lbl_b2.BackColor = Color.Black;
                        lbl_c2.BackColor = Color.Black;
                        lbl_d2.BackColor = Color.Black;
                        lbl_e2.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "B2")
                {
                    if (lbl_b2.BackColor == Color.Black || lbl_c2.BackColor == Color.Black || lbl_d2.BackColor == Color.Black || lbl_e2.BackColor == Color.Black || lbl_f2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b2.BackColor = Color.Black;
                        lbl_c2.BackColor = Color.Black;
                        lbl_d2.BackColor = Color.Black;
                        lbl_e2.BackColor = Color.Black;
                        lbl_f2.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "C2")
                {
                    if (lbl_c2.BackColor == Color.Black || lbl_d2.BackColor == Color.Black || lbl_e2.BackColor == Color.Black || lbl_f2.BackColor == Color.Black || lbl_g2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c2.BackColor = Color.Black;
                        lbl_d2.BackColor = Color.Black;
                        lbl_e2.BackColor = Color.Black;
                        lbl_f2.BackColor = Color.Black;
                        lbl_g2.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "D2")
                {
                    if (lbl_d2.BackColor == Color.Black || lbl_e2.BackColor == Color.Black || lbl_f2.BackColor == Color.Black || lbl_g2.BackColor == Color.Black || lbl_h2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d2.BackColor = Color.Black;
                        lbl_e2.BackColor = Color.Black;
                        lbl_f2.BackColor = Color.Black;
                        lbl_g2.BackColor = Color.Black;
                        lbl_h2.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "E2")
                {
                    if (lbl_e2.BackColor == Color.Black || lbl_f2.BackColor == Color.Black || lbl_g2.BackColor == Color.Black || lbl_h2.BackColor == Color.Black || lbl_i2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e2.BackColor = Color.Black;
                        lbl_f2.BackColor = Color.Black;
                        lbl_g2.BackColor = Color.Black;
                        lbl_h2.BackColor = Color.Black;
                        lbl_i2.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "F2")
                {
                    if (lbl_f2.BackColor == Color.Black || lbl_g2.BackColor == Color.Black || lbl_h2.BackColor == Color.Black || lbl_i2.BackColor == Color.Black || lbl_j2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f2.BackColor = Color.Black;
                        lbl_g2.BackColor = Color.Black;
                        lbl_h2.BackColor = Color.Black;
                        lbl_i2.BackColor = Color.Black;
                        lbl_j2.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "G2" || tb_coordenadas.Text == "H2" || tb_coordenadas.Text == "I2" || tb_coordenadas.Text == "J2")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A3")
                {
                    if (lbl_a3.BackColor == Color.Black || lbl_b3.BackColor == Color.Black || lbl_c3.BackColor == Color.Black || lbl_d3.BackColor == Color.Black || lbl_e3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a3.BackColor = Color.Black;
                        lbl_b3.BackColor = Color.Black;
                        lbl_c3.BackColor = Color.Black;
                        lbl_d3.BackColor = Color.Black;
                        lbl_e3.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "B3")
                {
                    if (lbl_b3.BackColor == Color.Black || lbl_c3.BackColor == Color.Black || lbl_d3.BackColor == Color.Black || lbl_e3.BackColor == Color.Black || lbl_f3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b3.BackColor = Color.Black;
                        lbl_c3.BackColor = Color.Black;
                        lbl_d3.BackColor = Color.Black;
                        lbl_e3.BackColor = Color.Black;
                        lbl_f3.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "C3")
                {
                    if (lbl_c3.BackColor == Color.Black || lbl_d3.BackColor == Color.Black || lbl_e3.BackColor == Color.Black || lbl_f3.BackColor == Color.Black || lbl_g3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c3.BackColor = Color.Black;
                        lbl_d3.BackColor = Color.Black;
                        lbl_e3.BackColor = Color.Black;
                        lbl_f3.BackColor = Color.Black;
                        lbl_g3.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "D3")
                {
                    if (lbl_d3.BackColor == Color.Black || lbl_e3.BackColor == Color.Black || lbl_f3.BackColor == Color.Black || lbl_g3.BackColor == Color.Black || lbl_h3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d3.BackColor = Color.Black;
                        lbl_e3.BackColor = Color.Black;
                        lbl_f3.BackColor = Color.Black;
                        lbl_g3.BackColor = Color.Black;
                        lbl_h3.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "E3")
                {
                    if (lbl_e3.BackColor == Color.Black || lbl_f3.BackColor == Color.Black || lbl_g3.BackColor == Color.Black || lbl_h3.BackColor == Color.Black || lbl_i3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e3.BackColor = Color.Black;
                        lbl_f3.BackColor = Color.Black;
                        lbl_g3.BackColor = Color.Black;
                        lbl_h3.BackColor = Color.Black;
                        lbl_i3.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "F3")
                {
                    if (lbl_f3.BackColor == Color.Black || lbl_g3.BackColor == Color.Black || lbl_h3.BackColor == Color.Black || lbl_i3.BackColor == Color.Black || lbl_j3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f3.BackColor = Color.Black;
                        lbl_g3.BackColor = Color.Black;
                        lbl_h3.BackColor = Color.Black;
                        lbl_i3.BackColor = Color.Black;
                        lbl_j3.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "G3" || tb_coordenadas.Text == "H3" || tb_coordenadas.Text == "I3" || tb_coordenadas.Text == "J3")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A4")
                {
                    if (lbl_a4.BackColor == Color.Black || lbl_b4.BackColor == Color.Black || lbl_c4.BackColor == Color.Black || lbl_d4.BackColor == Color.Black || lbl_e4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a4.BackColor = Color.Black;
                        lbl_b4.BackColor = Color.Black;
                        lbl_c4.BackColor = Color.Black;
                        lbl_d4.BackColor = Color.Black;
                        lbl_e4.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "B4")
                {
                    if (lbl_b4.BackColor == Color.Black || lbl_c4.BackColor == Color.Black || lbl_d4.BackColor == Color.Black || lbl_e4.BackColor == Color.Black || lbl_f4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b4.BackColor = Color.Black;
                        lbl_c4.BackColor = Color.Black;
                        lbl_d4.BackColor = Color.Black;
                        lbl_e4.BackColor = Color.Black;
                        lbl_f4.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "C4")
                {
                    if (lbl_c4.BackColor == Color.Black || lbl_d4.BackColor == Color.Black || lbl_e4.BackColor == Color.Black || lbl_f4.BackColor == Color.Black || lbl_g4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c4.BackColor = Color.Black;
                        lbl_d4.BackColor = Color.Black;
                        lbl_e4.BackColor = Color.Black;
                        lbl_f4.BackColor = Color.Black;
                        lbl_g4.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "D4")
                {
                    if (lbl_d4.BackColor == Color.Black || lbl_e4.BackColor == Color.Black || lbl_f4.BackColor == Color.Black || lbl_g4.BackColor == Color.Black || lbl_h4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d4.BackColor = Color.Black;
                        lbl_e4.BackColor = Color.Black;
                        lbl_f4.BackColor = Color.Black;
                        lbl_g4.BackColor = Color.Black;
                        lbl_h4.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "E4")
                {
                    if (lbl_e4.BackColor == Color.Black || lbl_f4.BackColor == Color.Black || lbl_g4.BackColor == Color.Black || lbl_h4.BackColor == Color.Black || lbl_i4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e4.BackColor = Color.Black;
                        lbl_f4.BackColor = Color.Black;
                        lbl_g4.BackColor = Color.Black;
                        lbl_h4.BackColor = Color.Black;
                        lbl_i4.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "F4")
                {
                    if (lbl_f4.BackColor == Color.Black || lbl_g4.BackColor == Color.Black || lbl_h4.BackColor == Color.Black || lbl_i4.BackColor == Color.Black || lbl_j4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f4.BackColor = Color.Black;
                        lbl_g4.BackColor = Color.Black;
                        lbl_h4.BackColor = Color.Black;
                        lbl_i4.BackColor = Color.Black;
                        lbl_j4.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "G4" || tb_coordenadas.Text == "H4" || tb_coordenadas.Text == "I4" || tb_coordenadas.Text == "J4")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A5")
                {
                    if (lbl_a5.BackColor == Color.Black || lbl_b5.BackColor == Color.Black || lbl_c5.BackColor == Color.Black || lbl_d5.BackColor == Color.Black || lbl_e5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a5.BackColor = Color.Black;
                        lbl_b5.BackColor = Color.Black;
                        lbl_c5.BackColor = Color.Black;
                        lbl_d5.BackColor = Color.Black;
                        lbl_e5.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "B5")
                {
                    if (lbl_b5.BackColor == Color.Black || lbl_c5.BackColor == Color.Black || lbl_d5.BackColor == Color.Black || lbl_e5.BackColor == Color.Black || lbl_f5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b5.BackColor = Color.Black;
                        lbl_c5.BackColor = Color.Black;
                        lbl_d5.BackColor = Color.Black;
                        lbl_e5.BackColor = Color.Black;
                        lbl_f5.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "C5")
                {
                    if (lbl_c5.BackColor == Color.Black || lbl_d5.BackColor == Color.Black || lbl_e5.BackColor == Color.Black || lbl_f5.BackColor == Color.Black || lbl_g5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c5.BackColor = Color.Black;
                        lbl_d5.BackColor = Color.Black;
                        lbl_e5.BackColor = Color.Black;
                        lbl_f5.BackColor = Color.Black;
                        lbl_g5.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "D5")
                {
                    if (lbl_d5.BackColor == Color.Black || lbl_e5.BackColor == Color.Black || lbl_f5.BackColor == Color.Black || lbl_g5.BackColor == Color.Black || lbl_h5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d5.BackColor = Color.Black;
                        lbl_e5.BackColor = Color.Black;
                        lbl_f5.BackColor = Color.Black;
                        lbl_g5.BackColor = Color.Black;
                        lbl_h5.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "E5")
                {
                    if (lbl_e5.BackColor == Color.Black || lbl_f5.BackColor == Color.Black || lbl_g5.BackColor == Color.Black || lbl_h5.BackColor == Color.Black || lbl_i5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e5.BackColor = Color.Black;
                        lbl_f5.BackColor = Color.Black;
                        lbl_g5.BackColor = Color.Black;
                        lbl_h5.BackColor = Color.Black;
                        lbl_i5.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "F5")
                {
                    if (lbl_f5.BackColor == Color.Black || lbl_g5.BackColor == Color.Black || lbl_h5.BackColor == Color.Black || lbl_i5.BackColor == Color.Black || lbl_j5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f5.BackColor = Color.Black;
                        lbl_g5.BackColor = Color.Black;
                        lbl_h5.BackColor = Color.Black;
                        lbl_i5.BackColor = Color.Black;
                        lbl_j5.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "G5" || tb_coordenadas.Text == "H5" || tb_coordenadas.Text == "I5" || tb_coordenadas.Text == "J5")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A6")
                {
                    if (lbl_a6.BackColor == Color.Black || lbl_b6.BackColor == Color.Black || lbl_c6.BackColor == Color.Black || lbl_d6.BackColor == Color.Black || lbl_e6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a6.BackColor = Color.Black;
                        lbl_b6.BackColor = Color.Black;
                        lbl_c6.BackColor = Color.Black;
                        lbl_d6.BackColor = Color.Black;
                        lbl_e6.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "B6")
                {
                    if (lbl_b6.BackColor == Color.Black || lbl_c6.BackColor == Color.Black || lbl_d6.BackColor == Color.Black || lbl_e6.BackColor == Color.Black || lbl_f6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b6.BackColor = Color.Black;
                        lbl_c6.BackColor = Color.Black;
                        lbl_d6.BackColor = Color.Black;
                        lbl_e6.BackColor = Color.Black;
                        lbl_f6.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "C6")
                {
                    if (lbl_c6.BackColor == Color.Black || lbl_d6.BackColor == Color.Black || lbl_e6.BackColor == Color.Black || lbl_f6.BackColor == Color.Black || lbl_g6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c6.BackColor = Color.Black;
                        lbl_d6.BackColor = Color.Black;
                        lbl_e6.BackColor = Color.Black;
                        lbl_f6.BackColor = Color.Black;
                        lbl_g6.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "D6")
                {
                    if (lbl_d6.BackColor == Color.Black || lbl_e6.BackColor == Color.Black || lbl_f6.BackColor == Color.Black || lbl_g6.BackColor == Color.Black || lbl_h6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d6.BackColor = Color.Black;
                        lbl_e6.BackColor = Color.Black;
                        lbl_f6.BackColor = Color.Black;
                        lbl_g6.BackColor = Color.Black;
                        lbl_h6.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "E6")
                {
                    if (lbl_e6.BackColor == Color.Black || lbl_f6.BackColor == Color.Black || lbl_g6.BackColor == Color.Black || lbl_h6.BackColor == Color.Black || lbl_i6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e6.BackColor = Color.Black;
                        lbl_f6.BackColor = Color.Black;
                        lbl_g6.BackColor = Color.Black;
                        lbl_h6.BackColor = Color.Black;
                        lbl_i6.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "F6")
                {
                    if (lbl_f6.BackColor == Color.Black || lbl_g6.BackColor == Color.Black || lbl_h6.BackColor == Color.Black || lbl_i6.BackColor == Color.Black || lbl_j6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f6.BackColor = Color.Black;
                        lbl_g6.BackColor = Color.Black;
                        lbl_h6.BackColor = Color.Black;
                        lbl_i6.BackColor = Color.Black;
                        lbl_j6.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "G6" || tb_coordenadas.Text == "H6" || tb_coordenadas.Text == "I6" || tb_coordenadas.Text == "J6")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A7")
                {
                    if (lbl_a7.BackColor == Color.Black || lbl_b7.BackColor == Color.Black || lbl_c7.BackColor == Color.Black || lbl_d7.BackColor == Color.Black || lbl_e7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a7.BackColor = Color.Black;
                        lbl_b7.BackColor = Color.Black;
                        lbl_c7.BackColor = Color.Black;
                        lbl_d7.BackColor = Color.Black;
                        lbl_e7.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "B7")
                {
                    if (lbl_b7.BackColor == Color.Black || lbl_c7.BackColor == Color.Black || lbl_d7.BackColor == Color.Black || lbl_e7.BackColor == Color.Black || lbl_f7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b7.BackColor = Color.Black;
                        lbl_c7.BackColor = Color.Black;
                        lbl_d7.BackColor = Color.Black;
                        lbl_e7.BackColor = Color.Black;
                        lbl_f7.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "C7")
                {
                    if (lbl_c7.BackColor == Color.Black || lbl_d7.BackColor == Color.Black || lbl_e7.BackColor == Color.Black || lbl_f7.BackColor == Color.Black || lbl_g7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c7.BackColor = Color.Black;
                        lbl_d7.BackColor = Color.Black;
                        lbl_e7.BackColor = Color.Black;
                        lbl_f7.BackColor = Color.Black;
                        lbl_g7.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "D7")
                {
                    if (lbl_d7.BackColor == Color.Black || lbl_e7.BackColor == Color.Black || lbl_f7.BackColor == Color.Black || lbl_g7.BackColor == Color.Black || lbl_h7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d7.BackColor = Color.Black;
                        lbl_e7.BackColor = Color.Black;
                        lbl_f7.BackColor = Color.Black;
                        lbl_g7.BackColor = Color.Black;
                        lbl_h7.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "E7")
                {
                    if (lbl_e7.BackColor == Color.Black || lbl_f7.BackColor == Color.Black || lbl_g7.BackColor == Color.Black || lbl_h7.BackColor == Color.Black || lbl_i7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e7.BackColor = Color.Black;
                        lbl_f7.BackColor = Color.Black;
                        lbl_g7.BackColor = Color.Black;
                        lbl_h7.BackColor = Color.Black;
                        lbl_i7.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "F7")
                {
                    if (lbl_f7.BackColor == Color.Black || lbl_g7.BackColor == Color.Black || lbl_h7.BackColor == Color.Black || lbl_i7.BackColor == Color.Black || lbl_j7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f7.BackColor = Color.Black;
                        lbl_g7.BackColor = Color.Black;
                        lbl_h7.BackColor = Color.Black;
                        lbl_i7.BackColor = Color.Black;
                        lbl_j7.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "G7" || tb_coordenadas.Text == "H7" || tb_coordenadas.Text == "I7" || tb_coordenadas.Text == "J7")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A8")
                {
                    if (lbl_a8.BackColor == Color.Black || lbl_b8.BackColor == Color.Black || lbl_c8.BackColor == Color.Black || lbl_d8.BackColor == Color.Black || lbl_e8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a8.BackColor = Color.Black;
                        lbl_b8.BackColor = Color.Black;
                        lbl_c8.BackColor = Color.Black;
                        lbl_d8.BackColor = Color.Black;
                        lbl_e8.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "B8")
                {
                    if (lbl_b8.BackColor == Color.Black || lbl_c8.BackColor == Color.Black || lbl_d8.BackColor == Color.Black || lbl_e8.BackColor == Color.Black || lbl_f8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b8.BackColor = Color.Black;
                        lbl_c8.BackColor = Color.Black;
                        lbl_d8.BackColor = Color.Black;
                        lbl_e8.BackColor = Color.Black;
                        lbl_f8.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "C8")
                {
                    if (lbl_c8.BackColor == Color.Black || lbl_d8.BackColor == Color.Black || lbl_e8.BackColor == Color.Black || lbl_f8.BackColor == Color.Black || lbl_g8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c8.BackColor = Color.Black;
                        lbl_d8.BackColor = Color.Black;
                        lbl_e8.BackColor = Color.Black;
                        lbl_f8.BackColor = Color.Black;
                        lbl_g8.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "D8")
                {
                    if (lbl_d8.BackColor == Color.Black || lbl_e8.BackColor == Color.Black || lbl_f8.BackColor == Color.Black || lbl_g8.BackColor == Color.Black || lbl_h8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d8.BackColor = Color.Black;
                        lbl_e8.BackColor = Color.Black;
                        lbl_f8.BackColor = Color.Black;
                        lbl_g8.BackColor = Color.Black;
                        lbl_h8.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "E8")
                {
                    if (lbl_e8.BackColor == Color.Black || lbl_f8.BackColor == Color.Black || lbl_g8.BackColor == Color.Black || lbl_h8.BackColor == Color.Black || lbl_i8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e8.BackColor = Color.Black;
                        lbl_f8.BackColor = Color.Black;
                        lbl_g8.BackColor = Color.Black;
                        lbl_h8.BackColor = Color.Black;
                        lbl_i8.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "F8")
                {
                    if (lbl_f8.BackColor == Color.Black || lbl_g8.BackColor == Color.Black || lbl_h8.BackColor == Color.Black || lbl_i8.BackColor == Color.Black || lbl_j8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f8.BackColor = Color.Black;
                        lbl_g8.BackColor = Color.Black;
                        lbl_h8.BackColor = Color.Black;
                        lbl_i8.BackColor = Color.Black;
                        lbl_j8.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "G8" || tb_coordenadas.Text == "H8" || tb_coordenadas.Text == "I8" || tb_coordenadas.Text == "J8")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A9")
                {
                    if (lbl_a9.BackColor == Color.Black || lbl_b9.BackColor == Color.Black || lbl_c9.BackColor == Color.Black || lbl_d9.BackColor == Color.Black || lbl_e9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a9.BackColor = Color.Black;
                        lbl_b9.BackColor = Color.Black;
                        lbl_c9.BackColor = Color.Black;
                        lbl_d9.BackColor = Color.Black;
                        lbl_e9.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "B9")
                {
                    if (lbl_b9.BackColor == Color.Black || lbl_c9.BackColor == Color.Black || lbl_d9.BackColor == Color.Black || lbl_e9.BackColor == Color.Black || lbl_f9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b9.BackColor = Color.Black;
                        lbl_c9.BackColor = Color.Black;
                        lbl_d9.BackColor = Color.Black;
                        lbl_e9.BackColor = Color.Black;
                        lbl_f9.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "C9")
                {
                    if (lbl_c9.BackColor == Color.Black || lbl_d9.BackColor == Color.Black || lbl_e9.BackColor == Color.Black || lbl_f9.BackColor == Color.Black || lbl_g9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c9.BackColor = Color.Black;
                        lbl_d9.BackColor = Color.Black;
                        lbl_e9.BackColor = Color.Black;
                        lbl_f9.BackColor = Color.Black;
                        lbl_g9.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "D9")
                {
                    if (lbl_d9.BackColor == Color.Black || lbl_e9.BackColor == Color.Black || lbl_f9.BackColor == Color.Black || lbl_g9.BackColor == Color.Black || lbl_h9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d9.BackColor = Color.Black;
                        lbl_e9.BackColor = Color.Black;
                        lbl_f9.BackColor = Color.Black;
                        lbl_g9.BackColor = Color.Black;
                        lbl_h9.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "E9")
                {
                    if (lbl_e9.BackColor == Color.Black || lbl_f9.BackColor == Color.Black || lbl_g9.BackColor == Color.Black || lbl_h9.BackColor == Color.Black || lbl_i9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e9.BackColor = Color.Black;
                        lbl_f9.BackColor = Color.Black;
                        lbl_g9.BackColor = Color.Black;
                        lbl_h9.BackColor = Color.Black;
                        lbl_i9.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "F9")
                {
                    if (lbl_f9.BackColor == Color.Black || lbl_g9.BackColor == Color.Black || lbl_h9.BackColor == Color.Black || lbl_i9.BackColor == Color.Black || lbl_j9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f9.BackColor = Color.Black;
                        lbl_g9.BackColor = Color.Black;
                        lbl_h9.BackColor = Color.Black;
                        lbl_i9.BackColor = Color.Black;
                        lbl_j9.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "G9" || tb_coordenadas.Text == "H9" || tb_coordenadas.Text == "I9" || tb_coordenadas.Text == "J9")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A10")
                {
                    if (lbl_a10.BackColor == Color.Black || lbl_b10.BackColor == Color.Black || lbl_c10.BackColor == Color.Black || lbl_d10.BackColor == Color.Black || lbl_e10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a10.BackColor = Color.Black;
                        lbl_b10.BackColor = Color.Black;
                        lbl_c10.BackColor = Color.Black;
                        lbl_d10.BackColor = Color.Black;
                        lbl_e10.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "B10")
                {
                    if (lbl_b10.BackColor == Color.Black || lbl_c10.BackColor == Color.Black || lbl_d10.BackColor == Color.Black || lbl_e10.BackColor == Color.Black || lbl_f10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b10.BackColor = Color.Black;
                        lbl_c10.BackColor = Color.Black;
                        lbl_d10.BackColor = Color.Black;
                        lbl_e10.BackColor = Color.Black;
                        lbl_f10.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "C10")
                {
                    if (lbl_c10.BackColor == Color.Black || lbl_d10.BackColor == Color.Black || lbl_e10.BackColor == Color.Black || lbl_f10.BackColor == Color.Black || lbl_g10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c10.BackColor = Color.Black;
                        lbl_d10.BackColor = Color.Black;
                        lbl_e10.BackColor = Color.Black;
                        lbl_f10.BackColor = Color.Black;
                        lbl_g10.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "D10")
                {
                    if (lbl_d10.BackColor == Color.Black || lbl_e10.BackColor == Color.Black || lbl_f10.BackColor == Color.Black || lbl_g10.BackColor == Color.Black || lbl_h10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d10.BackColor = Color.Black;
                        lbl_e10.BackColor = Color.Black;
                        lbl_f10.BackColor = Color.Black;
                        lbl_g10.BackColor = Color.Black;
                        lbl_h10.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "E10")
                {
                    if (lbl_e10.BackColor == Color.Black || lbl_f10.BackColor == Color.Black || lbl_g10.BackColor == Color.Black || lbl_h10.BackColor == Color.Black || lbl_i10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e10.BackColor = Color.Black;
                        lbl_f10.BackColor = Color.Black;
                        lbl_g10.BackColor = Color.Black;
                        lbl_h10.BackColor = Color.Black;
                        lbl_i10.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if (tb_coordenadas.Text == "F10")
                {
                    if (lbl_f10.BackColor == Color.Black || lbl_g10.BackColor == Color.Black || lbl_h10.BackColor == Color.Black || lbl_i10.BackColor == Color.Black || lbl_j10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f10.BackColor = Color.Black;
                        lbl_g10.BackColor = Color.Black;
                        lbl_h10.BackColor = Color.Black;
                        lbl_i10.BackColor = Color.Black;
                        lbl_j10.BackColor = Color.Black;
                        cbx_embarcacao.Items.Remove("Porta aviões");
                    }
                }
                else if(tb_coordenadas.Text == "G10" || tb_coordenadas.Text == "H10" || tb_coordenadas.Text == "I10" || tb_coordenadas.Text == "J10")
                {
                    MessageBox.Show(erro);
                }
                else
                {
                    MessageBox.Show(erro_coordenada);
                }
            }
            else if (cbx_embarcacao.SelectedItem.ToString() == "Encuraçados")
            {                              
                if (tb_coordenadas.Text == "A1")
                {
                        if (lbl_a1.BackColor == Color.Black || lbl_b1.BackColor == Color.Black || lbl_c1.BackColor == Color.Black || lbl_d1.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_a1.BackColor = Color.Black;
                            lbl_b1.BackColor = Color.Black;
                            lbl_c1.BackColor = Color.Black;
                            lbl_d1.BackColor = Color.Black;                            
                            qtd_encuracados++;
                        }
                }
                else if (tb_coordenadas.Text == "B1")
                    {
                        if (lbl_b1.BackColor == Color.Black || lbl_c1.BackColor == Color.Black || lbl_d1.BackColor == Color.Black || lbl_e1.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_b1.BackColor = Color.Black;
                            lbl_c1.BackColor = Color.Black;
                            lbl_d1.BackColor = Color.Black;
                            lbl_e1.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "C1")
                    {
                        if (lbl_c1.BackColor == Color.Black || lbl_d1.BackColor == Color.Black || lbl_e1.BackColor == Color.Black || lbl_f1.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_c1.BackColor = Color.Black;
                            lbl_d1.BackColor = Color.Black;
                            lbl_e1.BackColor = Color.Black;
                            lbl_f1.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "D1")
                    {
                        if (lbl_d1.BackColor == Color.Black || lbl_e1.BackColor == Color.Black || lbl_f1.BackColor == Color.Black || lbl_g1.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_d1.BackColor = Color.Black;
                            lbl_e1.BackColor = Color.Black;
                            lbl_f1.BackColor = Color.Black;
                            lbl_g1.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "E1")
                    {
                        if (lbl_e1.BackColor == Color.Black || lbl_f1.BackColor == Color.Black || lbl_g1.BackColor == Color.Black || lbl_h1.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_e1.BackColor = Color.Black;
                            lbl_f1.BackColor = Color.Black;
                            lbl_g1.BackColor = Color.Black;
                            lbl_h1.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "F1")
                    {
                        if (lbl_f1.BackColor == Color.Black || lbl_g1.BackColor == Color.Black || lbl_h1.BackColor == Color.Black || lbl_i1.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_f1.BackColor = Color.Black;
                            lbl_g1.BackColor = Color.Black;
                            lbl_h1.BackColor = Color.Black;
                            lbl_i1.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "G1")
                {
                    if (lbl_g1.BackColor == Color.Black || lbl_h1.BackColor == Color.Black || lbl_i1.BackColor == Color.Black || lbl_j1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {                        
                        lbl_g1.BackColor = Color.Black;
                        lbl_h1.BackColor = Color.Black;
                        lbl_i1.BackColor = Color.Black;
                        lbl_j1.BackColor = Color.Black;
                        qtd_encuracados++;
                    }
                }
                else if (tb_coordenadas.Text == "H1" || tb_coordenadas.Text == "I1" || tb_coordenadas.Text == "J1")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A2")
                    {
                        if (lbl_a2.BackColor == Color.Black || lbl_b2.BackColor == Color.Black || lbl_c2.BackColor == Color.Black || lbl_d2.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_a2.BackColor = Color.Black;
                            lbl_b2.BackColor = Color.Black;
                            lbl_c2.BackColor = Color.Black;
                            lbl_d2.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "B2")
                    {
                        if (lbl_b2.BackColor == Color.Black || lbl_c2.BackColor == Color.Black || lbl_d2.BackColor == Color.Black || lbl_e2.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_b2.BackColor = Color.Black;
                            lbl_c2.BackColor = Color.Black;
                            lbl_d2.BackColor = Color.Black;
                            lbl_e2.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "C2")
                    {
                        if (lbl_c2.BackColor == Color.Black || lbl_d2.BackColor == Color.Black || lbl_e2.BackColor == Color.Black || lbl_f2.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_c2.BackColor = Color.Black;
                            lbl_d2.BackColor = Color.Black;
                            lbl_e2.BackColor = Color.Black;
                            lbl_f2.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "D2")
                    {
                        if (lbl_d2.BackColor == Color.Black || lbl_e2.BackColor == Color.Black || lbl_f2.BackColor == Color.Black || lbl_g2.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_d2.BackColor = Color.Black;
                            lbl_e2.BackColor = Color.Black;
                            lbl_f2.BackColor = Color.Black;
                            lbl_g2.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "E2")
                    {
                        if (lbl_e2.BackColor == Color.Black || lbl_f2.BackColor == Color.Black || lbl_g2.BackColor == Color.Black || lbl_h2.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_e2.BackColor = Color.Black;
                            lbl_f2.BackColor = Color.Black;
                            lbl_g2.BackColor = Color.Black;
                            lbl_h2.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "F2")
                    {
                        if (lbl_f2.BackColor == Color.Black || lbl_g2.BackColor == Color.Black || lbl_h2.BackColor == Color.Black || lbl_i2.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_f2.BackColor = Color.Black;
                            lbl_g2.BackColor = Color.Black;
                            lbl_h2.BackColor = Color.Black;
                            lbl_i2.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "G2")
                {
                    if (lbl_g2.BackColor == Color.Black || lbl_h2.BackColor == Color.Black || lbl_i2.BackColor == Color.Black || lbl_j2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g2.BackColor = Color.Black;
                        lbl_h2.BackColor = Color.Black;
                        lbl_i2.BackColor = Color.Black;
                        lbl_j2.BackColor = Color.Black;
                        qtd_encuracados++;
                    }
                }
                else if (tb_coordenadas.Text == "H2" || tb_coordenadas.Text == "I2" || tb_coordenadas.Text == "J2")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A3")
                    {
                        if (lbl_a3.BackColor == Color.Black || lbl_b3.BackColor == Color.Black || lbl_c3.BackColor == Color.Black || lbl_d3.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_a3.BackColor = Color.Black;
                            lbl_b3.BackColor = Color.Black;
                            lbl_c3.BackColor = Color.Black;
                            lbl_d3.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "B3")
                    {
                        if (lbl_b3.BackColor == Color.Black || lbl_c3.BackColor == Color.Black || lbl_d3.BackColor == Color.Black || lbl_e3.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_b3.BackColor = Color.Black;
                            lbl_c3.BackColor = Color.Black;
                            lbl_d3.BackColor = Color.Black;
                            lbl_e3.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "C3")
                    {
                        if (lbl_c3.BackColor == Color.Black || lbl_d3.BackColor == Color.Black || lbl_e3.BackColor == Color.Black || lbl_f3.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_c3.BackColor = Color.Black;
                            lbl_d3.BackColor = Color.Black;
                            lbl_e3.BackColor = Color.Black;
                            lbl_f3.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "D3")
                    {
                        if (lbl_d3.BackColor == Color.Black || lbl_e3.BackColor == Color.Black || lbl_f3.BackColor == Color.Black || lbl_g3.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_d3.BackColor = Color.Black;
                            lbl_e3.BackColor = Color.Black;
                            lbl_f3.BackColor = Color.Black;
                            lbl_g3.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "E3")
                    {
                        if (lbl_e3.BackColor == Color.Black || lbl_f3.BackColor == Color.Black || lbl_g3.BackColor == Color.Black || lbl_h3.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_e3.BackColor = Color.Black;
                            lbl_f3.BackColor = Color.Black;
                            lbl_g3.BackColor = Color.Black;
                            lbl_h3.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "F3")
                    {
                        if (lbl_f3.BackColor == Color.Black || lbl_g3.BackColor == Color.Black || lbl_h3.BackColor == Color.Black || lbl_i3.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_f3.BackColor = Color.Black;
                            lbl_g3.BackColor = Color.Black;
                            lbl_h3.BackColor = Color.Black;
                            lbl_i3.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "G3")
                {
                    if (lbl_g3.BackColor == Color.Black || lbl_h3.BackColor == Color.Black || lbl_i3.BackColor == Color.Black || lbl_j3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g3.BackColor = Color.Black;
                        lbl_h3.BackColor = Color.Black;
                        lbl_i3.BackColor = Color.Black;
                        lbl_j3.BackColor = Color.Black;
                        qtd_encuracados++;
                    }
                }
                else if (tb_coordenadas.Text == "H3" || tb_coordenadas.Text == "I3" || tb_coordenadas.Text == "J3")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A4")
                    {
                        if (lbl_a4.BackColor == Color.Black || lbl_b4.BackColor == Color.Black || lbl_c4.BackColor == Color.Black || lbl_d4.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_a4.BackColor = Color.Black;
                            lbl_b4.BackColor = Color.Black;
                            lbl_c4.BackColor = Color.Black;
                            lbl_d4.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "B4")
                    {
                        if (lbl_b4.BackColor == Color.Black || lbl_c4.BackColor == Color.Black || lbl_d4.BackColor == Color.Black || lbl_e4.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_b4.BackColor = Color.Black;
                            lbl_c4.BackColor = Color.Black;
                            lbl_d4.BackColor = Color.Black;
                            lbl_e4.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "C4")
                    {
                        if (lbl_c4.BackColor == Color.Black || lbl_d4.BackColor == Color.Black || lbl_e4.BackColor == Color.Black || lbl_f4.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_c4.BackColor = Color.Black;
                            lbl_d4.BackColor = Color.Black;
                            lbl_e4.BackColor = Color.Black;
                            lbl_f4.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "D4")
                    {
                        if (lbl_d4.BackColor == Color.Black || lbl_e4.BackColor == Color.Black || lbl_f4.BackColor == Color.Black || lbl_g4.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_d4.BackColor = Color.Black;
                            lbl_e4.BackColor = Color.Black;
                            lbl_f4.BackColor = Color.Black;
                            lbl_g4.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "E4")
                    {
                        if (lbl_e4.BackColor == Color.Black || lbl_f4.BackColor == Color.Black || lbl_g4.BackColor == Color.Black || lbl_h4.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_e4.BackColor = Color.Black;
                            lbl_f4.BackColor = Color.Black;
                            lbl_g4.BackColor = Color.Black;
                            lbl_h4.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "F4")
                    {
                        if (lbl_f4.BackColor == Color.Black || lbl_g4.BackColor == Color.Black || lbl_h4.BackColor == Color.Black || lbl_i4.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_f4.BackColor = Color.Black;
                            lbl_g4.BackColor = Color.Black;
                            lbl_h4.BackColor = Color.Black;
                            lbl_i4.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "G4")
                {
                    if (lbl_g4.BackColor == Color.Black || lbl_h4.BackColor == Color.Black || lbl_i4.BackColor == Color.Black || lbl_j4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g4.BackColor = Color.Black;
                        lbl_h4.BackColor = Color.Black;
                        lbl_i4.BackColor = Color.Black;
                        lbl_j4.BackColor = Color.Black;
                        qtd_encuracados++;
                    }
                }
                else if (tb_coordenadas.Text == "H4" || tb_coordenadas.Text == "I4" || tb_coordenadas.Text == "J4")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A5")
                    {
                        if (lbl_a5.BackColor == Color.Black || lbl_b5.BackColor == Color.Black || lbl_c5.BackColor == Color.Black || lbl_d5.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_a5.BackColor = Color.Black;
                            lbl_b5.BackColor = Color.Black;
                            lbl_c5.BackColor = Color.Black;
                            lbl_d5.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "B5")
                    {
                        if (lbl_b5.BackColor == Color.Black || lbl_c5.BackColor == Color.Black || lbl_d5.BackColor == Color.Black || lbl_e5.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_b5.BackColor = Color.Black;
                            lbl_c5.BackColor = Color.Black;
                            lbl_d5.BackColor = Color.Black;
                            lbl_e5.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "C5")
                    {
                        if (lbl_c5.BackColor == Color.Black || lbl_d5.BackColor == Color.Black || lbl_e5.BackColor == Color.Black || lbl_f5.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_c5.BackColor = Color.Black;
                            lbl_d5.BackColor = Color.Black;
                            lbl_e5.BackColor = Color.Black;
                            lbl_f5.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "D5")
                    {
                        if (lbl_d5.BackColor == Color.Black || lbl_e5.BackColor == Color.Black || lbl_f5.BackColor == Color.Black || lbl_g5.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_d5.BackColor = Color.Black;
                            lbl_e5.BackColor = Color.Black;
                            lbl_f5.BackColor = Color.Black;
                            lbl_g5.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "E5")
                    {
                        if (lbl_e5.BackColor == Color.Black || lbl_f5.BackColor == Color.Black || lbl_g5.BackColor == Color.Black || lbl_h5.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_e5.BackColor = Color.Black;
                            lbl_f5.BackColor = Color.Black;
                            lbl_g5.BackColor = Color.Black;
                            lbl_h5.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "F5")
                    {
                        if (lbl_f5.BackColor == Color.Black || lbl_g5.BackColor == Color.Black || lbl_h5.BackColor == Color.Black || lbl_i5.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_f5.BackColor = Color.Black;
                            lbl_g5.BackColor = Color.Black;
                            lbl_h5.BackColor = Color.Black;
                            lbl_i5.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "G5")
                {
                    if (lbl_g5.BackColor == Color.Black || lbl_h5.BackColor == Color.Black || lbl_i5.BackColor == Color.Black || lbl_j5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g5.BackColor = Color.Black;
                        lbl_h5.BackColor = Color.Black;
                        lbl_i5.BackColor = Color.Black;
                        lbl_j5.BackColor = Color.Black;
                        qtd_encuracados++;
                    }
                }
                else if (tb_coordenadas.Text == "H5" || tb_coordenadas.Text == "I5" || tb_coordenadas.Text == "J5")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A6")
                    {
                        if (lbl_a6.BackColor == Color.Black || lbl_b6.BackColor == Color.Black || lbl_c6.BackColor == Color.Black || lbl_d6.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_a6.BackColor = Color.Black;
                            lbl_b6.BackColor = Color.Black;
                            lbl_c6.BackColor = Color.Black;
                            lbl_d6.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "B6")
                    {
                        if (lbl_b6.BackColor == Color.Black || lbl_c6.BackColor == Color.Black || lbl_d6.BackColor == Color.Black || lbl_e6.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_b6.BackColor = Color.Black;
                            lbl_c6.BackColor = Color.Black;
                            lbl_d6.BackColor = Color.Black;
                            lbl_e6.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "C6")
                    {
                        if (lbl_c6.BackColor == Color.Black || lbl_d6.BackColor == Color.Black || lbl_e6.BackColor == Color.Black || lbl_f6.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_c6.BackColor = Color.Black;
                            lbl_d6.BackColor = Color.Black;
                            lbl_e6.BackColor = Color.Black;
                            lbl_f6.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "D6")
                    {
                        if (lbl_d6.BackColor == Color.Black || lbl_e6.BackColor == Color.Black || lbl_f6.BackColor == Color.Black || lbl_g6.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_d6.BackColor = Color.Black;
                            lbl_e6.BackColor = Color.Black;
                            lbl_f6.BackColor = Color.Black;
                            lbl_g6.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "E6")
                    {
                        if (lbl_e6.BackColor == Color.Black || lbl_f6.BackColor == Color.Black || lbl_g6.BackColor == Color.Black || lbl_h6.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_e6.BackColor = Color.Black;
                            lbl_f6.BackColor = Color.Black;
                            lbl_g6.BackColor = Color.Black;
                            lbl_h6.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "F6")
                    {
                        if (lbl_f6.BackColor == Color.Black || lbl_g6.BackColor == Color.Black || lbl_h6.BackColor == Color.Black || lbl_i6.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_f6.BackColor = Color.Black;
                            lbl_g6.BackColor = Color.Black;
                            lbl_h6.BackColor = Color.Black;
                            lbl_i6.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "G6")
                {
                    if (lbl_g6.BackColor == Color.Black || lbl_h6.BackColor == Color.Black || lbl_i6.BackColor == Color.Black || lbl_j6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g6.BackColor = Color.Black;
                        lbl_h6.BackColor = Color.Black;
                        lbl_i6.BackColor = Color.Black;
                        lbl_j6.BackColor = Color.Black;
                        qtd_encuracados++;
                    }
                }
                else if (tb_coordenadas.Text == "H6" || tb_coordenadas.Text == "I6" || tb_coordenadas.Text == "J6")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A7")
                    {
                        if (lbl_a7.BackColor == Color.Black || lbl_b7.BackColor == Color.Black || lbl_c7.BackColor == Color.Black || lbl_d7.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_a7.BackColor = Color.Black;
                            lbl_b7.BackColor = Color.Black;
                            lbl_c7.BackColor = Color.Black;
                            lbl_d7.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "B7")
                    {
                        if (lbl_b7.BackColor == Color.Black || lbl_c7.BackColor == Color.Black || lbl_d7.BackColor == Color.Black || lbl_e7.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_b7.BackColor = Color.Black;
                            lbl_c7.BackColor = Color.Black;
                            lbl_d7.BackColor = Color.Black;
                            lbl_e7.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "C7")
                    {
                        if (lbl_c7.BackColor == Color.Black || lbl_d7.BackColor == Color.Black || lbl_e7.BackColor == Color.Black || lbl_f7.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_c7.BackColor = Color.Black;
                            lbl_d7.BackColor = Color.Black;
                            lbl_e7.BackColor = Color.Black;
                            lbl_f7.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "D7")
                    {
                        if (lbl_d7.BackColor == Color.Black || lbl_e7.BackColor == Color.Black || lbl_f7.BackColor == Color.Black || lbl_g7.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_d7.BackColor = Color.Black;
                            lbl_e7.BackColor = Color.Black;
                            lbl_f7.BackColor = Color.Black;
                            lbl_g7.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "E7")
                    {
                        if (lbl_e7.BackColor == Color.Black || lbl_f7.BackColor == Color.Black || lbl_g7.BackColor == Color.Black || lbl_h7.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_e7.BackColor = Color.Black;
                            lbl_f7.BackColor = Color.Black;
                            lbl_g7.BackColor = Color.Black;
                            lbl_h7.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "F7")
                    {
                        if (lbl_f7.BackColor == Color.Black || lbl_g7.BackColor == Color.Black || lbl_h7.BackColor == Color.Black || lbl_i7.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_f7.BackColor = Color.Black;
                            lbl_g7.BackColor = Color.Black;
                            lbl_h7.BackColor = Color.Black;
                            lbl_i7.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "G7")
                {
                    if (lbl_g7.BackColor == Color.Black || lbl_h7.BackColor == Color.Black || lbl_i7.BackColor == Color.Black || lbl_j7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g7.BackColor = Color.Black;
                        lbl_h7.BackColor = Color.Black;
                        lbl_i7.BackColor = Color.Black;
                        lbl_j7.BackColor = Color.Black;
                        qtd_encuracados++;
                    }
                }
                else if (tb_coordenadas.Text == "H7" || tb_coordenadas.Text == "I7" || tb_coordenadas.Text == "J7")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A8")
                    {
                        if (lbl_a8.BackColor == Color.Black || lbl_b8.BackColor == Color.Black || lbl_c8.BackColor == Color.Black || lbl_d8.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_a8.BackColor = Color.Black;
                            lbl_b8.BackColor = Color.Black;
                            lbl_c8.BackColor = Color.Black;
                            lbl_d8.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "B8")
                    {
                        if (lbl_b8.BackColor == Color.Black || lbl_c8.BackColor == Color.Black || lbl_d8.BackColor == Color.Black || lbl_e8.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_b8.BackColor = Color.Black;
                            lbl_c8.BackColor = Color.Black;
                            lbl_d8.BackColor = Color.Black;
                            lbl_e8.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "C8")
                    {
                        if (lbl_c8.BackColor == Color.Black || lbl_d8.BackColor == Color.Black || lbl_e8.BackColor == Color.Black || lbl_f8.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_c8.BackColor = Color.Black;
                            lbl_d8.BackColor = Color.Black;
                            lbl_e8.BackColor = Color.Black;
                            lbl_f8.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "D8")
                    {
                        if (lbl_d8.BackColor == Color.Black || lbl_e8.BackColor == Color.Black || lbl_f8.BackColor == Color.Black || lbl_g8.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_d8.BackColor = Color.Black;
                            lbl_e8.BackColor = Color.Black;
                            lbl_f8.BackColor = Color.Black;
                            lbl_g8.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "E8")
                    {
                        if (lbl_e8.BackColor == Color.Black || lbl_f8.BackColor == Color.Black || lbl_g8.BackColor == Color.Black || lbl_h8.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_e8.BackColor = Color.Black;
                            lbl_f8.BackColor = Color.Black;
                            lbl_g8.BackColor = Color.Black;
                            lbl_h8.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "F8")
                    {
                        if (lbl_f8.BackColor == Color.Black || lbl_g8.BackColor == Color.Black || lbl_h8.BackColor == Color.Black || lbl_i8.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_f8.BackColor = Color.Black;
                            lbl_g8.BackColor = Color.Black;
                            lbl_h8.BackColor = Color.Black;
                            lbl_i8.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "G8")
                {
                    if (lbl_g8.BackColor == Color.Black || lbl_h8.BackColor == Color.Black || lbl_i8.BackColor == Color.Black || lbl_j8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g8.BackColor = Color.Black;
                        lbl_h8.BackColor = Color.Black;
                        lbl_i8.BackColor = Color.Black;
                        lbl_j8.BackColor = Color.Black;
                        qtd_encuracados++;
                    }
                }
                else if (tb_coordenadas.Text == "H8" || tb_coordenadas.Text == "I8" || tb_coordenadas.Text == "J8")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A9")
                    {
                        if (lbl_a9.BackColor == Color.Black || lbl_b9.BackColor == Color.Black || lbl_c9.BackColor == Color.Black || lbl_d9.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_a9.BackColor = Color.Black;
                            lbl_b9.BackColor = Color.Black;
                            lbl_c9.BackColor = Color.Black;
                            lbl_d9.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "B9")
                    {
                        if (lbl_b9.BackColor == Color.Black || lbl_c9.BackColor == Color.Black || lbl_d9.BackColor == Color.Black || lbl_e9.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_b9.BackColor = Color.Black;
                            lbl_c9.BackColor = Color.Black;
                            lbl_d9.BackColor = Color.Black;
                            lbl_e9.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "C9")
                    {
                        if (lbl_c9.BackColor == Color.Black || lbl_d9.BackColor == Color.Black || lbl_e9.BackColor == Color.Black || lbl_f9.BackColor == Color.Black || lbl_g9.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_c9.BackColor = Color.Black;
                            lbl_d9.BackColor = Color.Black;
                            lbl_e9.BackColor = Color.Black;
                            lbl_f9.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "D9")
                    {
                        if (lbl_d9.BackColor == Color.Black || lbl_e9.BackColor == Color.Black || lbl_f9.BackColor == Color.Black || lbl_g9.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_d9.BackColor = Color.Black;
                            lbl_e9.BackColor = Color.Black;
                            lbl_f9.BackColor = Color.Black;
                            lbl_g9.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "E9")
                    {
                        if (lbl_e9.BackColor == Color.Black || lbl_f9.BackColor == Color.Black || lbl_g9.BackColor == Color.Black || lbl_h9.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_e9.BackColor = Color.Black;
                            lbl_f9.BackColor = Color.Black;
                            lbl_g9.BackColor = Color.Black;
                            lbl_h9.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "F9")
                    {
                        if (lbl_f9.BackColor == Color.Black || lbl_g9.BackColor == Color.Black || lbl_h9.BackColor == Color.Black || lbl_i9.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_f9.BackColor = Color.Black;
                            lbl_g9.BackColor = Color.Black;
                            lbl_h9.BackColor = Color.Black;
                            lbl_i9.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "G9")
                {
                    if (lbl_g9.BackColor == Color.Black || lbl_h9.BackColor == Color.Black || lbl_i9.BackColor == Color.Black || lbl_j9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g9.BackColor = Color.Black;
                        lbl_h9.BackColor = Color.Black;
                        lbl_i9.BackColor = Color.Black;
                        lbl_j9.BackColor = Color.Black;
                        qtd_encuracados++;
                    }
                }
                else if (tb_coordenadas.Text == "H9" || tb_coordenadas.Text == "I9" || tb_coordenadas.Text == "J9")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A10")
                    {
                        if (lbl_a10.BackColor == Color.Black || lbl_b10.BackColor == Color.Black || lbl_c10.BackColor == Color.Black || lbl_d10.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_a10.BackColor = Color.Black;
                            lbl_b10.BackColor = Color.Black;
                            lbl_c10.BackColor = Color.Black;
                            lbl_d10.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "B10")
                    {
                        if (lbl_b10.BackColor == Color.Black || lbl_c10.BackColor == Color.Black || lbl_d10.BackColor == Color.Black || lbl_e10.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_b10.BackColor = Color.Black;
                            lbl_c10.BackColor = Color.Black;
                            lbl_d10.BackColor = Color.Black;
                            lbl_e10.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "C10")
                    {
                        if (lbl_c10.BackColor == Color.Black || lbl_d10.BackColor == Color.Black || lbl_e10.BackColor == Color.Black || lbl_f10.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_c10.BackColor = Color.Black;
                            lbl_d10.BackColor = Color.Black;
                            lbl_e10.BackColor = Color.Black;
                            lbl_f10.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "D10")
                    {
                        if (lbl_d10.BackColor == Color.Black || lbl_e10.BackColor == Color.Black || lbl_f10.BackColor == Color.Black || lbl_g10.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_d10.BackColor = Color.Black;
                            lbl_e10.BackColor = Color.Black;
                            lbl_f10.BackColor = Color.Black;
                            lbl_g10.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "E10")
                    {
                        if (lbl_e10.BackColor == Color.Black || lbl_f10.BackColor == Color.Black || lbl_g10.BackColor == Color.Black || lbl_h10.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_e10.BackColor = Color.Black;
                            lbl_f10.BackColor = Color.Black;
                            lbl_g10.BackColor = Color.Black;
                            lbl_h10.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "F10")
                    {
                        if (lbl_f10.BackColor == Color.Black || lbl_g10.BackColor == Color.Black || lbl_h10.BackColor == Color.Black || lbl_i10.BackColor == Color.Black)
                        {
                            MessageBox.Show(ocupado);
                        }
                        else
                        {
                            lbl_f10.BackColor = Color.Black;
                            lbl_g10.BackColor = Color.Black;
                            lbl_h10.BackColor = Color.Black;
                            lbl_i10.BackColor = Color.Black;
                            qtd_encuracados++;
                        }
                    }
                else if (tb_coordenadas.Text == "G10")
                {
                    if (lbl_g10.BackColor == Color.Black || lbl_h10.BackColor == Color.Black || lbl_i10.BackColor == Color.Black || lbl_j10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g10.BackColor = Color.Black;
                        lbl_h10.BackColor = Color.Black;
                        lbl_i10.BackColor = Color.Black;
                        lbl_j10.BackColor = Color.Black;
                        qtd_encuracados++;
                    }
                }
                else if (tb_coordenadas.Text == "H10" || tb_coordenadas.Text == "I10" || tb_coordenadas.Text == "J10")
                {
                    MessageBox.Show(erro);
                }
                else
                    {
                        MessageBox.Show(erro_coordenada);
                    }
                if (qtd_encuracados == 2)
                {
                    cbx_embarcacao.Items.Remove("Encuraçados");
                }
            }
            else if (cbx_embarcacao.SelectedItem.ToString() == "Hidroaviões")
            {

                if (tb_coordenadas.Text == "A1" || tb_coordenadas.Text == "B1" || tb_coordenadas.Text == "C1" || tb_coordenadas.Text == "D1" || tb_coordenadas.Text == "E1" || tb_coordenadas.Text == "F1" || tb_coordenadas.Text == "G1" || tb_coordenadas.Text == "H1" || tb_coordenadas.Text == "I1" || tb_coordenadas.Text == "J1")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A2")
                {
                    if (lbl_a2.BackColor == Color.Black || lbl_b1.BackColor == Color.Black || lbl_c2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a2.BackColor = Color.Black;
                        lbl_b1.BackColor = Color.Black;
                        lbl_c2.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "B2")
                {
                    if (lbl_b2.BackColor == Color.Black || lbl_c1.BackColor == Color.Black || lbl_d2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b2.BackColor = Color.Black;
                        lbl_c1.BackColor = Color.Black;
                        lbl_d2.BackColor = Color.Black;
                        qtd_hidroavioes++;

                    }
                }
                else if (tb_coordenadas.Text == "C2")
                {
                    if (lbl_c2.BackColor == Color.Black || lbl_d1.BackColor == Color.Black || lbl_e2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c2.BackColor = Color.Black;
                        lbl_d1.BackColor = Color.Black;
                        lbl_e2.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "D2")
                {
                    if (lbl_d2.BackColor == Color.Black || lbl_e1.BackColor == Color.Black || lbl_f2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d2.BackColor = Color.Black;
                        lbl_e1.BackColor = Color.Black;
                        lbl_f2.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "E2")
                {
                    if (lbl_e2.BackColor == Color.Black || lbl_f1.BackColor == Color.Black || lbl_g2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e2.BackColor = Color.Black;
                        lbl_f1.BackColor = Color.Black;
                        lbl_g2.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "F2")
                {
                    if (lbl_f2.BackColor == Color.Black || lbl_g1.BackColor == Color.Black || lbl_h2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f2.BackColor = Color.Black;
                        lbl_g1.BackColor = Color.Black;
                        lbl_h2.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "G2")
                {
                    if (lbl_g2.BackColor == Color.Black || lbl_h1.BackColor == Color.Black || lbl_i2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g2.BackColor = Color.Black;
                        lbl_h1.BackColor = Color.Black;
                        lbl_i2.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "H2")
                {
                    if (lbl_h2.BackColor == Color.Black || lbl_i1.BackColor == Color.Black || lbl_j2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h2.BackColor = Color.Black;
                        lbl_i1.BackColor = Color.Black;
                        lbl_j2.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "I2" || tb_coordenadas.Text == "J2")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A3")
                {
                    if (lbl_a3.BackColor == Color.Black || lbl_b2.BackColor == Color.Black || lbl_c3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a3.BackColor = Color.Black;
                        lbl_b2.BackColor = Color.Black;
                        lbl_c3.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "B3")
                {
                    if (lbl_b3.BackColor == Color.Black || lbl_c2.BackColor == Color.Black || lbl_d3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b3.BackColor = Color.Black;
                        lbl_c2.BackColor = Color.Black;
                        lbl_d3.BackColor = Color.Black;
                        qtd_hidroavioes++;

                    }
                }
                else if (tb_coordenadas.Text == "C3")
                {
                    if (lbl_c3.BackColor == Color.Black || lbl_d2.BackColor == Color.Black || lbl_e3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c3.BackColor = Color.Black;
                        lbl_d2.BackColor = Color.Black;
                        lbl_e3.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "D3")
                {
                    if (lbl_d3.BackColor == Color.Black || lbl_e2.BackColor == Color.Black || lbl_f3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d3.BackColor = Color.Black;
                        lbl_e2.BackColor = Color.Black;
                        lbl_f3.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "E3")
                {
                    if (lbl_e3.BackColor == Color.Black || lbl_f2.BackColor == Color.Black || lbl_g3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e3.BackColor = Color.Black;
                        lbl_f2.BackColor = Color.Black;
                        lbl_g3.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "F3")
                {
                    if (lbl_f3.BackColor == Color.Black || lbl_g2.BackColor == Color.Black || lbl_h3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f3.BackColor = Color.Black;
                        lbl_g2.BackColor = Color.Black;
                        lbl_h3.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "G3")
                {
                    if (lbl_g3.BackColor == Color.Black || lbl_h2.BackColor == Color.Black || lbl_i3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g3.BackColor = Color.Black;
                        lbl_h2.BackColor = Color.Black;
                        lbl_i3.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "H3")
                {
                    if (lbl_h3.BackColor == Color.Black || lbl_i2.BackColor == Color.Black || lbl_j3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h3.BackColor = Color.Black;
                        lbl_i2.BackColor = Color.Black;
                        lbl_j3.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "I3" || tb_coordenadas.Text == "J3")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A4")
                {
                    if (lbl_a4.BackColor == Color.Black || lbl_b3.BackColor == Color.Black || lbl_c4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a4.BackColor = Color.Black;
                        lbl_b3.BackColor = Color.Black;
                        lbl_c4.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "B4")
                {
                    if (lbl_b4.BackColor == Color.Black || lbl_c3.BackColor == Color.Black || lbl_d4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b4.BackColor = Color.Black;
                        lbl_c3.BackColor = Color.Black;
                        lbl_d4.BackColor = Color.Black;
                        qtd_hidroavioes++;

                    }
                }
                else if (tb_coordenadas.Text == "C4")
                {
                    if (lbl_c4.BackColor == Color.Black || lbl_d3.BackColor == Color.Black || lbl_e4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c4.BackColor = Color.Black;
                        lbl_d3.BackColor = Color.Black;
                        lbl_e4.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "D4")
                {
                    if (lbl_d4.BackColor == Color.Black || lbl_e3.BackColor == Color.Black || lbl_f4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d4.BackColor = Color.Black;
                        lbl_e3.BackColor = Color.Black;
                        lbl_f4.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "E4")
                {
                    if (lbl_e4.BackColor == Color.Black || lbl_f3.BackColor == Color.Black || lbl_g4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e4.BackColor = Color.Black;
                        lbl_f3.BackColor = Color.Black;
                        lbl_g4.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "F4")
                {
                    if (lbl_f4.BackColor == Color.Black || lbl_g3.BackColor == Color.Black || lbl_h4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f4.BackColor = Color.Black;
                        lbl_g3.BackColor = Color.Black;
                        lbl_h4.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "G4")
                {
                    if (lbl_g4.BackColor == Color.Black || lbl_h3.BackColor == Color.Black || lbl_i4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g4.BackColor = Color.Black;
                        lbl_h3.BackColor = Color.Black;
                        lbl_i4.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "H4")
                {
                    if (lbl_h4.BackColor == Color.Black || lbl_i3.BackColor == Color.Black || lbl_j4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h4.BackColor = Color.Black;
                        lbl_i3.BackColor = Color.Black;
                        lbl_j4.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "I4" || tb_coordenadas.Text == "J4")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A5")
                {
                    if (lbl_a5.BackColor == Color.Black || lbl_b4.BackColor == Color.Black || lbl_c5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a5.BackColor = Color.Black;
                        lbl_b4.BackColor = Color.Black;
                        lbl_c5.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "B5")
                {
                    if (lbl_b5.BackColor == Color.Black || lbl_c4.BackColor == Color.Black || lbl_d5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b5.BackColor = Color.Black;
                        lbl_c4.BackColor = Color.Black;
                        lbl_d5.BackColor = Color.Black;
                        qtd_hidroavioes++;

                    }
                }
                else if (tb_coordenadas.Text == "C5")
                {
                    if (lbl_c5.BackColor == Color.Black || lbl_d4.BackColor == Color.Black || lbl_e5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c5.BackColor = Color.Black;
                        lbl_d4.BackColor = Color.Black;
                        lbl_e5.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "D5")
                {
                    if (lbl_d5.BackColor == Color.Black || lbl_e4.BackColor == Color.Black || lbl_f5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d5.BackColor = Color.Black;
                        lbl_e4.BackColor = Color.Black;
                        lbl_f5.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "E5")
                {
                    if (lbl_e5.BackColor == Color.Black || lbl_f4.BackColor == Color.Black || lbl_g5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e5.BackColor = Color.Black;
                        lbl_f4.BackColor = Color.Black;
                        lbl_g5.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "F5")
                {
                    if (lbl_f5.BackColor == Color.Black || lbl_g4.BackColor == Color.Black || lbl_h5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f5.BackColor = Color.Black;
                        lbl_g4.BackColor = Color.Black;
                        lbl_h5.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "G5")
                {
                    if (lbl_g5.BackColor == Color.Black || lbl_h4.BackColor == Color.Black || lbl_i5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g5.BackColor = Color.Black;
                        lbl_h4.BackColor = Color.Black;
                        lbl_i5.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "H5")
                {
                    if (lbl_h5.BackColor == Color.Black || lbl_i4.BackColor == Color.Black || lbl_j5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h5.BackColor = Color.Black;
                        lbl_i4.BackColor = Color.Black;
                        lbl_j5.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "I5" || tb_coordenadas.Text == "J5")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A6")
                {
                    if (lbl_a6.BackColor == Color.Black || lbl_b5.BackColor == Color.Black || lbl_c6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a6.BackColor = Color.Black;
                        lbl_b5.BackColor = Color.Black;
                        lbl_c6.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "B6")
                {
                    if (lbl_b6.BackColor == Color.Black || lbl_c5.BackColor == Color.Black || lbl_d6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b6.BackColor = Color.Black;
                        lbl_c5.BackColor = Color.Black;
                        lbl_d6.BackColor = Color.Black;
                        qtd_hidroavioes++;

                    }
                }
                else if (tb_coordenadas.Text == "C6")
                {
                    if (lbl_c6.BackColor == Color.Black || lbl_d5.BackColor == Color.Black || lbl_e6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c6.BackColor = Color.Black;
                        lbl_d5.BackColor = Color.Black;
                        lbl_e6.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "D6")
                {
                    if (lbl_d6.BackColor == Color.Black || lbl_e5.BackColor == Color.Black || lbl_f6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d6.BackColor = Color.Black;
                        lbl_e5.BackColor = Color.Black;
                        lbl_f6.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "E6")
                {
                    if (lbl_e6.BackColor == Color.Black || lbl_f5.BackColor == Color.Black || lbl_g6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e6.BackColor = Color.Black;
                        lbl_f5.BackColor = Color.Black;
                        lbl_g6.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "F6")
                {
                    if (lbl_f6.BackColor == Color.Black || lbl_g5.BackColor == Color.Black || lbl_h6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f6.BackColor = Color.Black;
                        lbl_g5.BackColor = Color.Black;
                        lbl_h6.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "G6")
                {
                    if (lbl_g6.BackColor == Color.Black || lbl_h5.BackColor == Color.Black || lbl_i6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g6.BackColor = Color.Black;
                        lbl_h5.BackColor = Color.Black;
                        lbl_i6.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "H6")
                {
                    if (lbl_h6.BackColor == Color.Black || lbl_i5.BackColor == Color.Black || lbl_j6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h6.BackColor = Color.Black;
                        lbl_i5.BackColor = Color.Black;
                        lbl_j6.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "I6" || tb_coordenadas.Text == "J6")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A7")
                {
                    if (lbl_a7.BackColor == Color.Black || lbl_b6.BackColor == Color.Black || lbl_c7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a7.BackColor = Color.Black;
                        lbl_b6.BackColor = Color.Black;
                        lbl_c7.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "B7")
                {
                    if (lbl_b7.BackColor == Color.Black || lbl_c6.BackColor == Color.Black || lbl_d7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b7.BackColor = Color.Black;
                        lbl_c6.BackColor = Color.Black;
                        lbl_d7.BackColor = Color.Black;
                        qtd_hidroavioes++;

                    }
                }
                else if (tb_coordenadas.Text == "C7")
                {
                    if (lbl_c7.BackColor == Color.Black || lbl_d6.BackColor == Color.Black || lbl_e7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c7.BackColor = Color.Black;
                        lbl_d6.BackColor = Color.Black;
                        lbl_e7.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "D7")
                {
                    if (lbl_d7.BackColor == Color.Black || lbl_e6.BackColor == Color.Black || lbl_f7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d7.BackColor = Color.Black;
                        lbl_e6.BackColor = Color.Black;
                        lbl_f7.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "E7")
                {
                    if (lbl_e7.BackColor == Color.Black || lbl_f6.BackColor == Color.Black || lbl_g7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e7.BackColor = Color.Black;
                        lbl_f6.BackColor = Color.Black;
                        lbl_g7.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "F7")
                {
                    if (lbl_f7.BackColor == Color.Black || lbl_g6.BackColor == Color.Black || lbl_h7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f7.BackColor = Color.Black;
                        lbl_g6.BackColor = Color.Black;
                        lbl_h7.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "G7")
                {
                    if (lbl_g7.BackColor == Color.Black || lbl_h6.BackColor == Color.Black || lbl_i7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g7.BackColor = Color.Black;
                        lbl_h6.BackColor = Color.Black;
                        lbl_i7.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "H7")
                {
                    if (lbl_h7.BackColor == Color.Black || lbl_i7.BackColor == Color.Black || lbl_j7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h7.BackColor = Color.Black;
                        lbl_i6.BackColor = Color.Black;
                        lbl_j7.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "I7" || tb_coordenadas.Text == "J7")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A8")
                {
                    if (lbl_a8.BackColor == Color.Black || lbl_b7.BackColor == Color.Black || lbl_c8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a8.BackColor = Color.Black;
                        lbl_b7.BackColor = Color.Black;
                        lbl_c8.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "B8")
                {
                    if (lbl_b8.BackColor == Color.Black || lbl_c7.BackColor == Color.Black || lbl_d8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b8.BackColor = Color.Black;
                        lbl_c7.BackColor = Color.Black;
                        lbl_d8.BackColor = Color.Black;
                        qtd_hidroavioes++;

                    }
                }
                else if (tb_coordenadas.Text == "C8")
                {
                    if (lbl_c8.BackColor == Color.Black || lbl_d7.BackColor == Color.Black || lbl_e8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c8.BackColor = Color.Black;
                        lbl_d7.BackColor = Color.Black;
                        lbl_e8.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "D8")
                {
                    if (lbl_d8.BackColor == Color.Black || lbl_e7.BackColor == Color.Black || lbl_f8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d8.BackColor = Color.Black;
                        lbl_e7.BackColor = Color.Black;
                        lbl_f8.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "E8")
                {
                    if (lbl_e8.BackColor == Color.Black || lbl_f7.BackColor == Color.Black || lbl_g8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e8.BackColor = Color.Black;
                        lbl_f7.BackColor = Color.Black;
                        lbl_g8.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "F8")
                {
                    if (lbl_f8.BackColor == Color.Black || lbl_g7.BackColor == Color.Black || lbl_h8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f8.BackColor = Color.Black;
                        lbl_g7.BackColor = Color.Black;
                        lbl_h8.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "G8")
                {
                    if (lbl_g8.BackColor == Color.Black || lbl_h7.BackColor == Color.Black || lbl_i8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g8.BackColor = Color.Black;
                        lbl_h7.BackColor = Color.Black;
                        lbl_i8.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "H8")
                {
                    if (lbl_h8.BackColor == Color.Black || lbl_i7.BackColor == Color.Black || lbl_j8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h8.BackColor = Color.Black;
                        lbl_i7.BackColor = Color.Black;
                        lbl_j8.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "I8" || tb_coordenadas.Text == "J8")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A9")
                {
                    if (lbl_a9.BackColor == Color.Black || lbl_b8.BackColor == Color.Black || lbl_c9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a9.BackColor = Color.Black;
                        lbl_b8.BackColor = Color.Black;
                        lbl_c9.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "B9")
                {
                    if (lbl_b9.BackColor == Color.Black || lbl_c8.BackColor == Color.Black || lbl_d9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b9.BackColor = Color.Black;
                        lbl_c8.BackColor = Color.Black;
                        lbl_d9.BackColor = Color.Black;
                        qtd_hidroavioes++;

                    }
                }
                else if (tb_coordenadas.Text == "C9")
                {
                    if (lbl_c9.BackColor == Color.Black || lbl_d8.BackColor == Color.Black || lbl_e9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c9.BackColor = Color.Black;
                        lbl_d8.BackColor = Color.Black;
                        lbl_e9.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "D9")
                {
                    if (lbl_d9.BackColor == Color.Black || lbl_e8.BackColor == Color.Black || lbl_f9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d9.BackColor = Color.Black;
                        lbl_e8.BackColor = Color.Black;
                        lbl_f9.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "E9")
                {
                    if (lbl_e9.BackColor == Color.Black || lbl_f8.BackColor == Color.Black || lbl_g9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e9.BackColor = Color.Black;
                        lbl_f8.BackColor = Color.Black;
                        lbl_g9.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "F9")
                {
                    if (lbl_f9.BackColor == Color.Black || lbl_g8.BackColor == Color.Black || lbl_h9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f9.BackColor = Color.Black;
                        lbl_g8.BackColor = Color.Black;
                        lbl_h9.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "G9")
                {
                    if (lbl_g9.BackColor == Color.Black || lbl_h8.BackColor == Color.Black || lbl_i9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g9.BackColor = Color.Black;
                        lbl_h8.BackColor = Color.Black;
                        lbl_i9.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "H9")
                {
                    if (lbl_h9.BackColor == Color.Black || lbl_i8.BackColor == Color.Black || lbl_j9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h9.BackColor = Color.Black;
                        lbl_i8.BackColor = Color.Black;
                        lbl_j9.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "I9" || tb_coordenadas.Text == "J9")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A10")
                {
                    if (lbl_a10.BackColor == Color.Black || lbl_b9.BackColor == Color.Black || lbl_c10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a10.BackColor = Color.Black;
                        lbl_b9.BackColor = Color.Black;
                        lbl_c10.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "B10")
                {
                    if (lbl_b10.BackColor == Color.Black || lbl_c9.BackColor == Color.Black || lbl_d10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b10.BackColor = Color.Black;
                        lbl_c9.BackColor = Color.Black;
                        lbl_d10.BackColor = Color.Black;
                        qtd_hidroavioes++;

                    }
                }
                else if (tb_coordenadas.Text == "C10")
                {
                    if (lbl_c10.BackColor == Color.Black || lbl_d9.BackColor == Color.Black || lbl_e10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c10.BackColor = Color.Black;
                        lbl_d9.BackColor = Color.Black;
                        lbl_e10.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "D10")
                {
                    if (lbl_d10.BackColor == Color.Black || lbl_e9.BackColor == Color.Black || lbl_f10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d10.BackColor = Color.Black;
                        lbl_e9.BackColor = Color.Black;
                        lbl_f10.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "E10")
                {
                    if (lbl_e10.BackColor == Color.Black || lbl_f9.BackColor == Color.Black || lbl_g10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e10.BackColor = Color.Black;
                        lbl_f9.BackColor = Color.Black;
                        lbl_g10.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "F10")
                {
                    if (lbl_f10.BackColor == Color.Black || lbl_g9.BackColor == Color.Black || lbl_h10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f10.BackColor = Color.Black;
                        lbl_g9.BackColor = Color.Black;
                        lbl_h10.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "G10")
                {
                    if (lbl_g10.BackColor == Color.Black || lbl_h9.BackColor == Color.Black || lbl_i10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g10.BackColor = Color.Black;
                        lbl_h9.BackColor = Color.Black;
                        lbl_i10.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "H10")
                {
                    if (lbl_h10.BackColor == Color.Black || lbl_i9.BackColor == Color.Black || lbl_j10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h10.BackColor = Color.Black;
                        lbl_i9.BackColor = Color.Black;
                        lbl_j10.BackColor = Color.Black;
                        qtd_hidroavioes++;
                    }
                }
                else if (tb_coordenadas.Text == "I10" || tb_coordenadas.Text == "J10")
                {
                    MessageBox.Show(erro);
                }
                else
                {
                    MessageBox.Show(erro_coordenada);
                }
                if (qtd_hidroavioes == 3)
                {
                    cbx_embarcacao.Items.Remove("Hidroaviões");
                }
            }
            else if (cbx_embarcacao.SelectedItem.ToString() == "Cruzadores")
            {
                if (tb_coordenadas.Text == "A1" )
                {
                    if (lbl_a1.BackColor == Color.Black || lbl_b1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a1.BackColor = Color.Black;
                        lbl_b1.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "B1")
                {
                    if (lbl_b1.BackColor == Color.Black || lbl_c1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b1.BackColor = Color.Black;
                        lbl_c1.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "C1")
                {
                    if (lbl_c1.BackColor == Color.Black || lbl_d1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c1.BackColor = Color.Black;
                        lbl_d1.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "D1")
                {
                    if (lbl_d1.BackColor == Color.Black || lbl_e1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d1.BackColor = Color.Black;
                        lbl_e1.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "E1")
                {
                    if (lbl_e1.BackColor == Color.Black || lbl_f1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e1.BackColor = Color.Black;
                        lbl_f1.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "F1")
                {
                    if (lbl_f1.BackColor == Color.Black || lbl_g1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f1.BackColor = Color.Black;
                        lbl_g1.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "G1")
                {
                    if (lbl_g1.BackColor == Color.Black || lbl_h1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g1.BackColor = Color.Black;
                        lbl_h1.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "H1")
                {
                    if (lbl_h1.BackColor == Color.Black || lbl_i1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {                        
                        lbl_h1.BackColor = Color.Black;
                        lbl_i1.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "I1")
                {
                    if (lbl_i1.BackColor == Color.Black || lbl_j1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {                       
                        lbl_i1.BackColor = Color.Black;
                        lbl_j1.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "J1")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A2")
                {
                    if (lbl_a2.BackColor == Color.Black || lbl_b2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a2.BackColor = Color.Black;
                        lbl_b2.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "B2")
                {
                    if (lbl_b2.BackColor == Color.Black || lbl_c2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b2.BackColor = Color.Black;
                        lbl_c2.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "C2")
                {
                    if (lbl_c2.BackColor == Color.Black || lbl_d2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c2.BackColor = Color.Black;
                        lbl_d2.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "D2")
                {
                    if (lbl_d2.BackColor == Color.Black || lbl_e2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d2.BackColor = Color.Black;
                        lbl_e2.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "E2")
                {
                    if (lbl_e2.BackColor == Color.Black || lbl_f2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e2.BackColor = Color.Black;
                        lbl_f2.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "F2")
                {
                    if (lbl_f2.BackColor == Color.Black || lbl_g2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f2.BackColor = Color.Black;
                        lbl_g2.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "G2")
                {
                    if (lbl_g2.BackColor == Color.Black || lbl_h2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g2.BackColor = Color.Black;
                        lbl_h2.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "H2")
                {
                    if (lbl_h2.BackColor == Color.Black || lbl_i2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h2.BackColor = Color.Black;
                        lbl_i2.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "I2")
                {
                    if (lbl_i2.BackColor == Color.Black || lbl_j2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i2.BackColor = Color.Black;
                        lbl_j2.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "J2")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A3")
                {
                    if (lbl_a3.BackColor == Color.Black || lbl_b3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a3.BackColor = Color.Black;
                        lbl_b3.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "B3")
                {
                    if (lbl_b3.BackColor == Color.Black || lbl_c3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b3.BackColor = Color.Black;
                        lbl_c3.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "C3")
                {
                    if (lbl_c3.BackColor == Color.Black || lbl_d3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c3.BackColor = Color.Black;
                        lbl_d3.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "D3")
                {
                    if (lbl_d3.BackColor == Color.Black || lbl_e3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d3.BackColor = Color.Black;
                        lbl_e3.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "E3")
                {
                    if (lbl_e3.BackColor == Color.Black || lbl_f3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e3.BackColor = Color.Black;
                        lbl_f3.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "F3")
                {
                    if (lbl_f3.BackColor == Color.Black || lbl_g3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f3.BackColor = Color.Black;
                        lbl_g3.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "G3")
                {
                    if (lbl_g3.BackColor == Color.Black || lbl_h3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g3.BackColor = Color.Black;
                        lbl_h3.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "H3")
                {
                    if (lbl_h3.BackColor == Color.Black || lbl_i3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h3.BackColor = Color.Black;
                        lbl_i3.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "I3")
                {
                    if (lbl_i3.BackColor == Color.Black || lbl_j3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i3.BackColor = Color.Black;
                        lbl_j3.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "J3")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A4")
                {
                    if (lbl_a4.BackColor == Color.Black || lbl_b4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a4.BackColor = Color.Black;
                        lbl_b4.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "B4")
                {
                    if (lbl_b4.BackColor == Color.Black || lbl_c4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b4.BackColor = Color.Black;
                        lbl_c4.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "C4")
                {
                    if (lbl_c4.BackColor == Color.Black || lbl_d4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c4.BackColor = Color.Black;
                        lbl_d4.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "D4")
                {
                    if (lbl_d4.BackColor == Color.Black || lbl_e4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d4.BackColor = Color.Black;
                        lbl_e4.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "E4")
                {
                    if (lbl_e4.BackColor == Color.Black || lbl_f4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e4.BackColor = Color.Black;
                        lbl_f4.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "F4")
                {
                    if (lbl_f4.BackColor == Color.Black || lbl_g4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f4.BackColor = Color.Black;
                        lbl_g4.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "G4")
                {
                    if (lbl_g4.BackColor == Color.Black || lbl_h4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g4.BackColor = Color.Black;
                        lbl_h4.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "H4")
                {
                    if (lbl_h4.BackColor == Color.Black || lbl_i4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h4.BackColor = Color.Black;
                        lbl_i4.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "I4")
                {
                    if (lbl_i4.BackColor == Color.Black || lbl_j4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i4.BackColor = Color.Black;
                        lbl_j4.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "J4")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A5")
                {
                    if (lbl_a5.BackColor == Color.Black || lbl_b5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a5.BackColor = Color.Black;
                        lbl_b5.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "B5")
                {
                    if (lbl_b5.BackColor == Color.Black || lbl_c5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b5.BackColor = Color.Black;
                        lbl_c5.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "C5")
                {
                    if (lbl_c5.BackColor == Color.Black || lbl_d5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c5.BackColor = Color.Black;
                        lbl_d5.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "D5")
                {
                    if (lbl_d5.BackColor == Color.Black || lbl_e5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d5.BackColor = Color.Black;
                        lbl_e5.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "E5")
                {
                    if (lbl_e5.BackColor == Color.Black || lbl_f5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e5.BackColor = Color.Black;
                        lbl_f5.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "F5")
                {
                    if (lbl_f5.BackColor == Color.Black || lbl_g5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f5.BackColor = Color.Black;
                        lbl_g5.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "G5")
                {
                    if (lbl_g5.BackColor == Color.Black || lbl_h5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g5.BackColor = Color.Black;
                        lbl_h5.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "H5")
                {
                    if (lbl_h5.BackColor == Color.Black || lbl_i5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h5.BackColor = Color.Black;
                        lbl_i5.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "I5")
                {
                    if (lbl_i5.BackColor == Color.Black || lbl_j5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i5.BackColor = Color.Black;
                        lbl_j5.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "J5")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A6")
                {
                    if (lbl_a6.BackColor == Color.Black || lbl_b6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a6.BackColor = Color.Black;
                        lbl_b6.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "B6")
                {
                    if (lbl_b6.BackColor == Color.Black || lbl_c6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b6.BackColor = Color.Black;
                        lbl_c6.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "C6")
                {
                    if (lbl_c6.BackColor == Color.Black || lbl_d6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c6.BackColor = Color.Black;
                        lbl_d6.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "D6")
                {
                    if (lbl_d6.BackColor == Color.Black || lbl_e6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d6.BackColor = Color.Black;
                        lbl_e6.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "E6")
                {
                    if (lbl_e6.BackColor == Color.Black || lbl_f6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e6.BackColor = Color.Black;
                        lbl_f6.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "F6")
                {
                    if (lbl_f6.BackColor == Color.Black || lbl_g6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f6.BackColor = Color.Black;
                        lbl_g6.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "G6")
                {
                    if (lbl_g6.BackColor == Color.Black || lbl_h6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g6.BackColor = Color.Black;
                        lbl_h6.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "H6")
                {
                    if (lbl_h6.BackColor == Color.Black || lbl_i6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h6.BackColor = Color.Black;
                        lbl_i6.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "I6")
                {
                    if (lbl_i6.BackColor == Color.Black || lbl_j6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i6.BackColor = Color.Black;
                        lbl_j6.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "J6")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A7")
                {
                    if (lbl_a7.BackColor == Color.Black || lbl_b7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a7.BackColor = Color.Black;
                        lbl_b7.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "B7")
                {
                    if (lbl_b7.BackColor == Color.Black || lbl_c7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b7.BackColor = Color.Black;
                        lbl_c7.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "C7")
                {
                    if (lbl_c7.BackColor == Color.Black || lbl_d7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c7.BackColor = Color.Black;
                        lbl_d7.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "D7")
                {
                    if (lbl_d7.BackColor == Color.Black || lbl_e7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d7.BackColor = Color.Black;
                        lbl_e7.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "E7")
                {
                    if (lbl_e7.BackColor == Color.Black || lbl_f7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e7.BackColor = Color.Black;
                        lbl_f7.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "F7")
                {
                    if (lbl_f7.BackColor == Color.Black || lbl_g7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f7.BackColor = Color.Black;
                        lbl_g7.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "G7")
                {
                    if (lbl_g7.BackColor == Color.Black || lbl_h7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g7.BackColor = Color.Black;
                        lbl_h7.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "H7")
                {
                    if (lbl_h7.BackColor == Color.Black || lbl_i7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h7.BackColor = Color.Black;
                        lbl_i7.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "I7")
                {
                    if (lbl_i7.BackColor == Color.Black || lbl_j7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i7.BackColor = Color.Black;
                        lbl_j7.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "J7")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A8")
                {
                    if (lbl_a8.BackColor == Color.Black || lbl_b8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a8.BackColor = Color.Black;
                        lbl_b8.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "B8")
                {
                    if (lbl_b8.BackColor == Color.Black || lbl_c8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b8.BackColor = Color.Black;
                        lbl_c8.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "C8")
                {
                    if (lbl_c8.BackColor == Color.Black || lbl_d8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c8.BackColor = Color.Black;
                        lbl_d8.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "D8")
                {
                    if (lbl_d8.BackColor == Color.Black || lbl_e8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d8.BackColor = Color.Black;
                        lbl_e8.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "E8")
                {
                    if (lbl_e8.BackColor == Color.Black || lbl_f8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e8.BackColor = Color.Black;
                        lbl_f8.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "F8")
                {
                    if (lbl_f8.BackColor == Color.Black || lbl_g8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f8.BackColor = Color.Black;
                        lbl_g8.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "G8")
                {
                    if (lbl_g8.BackColor == Color.Black || lbl_h8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g8.BackColor = Color.Black;
                        lbl_h8.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "H8")
                {
                    if (lbl_h8.BackColor == Color.Black || lbl_i8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h8.BackColor = Color.Black;
                        lbl_i8.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "I8")
                {
                    if (lbl_i8.BackColor == Color.Black || lbl_j8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i8.BackColor = Color.Black;
                        lbl_j8.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "J8")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A9")
                {
                    if (lbl_a9.BackColor == Color.Black || lbl_b9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a9.BackColor = Color.Black;
                        lbl_b9.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "B9")
                {
                    if (lbl_b9.BackColor == Color.Black || lbl_c9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b9.BackColor = Color.Black;
                        lbl_c9.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "C9")
                {
                    if (lbl_c9.BackColor == Color.Black || lbl_d9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c9.BackColor = Color.Black;
                        lbl_d9.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "D9")
                {
                    if (lbl_d9.BackColor == Color.Black || lbl_e9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d9.BackColor = Color.Black;
                        lbl_e9.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "E9")
                {
                    if (lbl_e9.BackColor == Color.Black || lbl_f9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e9.BackColor = Color.Black;
                        lbl_f9.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "F9")
                {
                    if (lbl_f9.BackColor == Color.Black || lbl_g9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f9.BackColor = Color.Black;
                        lbl_g9.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "G9")
                {
                    if (lbl_g9.BackColor == Color.Black || lbl_h9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g9.BackColor = Color.Black;
                        lbl_h9.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "H9")
                {
                    if (lbl_h9.BackColor == Color.Black || lbl_i9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h9.BackColor = Color.Black;
                        lbl_i9.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "I9")
                {
                    if (lbl_i9.BackColor == Color.Black || lbl_j9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i9.BackColor = Color.Black;
                        lbl_j9.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "J9")
                {
                    MessageBox.Show(erro);
                }
                else if (tb_coordenadas.Text == "A10")
                {
                    if (lbl_a10.BackColor == Color.Black || lbl_b10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a10.BackColor = Color.Black;
                        lbl_b10.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "B10")
                {
                    if (lbl_b10.BackColor == Color.Black || lbl_c10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b10.BackColor = Color.Black;
                        lbl_c10.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "C10")
                {
                    if (lbl_c10.BackColor == Color.Black || lbl_d10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c10.BackColor = Color.Black;
                        lbl_d10.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "D10")
                {
                    if (lbl_d10.BackColor == Color.Black || lbl_e10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d10.BackColor = Color.Black;
                        lbl_e10.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "E10")
                {
                    if (lbl_e10.BackColor == Color.Black || lbl_f10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e10.BackColor = Color.Black;
                        lbl_f10.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "F10")
                {
                    if (lbl_f10.BackColor == Color.Black || lbl_g10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f10.BackColor = Color.Black;
                        lbl_g10.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "G10")
                {
                    if (lbl_g10.BackColor == Color.Black || lbl_h10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g10.BackColor = Color.Black;
                        lbl_h10.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "H10")
                {
                    if (lbl_h10.BackColor == Color.Black || lbl_i10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h10.BackColor = Color.Black;
                        lbl_i10.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "I10")
                {
                    if (lbl_i10.BackColor == Color.Black || lbl_j10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i10.BackColor = Color.Black;
                        lbl_j10.BackColor = Color.Black;
                        qtd_cruzadores++;
                    }
                }
                else if (tb_coordenadas.Text == "J10")
                {
                    MessageBox.Show(erro);
                }
                else
                {
                    MessageBox.Show(erro_coordenada);
                }
                if (qtd_cruzadores == 3)
                {
                    cbx_embarcacao.Items.Remove("Cruzadores");
                }
            }
            else if (cbx_embarcacao.SelectedItem.ToString() == "Submarinos")
            {
                if (tb_coordenadas.Text == "A1")
                {
                    if (lbl_a1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a1.BackColor = Color.Black;                        
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "B1")
                {
                    if (lbl_b1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b1.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "C1")
                {
                    if (lbl_c1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c1.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "D1")
                {
                    if (lbl_d1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d1.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "E1")
                {
                    if (lbl_e1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e1.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "F1")
                {
                    if (lbl_f1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f1.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "G1")
                {
                    if (lbl_g1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g1.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "H1")
                {
                    if (lbl_h1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h1.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "I1")
                {
                    if (lbl_i1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i1.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "J1")
                {
                    if (lbl_j1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_j1.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "A2")
                {
                    if (lbl_a2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a2.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "B2")
                {
                    if (lbl_b2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b2.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "C2")
                {
                    if (lbl_c2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c2.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "D2")
                {
                    if (lbl_d2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d2.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "E2")
                {
                    if (lbl_e2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e2.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "F2")
                {
                    if (lbl_f2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f2.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "G2")
                {
                    if (lbl_g2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g2.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "H2")
                {
                    if (lbl_h2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h2.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "I2")
                {
                    if (lbl_i2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i2.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "J2")
                {
                    if (lbl_j2.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_j2.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "A3")
                {
                    if (lbl_a3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a3.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "B3")
                {
                    if (lbl_b3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b3.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "C3")
                {
                    if (lbl_c3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c3.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "D3")
                {
                    if (lbl_d3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d3.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "E3")
                {
                    if (lbl_e3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e3.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "F3")
                {
                    if (lbl_f3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f3.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "G3")
                {
                    if (lbl_g3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g3.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "H3")
                {
                    if (lbl_h3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h3.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "I3")
                {
                    if (lbl_i3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i3.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "J3")
                {
                    if (lbl_j3.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_j3.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "A4")
                {
                    if (lbl_a4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a4.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "B4")
                {
                    if (lbl_b4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b4.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "C4")
                {
                    if (lbl_c4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c4.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "D4")
                {
                    if (lbl_d4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d4.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "E4")
                {
                    if (lbl_e4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e4.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "F4")
                {
                    if (lbl_f4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f4.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "G4")
                {
                    if (lbl_g4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g4.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "H4")
                {
                    if (lbl_h4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h4.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "I4")
                {
                    if (lbl_i4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i4.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "J4")
                {
                    if (lbl_j4.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_j4.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "A5")
                {
                    if (lbl_a5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a5.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "B5")
                {
                    if (lbl_b5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b5.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "C5")
                {
                    if (lbl_c5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c5.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "D5")
                {
                    if (lbl_d5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d5.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "E5")
                {
                    if (lbl_e5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e5.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "F5")
                {
                    if (lbl_f1.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f5.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "G5")
                {
                    if (lbl_g5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g5.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "H5")
                {
                    if (lbl_h5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h5.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "I5")
                {
                    if (lbl_i5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i5.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "J5")
                {
                    if (lbl_j5.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_j5.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "A6")
                {
                    if (lbl_a6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a6.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "B6")
                {
                    if (lbl_b6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b6.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "C6")
                {
                    if (lbl_c6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c6.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "D6")
                {
                    if (lbl_d6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d6.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "E6")
                {
                    if (lbl_e6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e6.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "F6")
                {
                    if (lbl_f6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f6.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "G6")
                {
                    if (lbl_g6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g6.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "H6")
                {
                    if (lbl_h6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h6.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "I6")
                {
                    if (lbl_i6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i6.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "J6")
                {
                    if (lbl_j6.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_j6.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "A7")
                {
                    if (lbl_a7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a7.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "B7")
                {
                    if (lbl_b7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b7.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "C7")
                {
                    if (lbl_c7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c7.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "D7")
                {
                    if (lbl_d7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d7.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "E7")
                {
                    if (lbl_e7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e7.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "F7")
                {
                    if (lbl_f7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f7.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "G7")
                {
                    if (lbl_g7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g7.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "H7")
                {
                    if (lbl_h7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h7.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "I7")
                {
                    if (lbl_i7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i7.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "J7")
                {
                    if (lbl_j7.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_j7.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "A8")
                {
                    if (lbl_a8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a8.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "B8")
                {
                    if (lbl_b8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b8.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "C8")
                {
                    if (lbl_c8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c8.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "D8")
                {
                    if (lbl_d8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d8.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "E8")
                {
                    if (lbl_e8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e8.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "F8")
                {
                    if (lbl_f8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f8.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "G8")
                {
                    if (lbl_g8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g8.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "H8")
                {
                    if (lbl_h8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h8.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "I8")
                {
                    if (lbl_i8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i8.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "J8")
                {
                    if (lbl_j8.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_j8.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "A9")
                {
                    if (lbl_a9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a9.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "B9")
                {
                    if (lbl_b9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b9.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "C9")
                {
                    if (lbl_c9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c9.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "D9")
                {
                    if (lbl_d9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d9.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "E9")
                {
                    if (lbl_e9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e9.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "F9")
                {
                    if (lbl_f9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f9.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "G9")
                {
                    if (lbl_g9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g9.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "H9")
                {
                    if (lbl_h9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h9.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "I9")
                {
                    if (lbl_i9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i9.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "J9")
                {
                    if (lbl_j9.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_j9.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "A10")
                {
                    if (lbl_a10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_a10.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "B10")
                {
                    if (lbl_b10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_b10.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "C10")
                {
                    if (lbl_c10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_c10.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "D10")
                {
                    if (lbl_d10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_d10.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "E10")
                {
                    if (lbl_e10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_e10.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "F10")
                {
                    if (lbl_f10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_f10.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "G10")
                {
                    if (lbl_g10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_g10.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "H10")
                {
                    if (lbl_h10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_h10.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "I10")
                {
                    if (lbl_i10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_i10.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else if (tb_coordenadas.Text == "J10")
                {
                    if (lbl_j10.BackColor == Color.Black)
                    {
                        MessageBox.Show(ocupado);
                    }
                    else
                    {
                        lbl_j10.BackColor = Color.Black;
                        qtd_submarinos++;
                    }
                }

                else
                {
                    MessageBox.Show(erro);
                }
                if (qtd_submarinos == 4)
                {
                    cbx_embarcacao.Items.Remove("Submarinos");
                }


            }

            if(cbx_embarcacao.Items.Count == 0)
            {
                MessageBox.Show("Todas embarcações estão posicionadas. Inicie a batalha");
                cbx_embarcacao.Visible = false;
                button1.Visible = false;
                btn_inicarbatalha.Enabled = true;
                btn_inicarbatalha.Visible = true;
                lbl_embarcacao.Text = "Coordenadas";
                lbl_coordenadas.Text = "de ataque";
                btn_inicarbatalha.Text = "F O G O ! ! !";

            }
        }
        public void btn_inicarbatalha_Click(object sender, EventArgs e)
        {
            tb_coordenadas.Text = tb_coordenadas.Text.ToUpper();
            // Ataque Jogador
            if (tb_coordenadas.Text == "D1")
            {
                MessageBox.Show(bomba);
                lbl_d11.BackColor = Color.Red;
                qtdm_pavioes++;
                if(qtdm_pavioes == 5)
                {
                    MessageBox.Show(pavioes);
                    ckb_pavioesm.Checked = true;
                }
            }            
            else if (tb_coordenadas.Text == "E1")
            {
                MessageBox.Show(bomba);
                lbl_e11.BackColor = Color.Red;
                qtdm_pavioes++;
                if (qtdm_pavioes == 5)
                {
                    MessageBox.Show(pavioes);
                    ckb_pavioesm.Checked = true;
                }
            }
            else if (tb_coordenadas.Text == "F1")
            {
                MessageBox.Show(bomba);
                lbl_f11.BackColor = Color.Red;
                qtdm_pavioes++;
                if (qtdm_pavioes == 5)
                {
                    MessageBox.Show(pavioes);
                    ckb_pavioesm.Checked = true;
                }
            }
            else if (tb_coordenadas.Text == "G1")
            {
                MessageBox.Show(bomba);
                lbl_g11.BackColor = Color.Red;
                qtdm_pavioes++;
                if (qtdm_pavioes == 5)
                {
                    MessageBox.Show(pavioes);
                    ckb_pavioesm.Checked = true;
                }
            }
            else if (tb_coordenadas.Text == "H1")
            {
                MessageBox.Show(bomba);
                lbl_h11.BackColor = Color.Red;
                qtdm_pavioes++;
                if (qtdm_pavioes == 5)
                {
                    MessageBox.Show(pavioes);
                    ckb_pavioesm.Checked = true;
                }
            }
            else if (tb_coordenadas.Text == "C3")
            {
                MessageBox.Show(bomba);
                lbl_c31.BackColor = Color.Red;
                qtdm_encuracados++;
                if (qtdm_encuracados == 4)
                {
                    MessageBox.Show(encuracados);
                    if(qtdm_encuracados == 4 && qtdm_encuracados2 == 4)
                    {
                        ckb_encuracadosm.Checked = true;
                    }                    
                }
            }
            else if (tb_coordenadas.Text == "D3")
            {
                MessageBox.Show(bomba);
                lbl_d31.BackColor = Color.Red;
                qtdm_encuracados++;
                if (qtdm_encuracados == 4)
                {
                    MessageBox.Show(encuracados);
                    if (qtdm_encuracados == 4 && qtdm_encuracados2 == 4)
                    {
                        ckb_encuracadosm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "E3")
            {
                MessageBox.Show(bomba);
                lbl_e31.BackColor = Color.Red;
                qtdm_encuracados++;
                if (qtdm_encuracados == 4)
                {
                    MessageBox.Show(encuracados);
                    if (qtdm_encuracados == 4 && qtdm_encuracados2 == 4)
                    {
                        ckb_encuracadosm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "B3")
            {
                MessageBox.Show(bomba);
                lbl_b31.BackColor = Color.Red;
                qtdm_encuracados++;
                if (qtdm_encuracados == 4)
                {
                    MessageBox.Show(encuracados);
                    if (qtdm_encuracados == 4 && qtdm_encuracados2 == 4)
                    {
                        ckb_encuracadosm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "F7")
            {
                MessageBox.Show(bomba);
                lbl_f71.BackColor = Color.Red;
                qtdm_encuracados2++;
                if (qtdm_encuracados2 == 4)
                {
                    MessageBox.Show(encuracados);
                    if (qtdm_encuracados == 4 && qtdm_encuracados2 == 4)
                    {
                        ckb_encuracadosm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "G7")
            {
                MessageBox.Show(bomba);
                lbl_g71.BackColor = Color.Red;
                qtdm_encuracados2++;
                if (qtdm_encuracados2 == 4)
                {
                    MessageBox.Show(encuracados);
                    if (qtdm_encuracados == 4 && qtdm_encuracados2 == 4)
                    {
                        ckb_encuracadosm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "H7")
            {
                MessageBox.Show(bomba);
                lbl_h71.BackColor = Color.Red;
                qtdm_encuracados2++;
                if (qtdm_encuracados2 == 4)
                {
                    MessageBox.Show(encuracados);
                    if (qtdm_encuracados == 4 && qtdm_encuracados2 == 4)
                    {
                        ckb_encuracadosm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "I7")
            {
                MessageBox.Show(bomba);
                lbl_i71.BackColor = Color.Red;
                qtdm_encuracados2++;
                if (qtdm_encuracados2 == 4)
                {
                    MessageBox.Show(encuracados);
                    if (qtdm_encuracados == 4 && qtdm_encuracados2 == 4)
                    {
                        ckb_encuracadosm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "A6")
            {
                MessageBox.Show(bomba);
                lbl_a61.BackColor = Color.Red;
                qtdm_hidroavioes++;
                if (qtdm_hidroavioes == 3)
                {
                    MessageBox.Show(hidroavioes);
                    if (qtdm_hidroavioes == 3 && qtdm_hidroavioes2 == 3 && qtdm_hidroavioes3 == 3)
                    {
                        ckb_hidroavioesm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "B5")
            {
                MessageBox.Show(bomba);
                lbl_b51.BackColor = Color.Red;
                qtdm_hidroavioes++;
                if (qtdm_hidroavioes == 3)
                {
                    MessageBox.Show(hidroavioes);
                    if (qtdm_hidroavioes == 3 && qtdm_hidroavioes2 == 3 && qtdm_hidroavioes3 == 3)
                    {
                        ckb_hidroavioesm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "C6")
            {
                MessageBox.Show(bomba);
                lbl_c61.BackColor = Color.Red;
                qtdm_hidroavioes++;
                if (qtdm_hidroavioes == 3)
                {
                    MessageBox.Show(hidroavioes);
                    if (qtdm_hidroavioes == 3 && qtdm_hidroavioes2 == 3 && qtdm_hidroavioes3 == 3)
                    {
                        ckb_hidroavioesm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "C9")
            {
                MessageBox.Show(bomba);
                lbl_c91.BackColor = Color.Red;
                qtdm_hidroavioes2++;
                if (qtdm_hidroavioes2 == 3)
                {
                    MessageBox.Show(hidroavioes);
                    if (qtdm_hidroavioes == 3 && qtdm_hidroavioes2 == 3 && qtdm_hidroavioes3 == 3)
                    {
                        ckb_hidroavioesm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "D8")
            {
                MessageBox.Show(bomba);
                lbl_d81.BackColor = Color.Red;
                qtdm_hidroavioes2++;
                if (qtdm_hidroavioes2 == 3)
                {
                    MessageBox.Show(hidroavioes);
                    if (qtdm_hidroavioes == 3 && qtdm_hidroavioes2 == 3 && qtdm_hidroavioes3 == 3)
                    {
                        ckb_hidroavioesm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "E9")
            {
                MessageBox.Show(bomba);
                lbl_e91.BackColor = Color.Red;
                qtdm_hidroavioes2++;
                if (qtdm_hidroavioes2 == 3)
                {
                    MessageBox.Show(hidroavioes);
                    if (qtdm_hidroavioes == 3 && qtdm_hidroavioes2 == 3 && qtdm_hidroavioes3 == 3)
                    {
                        ckb_hidroavioesm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "F5")
            {
                MessageBox.Show(bomba);
                lbl_f51.BackColor = Color.Red;
                qtdm_hidroavioes3++;
                if (qtdm_hidroavioes3 == 3)
                {
                    MessageBox.Show(hidroavioes);
                    if (qtdm_hidroavioes == 3 && qtdm_hidroavioes2 == 3 && qtdm_hidroavioes3 == 3)
                    {
                        ckb_hidroavioesm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "G4")
            {
                MessageBox.Show(bomba);
                lbl_g41.BackColor = Color.Red;
                qtdm_hidroavioes3++;
                if (qtdm_hidroavioes3 == 3)
                {
                    MessageBox.Show(hidroavioes);
                    if (qtdm_hidroavioes == 3 && qtdm_hidroavioes2 == 3 && qtdm_hidroavioes3 == 3)
                    {
                        ckb_hidroavioesm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "H5")
            {
                MessageBox.Show(bomba);
                lbl_h51.BackColor = Color.Red;
                qtdm_hidroavioes3++;
                if (qtdm_hidroavioes3 == 3)
                {
                    MessageBox.Show(hidroavioes);
                    if (qtdm_hidroavioes == 3 && qtdm_hidroavioes2 == 3 && qtdm_hidroavioes3 == 3)
                    {
                        ckb_hidroavioesm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "A2")
            {
                MessageBox.Show(bomba);
                lbl_a21.BackColor = Color.Red;
                qtdm_cruzadores++;
                if (qtdm_cruzadores == 2)
                {
                    MessageBox.Show(cruzadores);
                    if (qtdm_cruzadores == 2 && qtdm_cruzadores2 == 2 && qtdm_cruzadores3 == 2)
                    {
                        ckb_cruzadoresm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "B2")
            {
                MessageBox.Show(bomba);
                lbl_b21.BackColor = Color.Red;
                qtdm_cruzadores++;
                if (qtdm_cruzadores == 2)
                {
                    MessageBox.Show(cruzadores);
                    if (qtdm_cruzadores == 2 && qtdm_cruzadores2 == 2 && qtdm_cruzadores3 == 2)
                    {
                        ckb_cruzadoresm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "C4")
            {
                MessageBox.Show(bomba);
                lbl_c41.BackColor = Color.Red;
                qtdm_cruzadores2++;
                if (qtdm_cruzadores2 == 2)
                {
                    MessageBox.Show(cruzadores);
                    if (qtdm_cruzadores == 2 && qtdm_cruzadores2 == 2 && qtdm_cruzadores3 == 2)
                    {
                        ckb_cruzadoresm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "D4")
            {
                MessageBox.Show(bomba);
                lbl_d41.BackColor = Color.Red;
                qtdm_cruzadores2++;
                if (qtdm_cruzadores2 == 2)
                {
                    MessageBox.Show(cruzadores);
                    if (qtdm_cruzadores == 2 && qtdm_cruzadores2 == 2 && qtdm_cruzadores3 == 2)
                    {
                        ckb_cruzadoresm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "I10")
            {
                MessageBox.Show(bomba);
                lbl_i101.BackColor = Color.Red;
                qtdm_cruzadores3++;
                if (qtdm_cruzadores3 == 2)
                {
                    MessageBox.Show(cruzadores);
                    if (qtdm_cruzadores == 2 && qtdm_cruzadores2 == 2 && qtdm_cruzadores3 == 2)
                    {
                        ckb_cruzadoresm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "J10")
            {
                MessageBox.Show(bomba);
                lbl_j101.BackColor = Color.Red;
                qtdm_cruzadores3++;
                if (qtdm_cruzadores3 == 2)
                {
                    MessageBox.Show(cruzadores);
                    if (qtdm_cruzadores == 2 && qtdm_cruzadores2 == 2 && qtdm_cruzadores3 == 2)
                    {
                        ckb_cruzadoresm.Checked = true;
                    }
                }
            }
            else if (tb_coordenadas.Text == "B10")
            {
                MessageBox.Show(bomba);
                lbl_b101.BackColor = Color.Red;
                qtdm_submarinos++;
                MessageBox.Show(submarinos);
                if (qtdm_submarinos == 4)
                {
                    ckb_submarinosm.Checked = true;
                }
            }
            else if (tb_coordenadas.Text == "B8")
            {
                MessageBox.Show(bomba);
                lbl_c91.BackColor = Color.Red;
                qtdm_submarinos++;
                MessageBox.Show(submarinos);
                if (qtdm_submarinos == 4)
                {
                    ckb_submarinosm.Checked = true;
                }
            }
            else if (tb_coordenadas.Text == "D7")
            {
                MessageBox.Show(bomba);
                lbl_d71.BackColor = Color.Red;
                qtdm_submarinos++;
                MessageBox.Show(submarinos);
                if (qtdm_submarinos == 4)
                {
                    ckb_submarinosm.Checked = true;
                }
            }
            else if (tb_coordenadas.Text == "G2")
            {
                MessageBox.Show(bomba);
                lbl_g21.BackColor = Color.Red;
                qtdm_submarinos++;
                MessageBox.Show(submarinos);
                if (qtdm_submarinos == 4)
                {
                    ckb_submarinosm.Checked = true;
                }
            }
            else if (tb_coordenadas.Text == "A1")
            {
                MessageBox.Show(agua);
                lbl_a11.BackColor = Color.Green;                
            }
            else if (tb_coordenadas.Text == "B1")
            {
                MessageBox.Show(agua);
                lbl_b11.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "C1")
            {
                MessageBox.Show(agua);
                lbl_c11.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "I1")
            {
                MessageBox.Show(agua);
                lbl_i11.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "J1")
            {
                MessageBox.Show(agua);
                lbl_j11.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "C2")
            {
                MessageBox.Show(agua);
                lbl_c21.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "D2")
            {
                MessageBox.Show(agua);
                lbl_d21.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "E2")
            {
                MessageBox.Show(agua);
                lbl_e21.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "F2")
            {
                MessageBox.Show(agua);
                lbl_f21.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "H2")
            {
                MessageBox.Show(agua);
                lbl_h21.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "I2")
            {
                MessageBox.Show(agua);
                lbl_i21.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "J2")
            {
                MessageBox.Show(agua);
                lbl_j21.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "A3")
            {
                MessageBox.Show(agua);
                lbl_a31.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "F3")
            {
                MessageBox.Show(agua);
                lbl_f31.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "G3")
            {
                MessageBox.Show(agua);
                lbl_g31.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "H3")
            {
                MessageBox.Show(agua);
                lbl_h31.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "I3")
            {
                MessageBox.Show(agua);
                lbl_i31.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "J3")
            {
                MessageBox.Show(agua);
                lbl_j31.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "A4")
            {
                MessageBox.Show(agua);
                lbl_a41.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "B4")
            {
                MessageBox.Show(agua);
                lbl_b41.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "E4")
            {
                MessageBox.Show(agua);
                lbl_e41.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "F4")
            {
                MessageBox.Show(agua);
                lbl_f41.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "H4")
            {
                MessageBox.Show(agua);
                lbl_h41.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "I4")
            {
                MessageBox.Show(agua);
                lbl_i41.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "J4")
            {
                MessageBox.Show(agua);
                lbl_j41.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "A5")
            {
                MessageBox.Show(agua);
                lbl_a51.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "C5")
            {
                MessageBox.Show(agua);
                lbl_c51.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "D5")
            {
                MessageBox.Show(agua);
                lbl_d51.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "E5")
            {
                MessageBox.Show(agua);
                lbl_e51.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "G5")
            {
                MessageBox.Show(agua);
                lbl_g51.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "I5")
            {
                MessageBox.Show(agua);
                lbl_i51.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "J5")
            {
                MessageBox.Show(agua);
                lbl_j51.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "B6")
            {
                MessageBox.Show(agua);
                lbl_b61.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "D6")
            {
                MessageBox.Show(agua);
                lbl_d61.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "E6")
            {
                MessageBox.Show(agua);
                lbl_e61.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "F6")
            {
                MessageBox.Show(agua);
                lbl_f61.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "G6")
            {
                MessageBox.Show(agua);
                lbl_g61.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "H6")
            {
                MessageBox.Show(agua);
                lbl_h61.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "I6")
            {
                MessageBox.Show(agua);
                lbl_i61.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "J6")
            {
                MessageBox.Show(agua);
                lbl_j61.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "A7")
            {
                MessageBox.Show(agua);
                lbl_a71.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "B7")
            {
                MessageBox.Show(agua);
                lbl_b71.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "C7")
            {
                MessageBox.Show(agua);
                lbl_c71.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "E7")
            {
                MessageBox.Show(agua);
                lbl_e71.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "J7")
            {
                MessageBox.Show(agua);
                lbl_j71.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "A8")
            {
                MessageBox.Show(agua);
                lbl_a81.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "C8")
            {
                MessageBox.Show(agua);
                lbl_c81.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "E8")
            {
                MessageBox.Show(agua);
                lbl_e81.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "F8")
            {
                MessageBox.Show(agua);
                lbl_f81.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "G8")
            {
                MessageBox.Show(agua);
                lbl_g81.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "H8")
            {
                MessageBox.Show(agua);
                lbl_h81.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "I8")
            {
                MessageBox.Show(agua);
                lbl_i81.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "J8")
            {
                MessageBox.Show(agua);
                lbl_j81.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "A9")
            {
                MessageBox.Show(agua);
                lbl_a91.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "B9")
            {
                MessageBox.Show(agua);
                lbl_b91.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "D9")
            {
                MessageBox.Show(agua);
                lbl_d91.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "F9")
            {
                MessageBox.Show(agua);
                lbl_f91.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "G9")
            {
                MessageBox.Show(agua);
                lbl_g91.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "H9")
            {
                MessageBox.Show(agua);
                lbl_h91.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "I9")
            {
                MessageBox.Show(agua);
                lbl_i91.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "J9")
            {
                MessageBox.Show(agua);
                lbl_j91.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "A10")
            {
                MessageBox.Show(agua);
                lbl_a101.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "C10")
            {
                MessageBox.Show(agua);
                lbl_c101.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "D10")
            {
                MessageBox.Show(agua);
                lbl_d101.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "E10")
            {
                MessageBox.Show(agua);
                lbl_e101.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "F10")
            {
                MessageBox.Show(agua);
                lbl_f101.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "G10")
            {
                MessageBox.Show(agua);
                lbl_g101.BackColor = Color.Green;
            }
            else if (tb_coordenadas.Text == "H10")
            {
                MessageBox.Show(agua);
                lbl_h101.BackColor = Color.Green;
            }        
            else
            {
                MessageBox.Show(erro_coordenada);
                tb_coordenadas.Text = tb_coordenadas.Text;
            }
            cont_jogada++;
            lbl_njogadas.Text = $"Número de Jogadas: {cont_jogada}";
            // Verificar se Jogador ganhou
            if (qtdm_pavioes >= 5 && qtdm_encuracados >= 4 && qtdm_encuracados2 >= 4 && qtdm_hidroavioes >= 3 && qtdm_hidroavioes2 >= 3 && qtdm_hidroavioes3 >= 3 && qtdm_cruzadores >= 2 && qtdm_cruzadores2 >= 2 && qtdm_cruzadores3 >= 2 && qtdm_submarinos >= 4)
            {
                MessageBox.Show(venceu);
                btn_inicarbatalha.Enabled = false;
            }
            // Ataque da Maquina
                Random aleatorio = new Random();
                ataque = aleatorio.Next(1, 101);
                if (ataque == 1)
                {
                    if (lbl_a1.BackColor == Color.Black || lbl_a1.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_a1.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_a1.BackColor = Color.Green;
                    }

                }
                else if (ataque == 2)
                {
                    if (lbl_a2.BackColor == Color.Black || lbl_a2.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_a2.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_a2.BackColor = Color.Green;
                    }
                }
                else if (ataque == 3)
                {
                    if (lbl_a3.BackColor == Color.Black || lbl_a3.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_a3.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_a3.BackColor = Color.Green;
                    }
                }
                else if (ataque == 4)
                {
                    if (lbl_a4.BackColor == Color.Black || lbl_a4.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_a4.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_a4.BackColor = Color.Green;
                    }
                }
                else if (ataque == 5)
                {
                    if (lbl_a5.BackColor == Color.Black || lbl_a5.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_a5.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_a5.BackColor = Color.Green;
                    }
                }
                else if (ataque == 6)
                {
                    if (lbl_a6.BackColor == Color.Black || lbl_a6.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_a6.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_a6.BackColor = Color.Green;
                    }
                }
                else if (ataque == 7)
                {
                    if (lbl_a7.BackColor == Color.Black || lbl_a7.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_a7.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_a7.BackColor = Color.Green;
                    }
                }
                else if (ataque == 8)
                {
                    if (lbl_a8.BackColor == Color.Black || lbl_a8.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_a8.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_a8.BackColor = Color.Green;
                    }
                }
                else if (ataque == 9)
                {
                    if (lbl_a9.BackColor == Color.Black || lbl_a9.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_a9.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_a9.BackColor = Color.Green;
                    }
                }
                else if (ataque == 10)
                {
                    if (lbl_a10.BackColor == Color.Black || lbl_a10.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_a10.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_a10.BackColor = Color.Green;
                    }
                }
                else if (ataque == 11)
                {
                    if (lbl_b1.BackColor == Color.Black || lbl_b1.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_b1.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_b1.BackColor = Color.Green;
                    }
                }
                else if (ataque == 12)
                {
                    if (lbl_b2.BackColor == Color.Black || lbl_b2.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_b2.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_b2.BackColor = Color.Green;
                    }
                }
                else if (ataque == 13)
                {
                    if (lbl_b3.BackColor == Color.Black || lbl_b3.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_b1.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_b3.BackColor = Color.Green;
                    }
                }
                else if (ataque == 14)
                {
                    if (lbl_b4.BackColor == Color.Black || lbl_b4.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_b4.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_b4.BackColor = Color.Green;
                    }
                }
                else if (ataque == 15)
                {
                    if (lbl_b5.BackColor == Color.Black || lbl_b5.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_b5.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_b5.BackColor = Color.Green;
                    }
                }
                else if (ataque == 16)
                {
                    if (lbl_b6.BackColor == Color.Black || lbl_b6.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_b6.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_b6.BackColor = Color.Green;
                    }
                }
                else if (ataque == 17)
                {
                    if (lbl_b7.BackColor == Color.Black || lbl_b7.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_b7.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_b7.BackColor = Color.Green;
                    }
                }
                else if (ataque == 18)
                {
                    if (lbl_b8.BackColor == Color.Black || lbl_b8.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_b8.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_b8.BackColor = Color.Green;
                    }
                }
                else if (ataque == 19)
                {
                    if (lbl_b9.BackColor == Color.Black || lbl_b9.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_b9.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_b9.BackColor = Color.Green;
                    }
                }
                else if (ataque == 20)
                {
                    if (lbl_b10.BackColor == Color.Black || lbl_b10.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_b10.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_b10.BackColor = Color.Green;
                    }
                }
                else if (ataque == 21)
                {
                    if (lbl_c1.BackColor == Color.Black || lbl_c1.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_c1.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_c1.BackColor = Color.Green;
                    }
                }
                else if (ataque == 22)
                {
                    if (lbl_c2.BackColor == Color.Black || lbl_c2.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_c2.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_c2.BackColor = Color.Green;
                    }
                }
                else if (ataque == 23)
                {
                    if (lbl_c3.BackColor == Color.Black || lbl_c3.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_c3.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_c3.BackColor = Color.Green;
                    }
                }
                else if (ataque == 24)
                {
                    if (lbl_c4.BackColor == Color.Black || lbl_c4.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_c4.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_c4.BackColor = Color.Green;
                    }
                }
                else if (ataque == 25)
                {
                    if (lbl_c5.BackColor == Color.Black || lbl_c5.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_c5.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_c5.BackColor = Color.Green;
                    }
                }
                else if (ataque == 26)
                {
                    if (lbl_c6.BackColor == Color.Black || lbl_c6.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_c6.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_c6.BackColor = Color.Green;
                    }
                }
                else if (ataque == 27)
                {
                    if (lbl_c7.BackColor == Color.Black || lbl_c7.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_c7.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_c7.BackColor = Color.Green;
                    }
                }
                else if (ataque == 28)
                {
                    if (lbl_c8.BackColor == Color.Black || lbl_c8.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_c8.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_c8.BackColor = Color.Green;
                    }
                }
                else if (ataque == 29)
                {
                    if (lbl_c9.BackColor == Color.Black || lbl_c9.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_c9.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_c9.BackColor = Color.Green;
                    }
                }
                else if (ataque == 30)
                {
                    if (lbl_c10.BackColor == Color.Black || lbl_c10.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_c10.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_c10.BackColor = Color.Green;
                    }
                }
                else if (ataque == 31)
                {
                    if (lbl_d1.BackColor == Color.Black || lbl_d1.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_d1.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_d1.BackColor = Color.Green;
                    }
                }
                else if (ataque == 32)
                {
                    if (lbl_d2.BackColor == Color.Black || lbl_d2.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_d2.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_d2.BackColor = Color.Green;
                    }
                }
                else if (ataque == 33)
                {
                    if (lbl_d3.BackColor == Color.Black || lbl_d3.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_d3.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_d3.BackColor = Color.Green;
                    }
                }
                else if (ataque == 34)
                {
                    if (lbl_d4.BackColor == Color.Black || lbl_d4.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_d4.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_d4.BackColor = Color.Green;
                    }
                }
                else if (ataque == 35)
                {
                    if (lbl_d5.BackColor == Color.Black || lbl_d5.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_d5.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_d5.BackColor = Color.Green;
                    }
                }
                else if (ataque == 36)
                {
                    if (lbl_d6.BackColor == Color.Black || lbl_d6.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_d6.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_d6.BackColor = Color.Green;
                    }
                }
                else if (ataque == 37)
                {
                    if (lbl_d7.BackColor == Color.Black || lbl_d7.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_d7.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_d7.BackColor = Color.Green;
                    }
                }
                else if (ataque == 38)
                {
                    if (lbl_d8.BackColor == Color.Black || lbl_d8.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_d8.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_d8.BackColor = Color.Green;
                    }
                }
                else if (ataque == 39)
                {
                    if (lbl_d9.BackColor == Color.Black || lbl_d9.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_d9.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_d9.BackColor = Color.Green;
                    }
                }
                else if (ataque == 40)
                {
                    if (lbl_d10.BackColor == Color.Black || lbl_d10.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_d10.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_d10.BackColor = Color.Green;
                    }
                }
                else if (ataque == 41)
                {
                    if (lbl_e1.BackColor == Color.Black || lbl_e1.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_e1.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_e1.BackColor = Color.Green;
                    }
                }
                else if (ataque == 42)
                {
                    if (lbl_e2.BackColor == Color.Black || lbl_e2.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_e2.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_e2.BackColor = Color.Green;
                    }
                }
                else if (ataque == 43)
                {
                    if (lbl_e3.BackColor == Color.Black || lbl_e3.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_e3.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_e3.BackColor = Color.Green;
                    }
                }
                else if (ataque == 44)
                {
                    if (lbl_e4.BackColor == Color.Black || lbl_e4.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_e4.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_e4.BackColor = Color.Green;
                    }
                }
                else if (ataque == 45)
                {
                    if (lbl_e5.BackColor == Color.Black || lbl_e5.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_e5.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_e5.BackColor = Color.Green;
                    }
                }
                else if (ataque == 46)
                {
                    if (lbl_e6.BackColor == Color.Black || lbl_e6.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_e6.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_e6.BackColor = Color.Green;
                    }
                }
                else if (ataque == 47)
                {
                    if (lbl_e7.BackColor == Color.Black || lbl_e7.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_e7.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_e7.BackColor = Color.Green;
                    }
                }
                else if (ataque == 48)
                {
                    if (lbl_e8.BackColor == Color.Black || lbl_e8.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_e8.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_e8.BackColor = Color.Green;
                    }
                }
                else if (ataque == 49)
                {
                    if (lbl_e9.BackColor == Color.Black || lbl_e9.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_e9.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_e9.BackColor = Color.Green;
                    }
                }
                else if (ataque == 50)
                {
                    if (lbl_e10.BackColor == Color.Black || lbl_e10.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_e10.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_e10.BackColor = Color.Green;
                    }
                }
                else if (ataque == 51)
                {
                    if (lbl_f1.BackColor == Color.Black || lbl_f1.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_f1.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_f1.BackColor = Color.Green;
                    }
                }
                else if (ataque == 52)
                {
                    if (lbl_f2.BackColor == Color.Black || lbl_f2.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_f2.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_f2.BackColor = Color.Green;
                    }
                }
                else if (ataque == 53)
                {
                    if (lbl_f3.BackColor == Color.Black || lbl_f3.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_f3.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_f3.BackColor = Color.Green;
                    }
                }
                else if (ataque == 54)
                {
                    if (lbl_f4.BackColor == Color.Black || lbl_f4.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_f4.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_f4.BackColor = Color.Green;
                    }
                }
                else if (ataque == 55)
                {
                    if (lbl_f5.BackColor == Color.Black || lbl_f5.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_f5.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_f5.BackColor = Color.Green;
                    }
                }
                else if (ataque == 56)
                {
                    if (lbl_f6.BackColor == Color.Black || lbl_f6.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_f6.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_f6.BackColor = Color.Green;
                    }
                }
                else if (ataque == 57)
                {
                    if (lbl_f7.BackColor == Color.Black || lbl_f7.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_f7.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_f7.BackColor = Color.Green;
                    }
                }
                else if (ataque == 58)
                {
                    if (lbl_f8.BackColor == Color.Black || lbl_f8.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_f8.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_f8.BackColor = Color.Green;
                    }
                }
                else if (ataque == 59)
                {
                    if (lbl_f9.BackColor == Color.Black || lbl_f9.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_f9.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_f9.BackColor = Color.Green;
                    }
                }
                else if (ataque == 60)
                {
                    if (lbl_f10.BackColor == Color.Black || lbl_f10.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_f10.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_f10.BackColor = Color.Green;
                    }
                }
                else if (ataque == 61)
                {
                    if (lbl_g1.BackColor == Color.Black || lbl_g1.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_g1.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_g1.BackColor = Color.Green;
                    }
                }
                else if (ataque == 62)
                {
                    if (lbl_g2.BackColor == Color.Black || lbl_g2.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_g2.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_g2.BackColor = Color.Green;
                    }
                }
                else if (ataque == 63)
                {
                    if (lbl_g3.BackColor == Color.Black || lbl_g3.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_g3.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_g3.BackColor = Color.Green;
                    }
                }
                else if (ataque == 64)
                {
                    if (lbl_g4.BackColor == Color.Black || lbl_g4.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_g4.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_g4.BackColor = Color.Green;
                    }
                }
                else if (ataque == 65)
                {
                    if (lbl_g5.BackColor == Color.Black || lbl_g5.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_g5.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_g5.BackColor = Color.Green;
                    }
                }
                else if (ataque == 66)
                {
                    if (lbl_g6.BackColor == Color.Black || lbl_g6.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_g6.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_g6.BackColor = Color.Green;
                    }
                }
                else if (ataque == 67)
                {
                    if (lbl_g7.BackColor == Color.Black || lbl_g7.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_g7.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_g7.BackColor = Color.Green;
                    }
                }
                else if (ataque == 68)
                {
                    if (lbl_g8.BackColor == Color.Black || lbl_g8.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_g8.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_g8.BackColor = Color.Green;
                    }
                }
                else if (ataque == 69)
                {
                    if (lbl_g9.BackColor == Color.Black || lbl_g9.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_g9.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_g9.BackColor = Color.Green;
                    }
                }
                else if (ataque == 70)
                {
                    if (lbl_g10.BackColor == Color.Black || lbl_g10.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_g10.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_g10.BackColor = Color.Green;
                    }
                }
                else if (ataque == 71)
                {
                    if (lbl_h1.BackColor == Color.Black || lbl_h1.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_h1.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_h1.BackColor = Color.Green;
                    }
                }
                else if (ataque == 72)
                {
                    if (lbl_h2.BackColor == Color.Black || lbl_h2.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_h2.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_h2.BackColor = Color.Green;
                    }
                }
                else if (ataque == 73)
                {
                    if (lbl_h3.BackColor == Color.Black || lbl_h3.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_h3.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_h3.BackColor = Color.Green;
                    }
                }
                else if (ataque == 74)
                {
                    if (lbl_h4.BackColor == Color.Black || lbl_h4.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_h4.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_h4.BackColor = Color.Green;
                    }
                }
                else if (ataque == 75)
                {
                    if (lbl_h5.BackColor == Color.Black || lbl_h5.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_h5.BackColor = Color.Red;
                        qtd_ataque++;
                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_h5.BackColor = Color.Green;
                    }
                }
                else if (ataque == 76)
                {
                    if (lbl_h6.BackColor == Color.Black || lbl_h6.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_h6.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_h6.BackColor = Color.Green;
                    }
                }
                else if (ataque == 77)
                {
                    if (lbl_h7.BackColor == Color.Black || lbl_h7.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_h7.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_h7.BackColor = Color.Green;
                    }
                }
                else if (ataque == 78)
                {
                    if (lbl_h8.BackColor == Color.Black || lbl_h8.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_h8.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_h8.BackColor = Color.Green;
                    }
                }
                else if (ataque == 79)
                {
                    if (lbl_h9.BackColor == Color.Black || lbl_h9.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_h9.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_h9.BackColor = Color.Green;
                    }
                }
                else if (ataque == 80)
                {
                    if (lbl_h10.BackColor == Color.Black || lbl_h10.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_h10.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_h10.BackColor = Color.Green;
                    }
                }
                else if (ataque == 81)
                {
                    if (lbl_i1.BackColor == Color.Black || lbl_i1.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_i1.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_i1.BackColor = Color.Green;
                    }
                }
                else if (ataque == 82)
                {
                    if (lbl_i2.BackColor == Color.Black || lbl_i2.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_i2.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_i2.BackColor = Color.Green;
                    }
                }
                else if (ataque == 83)
                {
                    if (lbl_i3.BackColor == Color.Black || lbl_i3.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_i3.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_i3.BackColor = Color.Green;
                    }
                }
                else if (ataque == 84)
                {
                    if (lbl_i4.BackColor == Color.Black || lbl_i4.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_i4.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_i4.BackColor = Color.Green;
                    }
                }
                else if (ataque == 85)
                {
                    if (lbl_i5.BackColor == Color.Black || lbl_i5.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_i5.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_i5.BackColor = Color.Green;
                    }
                }
                else if (ataque == 86)
                {
                    if (lbl_i6.BackColor == Color.Black || lbl_i6.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_i6.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_i6.BackColor = Color.Green;
                    }
                }
                else if (ataque == 87)
                {
                    if (lbl_i7.BackColor == Color.Black || lbl_i7.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_i7.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_i7.BackColor = Color.Green;
                    }
                }
                else if (ataque == 88)
                {
                    if (lbl_i8.BackColor == Color.Black || lbl_i8.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_i8.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_i8.BackColor = Color.Green;
                    }
                }
                else if (ataque == 89)
                {
                    if (lbl_i9.BackColor == Color.Black || lbl_i9.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_i9.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_i9.BackColor = Color.Green;
                    }
                }
                else if (ataque == 90)
                {
                    if (lbl_i10.BackColor == Color.Black || lbl_i10.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_i10.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_i10.BackColor = Color.Green;
                    }
                }
                else if (ataque == 91)
                {
                    if (lbl_j1.BackColor == Color.Black || lbl_j1.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_j1.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_j1.BackColor = Color.Green;
                    }
                }
                else if (ataque == 92)
                {
                    if (lbl_j2.BackColor == Color.Black || lbl_j2.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_j2.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_j2.BackColor = Color.Green;
                    }
                }
                else if (ataque == 93)
                {
                    if (lbl_j3.BackColor == Color.Black || lbl_j3.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_j3.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_j3.BackColor = Color.Green;
                    }
                }
                else if (ataque == 94)
                {
                    if (lbl_j4.BackColor == Color.Black || lbl_j4.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_j4.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_j4.BackColor = Color.Green;
                    }
                }
                else if (ataque == 95)
                {
                    if (lbl_j5.BackColor == Color.Black || lbl_j5.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_j5.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_j5.BackColor = Color.Green;
                    }
                }
                else if (ataque == 96)
                {
                    if (lbl_j6.BackColor == Color.Black || lbl_j6.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_j6.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_j6.BackColor = Color.Green;
                    }
                }
                else if (ataque == 97)
                {
                    if (lbl_j7.BackColor == Color.Black || lbl_j7.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_j7.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_j7.BackColor = Color.Green;
                    }
                }
                else if (ataque == 98)
                {
                    if (lbl_j8.BackColor == Color.Black || lbl_j8.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_j8.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_j8.BackColor = Color.Green;
                    }
                }
                else if (ataque == 99)
                {
                    if (lbl_j9.BackColor == Color.Black || lbl_j9.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_j9.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_j9.BackColor = Color.Green;
                    }
                }
                else if (ataque == 100)
                {
                    if (lbl_j10.BackColor == Color.Black || lbl_j10.BackColor == Color.Red)
                    {
                        MessageBox.Show(bomba);
                        lbl_j10.BackColor = Color.Red;
                        qtd_ataque++;

                    }
                    else
                    {
                        MessageBox.Show(agua);
                        lbl_j10.BackColor = Color.Green;
                    }
                }

                if (qtd_ataque >= 32)
                {
                    MessageBox.Show(perdeu);
                    btn_inicarbatalha.Enabled = false;
                    ckb_pavioes.Checked = true;
                    ckb_cruzadores.Checked = true;
                    ckb_encuracados.Checked = true;
                    ckb_hidroavioes.Checked = true;
                    ckb_submarinos.Checked = true;
                }
        }
    }
}
