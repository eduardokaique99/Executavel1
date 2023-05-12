using System;
using System.Windows.Forms;

namespace Views {

    public class Menu {

        public static void Menus() {

            Form menu = new Form();
            menu.Text = "Menu";
            menu.Size = new System.Drawing.Size(250, 270);
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.FormBorderStyle = FormBorderStyle.FixedSingle;
            menu.MaximizeBox = false;
            menu.MinimizeBox = false;

            Label lblNome= new Label();
            lblNome.Text = "Seu nome:";
            lblNome.Top = 25;
            lblNome.Left = 10;
            lblNome.Size = new System.Drawing.Size(100, 25);

            TextBox txtNome = new TextBox();
            txtNome.Top = 25;
            txtNome.Left = 110;
            txtNome.Size = new System.Drawing.Size(100, 25);

            Button btnOla = new Button();
            btnOla.Text = "OLÁ";
            btnOla.AutoSize = true;
            btnOla.Location = new System.Drawing.Point(80, 90);
            btnOla.Click += (sender, e) => {
                MostrarNome(txtNome.Text);
            };
            
            Button sair = new Button();
            sair.Text = "FECHAR";
            sair.AutoSize = true;
            sair.Location = new System.Drawing.Point( 80 , 175);
            sair.Click += (sender, e) => {
                menu.Close();
            };

            menu.Controls.Add(lblNome);
            menu.Controls.Add(txtNome);
            menu.Controls.Add(btnOla);
            menu.Controls.Add(sair);
            menu.ShowDialog();
    }



    public static void MostrarNome(string nome) {
            Form nomes = new Form();
            nomes.Text = "BEM-VINDO";
            nomes.Size = new System.Drawing.Size(200, 150);
            nomes.StartPosition = FormStartPosition.CenterScreen;
            nomes.FormBorderStyle = FormBorderStyle.FixedSingle;
            nomes.MaximizeBox = false;
            nomes.MinimizeBox = false;

            Label lblOla= new Label();
            lblOla.Text = $"Olá {nome}!!!!!";
            lblOla.Top = 20;
            lblOla.Left = 60;
            lblOla.Size = new System.Drawing.Size(100, 90);


            Button BtnVoltar = new Button();
            BtnVoltar.Text = "Voltar";
            BtnVoltar.Top = 300;
            BtnVoltar.Left = 290;
            BtnVoltar.Size = new System.Drawing.Size(90, 25);
            BtnVoltar.Click += (sender, e) => {
                nomes.Hide();
                nomes.Close();
                nomes.Dispose();
            };
            

            nomes.Controls.Add(lblOla);
            nomes.Controls.Add(BtnVoltar);
            nomes.ShowDialog();
        } 
    }
}