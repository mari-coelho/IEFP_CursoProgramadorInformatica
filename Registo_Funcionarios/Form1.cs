using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3935_MarianaAlves_T004
{
    public partial class Form1 : Form
    {

        String[,] Funcionarios = new string[9, 7];
        int Id;
        public Form1()
        {
            InitializeComponent();
        }
        private void MostraFuncionario()
        {
            lbl_numero.Text = Funcionarios[Id, 0];
            lbl_nome.Text = Funcionarios[Id, 1];
            lbl_genero.Text = Funcionarios[Id, 2];
            lbl_nascimento.Text = Funcionarios[Id, 3];
            lbl_nacionalidade.Text = Funcionarios[Id, 4];
            lbl_categoria.Text = Funcionarios[Id, 5];
            pic_preview.ImageLocation = Funcionarios[Id, 6];

            String dn = lbl_nascimento.Text;
            var dnascimento = new DateTime(int.Parse(dn.Substring(6, 4)),
                int.Parse(dn.Substring(3, 2)),
                int.Parse(dn.Substring(0, 2)));

            var dataatual = DateTime.Today;

            var idade = dataatual - dnascimento;

            lbl_idade.Text = Convert.ToInt32(idade.Days / 365.25).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader fic = new StreamReader("funcionarios.txt");


            int registo = 0;

            do
            {
                String linha = fic.ReadLine();
                string[] campos = linha.Split(',');

                for (int i = 0; i < campos.Length; i++)
                {
                    Funcionarios[registo, i] = campos[i].ToString();
                }
                registo++;

            } while (fic.Peek() != -1);
            fic.Close();


            MostraFuncionario();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Id = 0;
            MostraFuncionario();
        }

        private void btn_fim_Click(object sender, EventArgs e)
        {
            Id = 8;
            MostraFuncionario();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                Id--;
                MostraFuncionario();
            }

        }

        private void btn_seguinte_Click(object sender, EventArgs e)
        {
            if (Id < 8)
            {
                Id++;
                MostraFuncionario();
            }
        }

        private void pic_1_MouseHover(object sender, EventArgs e)
        {
            Id = 0;
            MostraFuncionario();

        }

        private void pic_2_MouseHover(object sender, EventArgs e)
        {
            Id = 1;
            MostraFuncionario();

        }

        private void pic_3_MouseHover(object sender, EventArgs e)
        {
            Id = 2;
            MostraFuncionario();

        }

        private void pic_4_MouseHover(object sender, EventArgs e)
        {
            Id = 3;
            MostraFuncionario();

        }

        private void pic_5_MouseHover(object sender, EventArgs e)
        {
            Id = 4;
            MostraFuncionario();

        }

        private void pic_6_MouseHover(object sender, EventArgs e)
        {
            Id = 5;
            MostraFuncionario();

        }

        private void pic_7_MouseHover(object sender, EventArgs e)
        {
            Id = 6;
            MostraFuncionario();

        }

        private void pic_8_MouseHover(object sender, EventArgs e)
        {
            Id = 7;
            MostraFuncionario();

        }

        private void pic_9_MouseHover(object sender, EventArgs e)
        {
            Id = 8;
            MostraFuncionario();

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font f1 = new Font("Arial Nova", 16);
            Font f2 = new Font("Times New Roman", 12);

            e.Graphics.DrawString("Funcionários", f1, new SolidBrush(Color.DarkBlue), 100, 50);


            e.Graphics.DrawString("Número: " + lbl_numero.Text, f2, new SolidBrush(Color.Black), 100, 105);
            e.Graphics.DrawString("Nome: " + lbl_nome.Text, f2, new SolidBrush(Color.Black), 100, 130);
            e.Graphics.DrawString("Género: " + lbl_genero.Text, f2, new SolidBrush(Color.Black), 100, 155);
            e.Graphics.DrawString("Data de Nascimento: " + lbl_nascimento.Text, f2, new SolidBrush(Color.Black), 100, 180);
            e.Graphics.DrawString("Nacionalidade: " + lbl_nacionalidade.Text, f2, new SolidBrush(Color.Black), 100, 205);
            e.Graphics.DrawString("Categoria: " + lbl_categoria.Text, f2, new SolidBrush(Color.Black), 100, 230);

            e.Graphics.DrawImage(pic_preview.Image, 450, 100, 200, 200);

        }
    }
}
