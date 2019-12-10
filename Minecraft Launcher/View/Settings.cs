using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Launcher.View
{
    public partial class Tela_Settings : Form
    {
        private bool FullScreen;

        public Tela_Settings()
        {
            InitializeComponent();            
        }

        private void Img_HappyLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.happycodeschool.com/");
        }

        private void Fechar_btn_Click(object sender, EventArgs e)
        {
            this.Hide();                
        }

        private void CheckBox_FullScreen_OnChange(object sender, EventArgs e)
        {
            //FullScreen Controller 
            if (CheckBox_FullScreen.Checked)
            {
                FullScreen = true;
                Console.WriteLine("Caixa Marcada!!");
            }
            else
            {
                FullScreen = false;
                Console.WriteLine("Caixa Desmarcada!!");
            }
        }

        private void TxTBox_Altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxTBox_Largura_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Salvar_btn_Click(object sender, EventArgs e)
        {
            //FullScreen Sender
            if (FullScreen)
            {
                Tela_Principal.FullScreen = true;
            }
            else
            {
                Tela_Principal.FullScreen = false;
            }
            this.Hide();
        }
    }
}
