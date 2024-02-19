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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            

        }
        

        private void btn_play_Click(object sender, EventArgs e)
        {
            if(tb_jogador.Text == "")
            {
                MessageBox.Show("Inserir nome do jogador");
            }
            else
            {
                Form3 f3 = new Form3(tb_jogador.Text);
                f3.f2 = this;
                f3.Show();
            }
            

        }
    }
}
