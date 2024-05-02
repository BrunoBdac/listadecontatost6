using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace listadecontatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Contato[] listadeContatos = new Contato[1];

        private void Escrever(Contato contato)
        {
            StreamWriter escrever = new StreamWriter("Contatos.txt");

            escrever.WriteLine(listadeContatos.Length + 1);
            escrever.WriteLine(contato.Nome);
            escrever.WriteLine(contato.Sobrenome);
            escrever.WriteLine(contato.Telefone);

            for (int x = 0; x < listadeContatos.Length; x++)
            {
                escrever.WriteLine(listadeContatos[x].Nome);
                escrever.WriteLine(listadeContatos[x].Sobrenome);
                escrever.WriteLine(listadeContatos[x].Telefone);
            }

            escrever.Close();
        }

        private void Ler()
        {
            StreamReader ler = new StreamReader("Contatos.txt");

            listadeContatos = new Contato[Convert.ToInt32(ler.ReadLine())];

            for (int x = 0; x <= listadeContatos.Length; ++x)
            {
                listadeContatos[x] = new Contato();
                listadeContatos[x].Nome = ler.ReadLine();
                listadeContatos[x].Sobrenome = ler.ReadLine();
                listadeContatos[x].Telefone = ler.ReadLine();
            }
            ler.Close();

        }

        private void Exibir()
        {
            listBox1.Items.Clear();

            for(int x = 0; x < listadeContatos.Length; x++)
            {
                listBox1.Items.Add(listadeContatos[x].ToString());
            }
        }

        private void LimparCampos()
        {
            textBoxNome.Text = string.Empty;
            textBoxSobrenome.Text = string.Empty;
            textBoxTelefone.Text = string.Empty;
        }
        private void Nome(object sender, EventArgs e)
        {

        }

        private void Sobrenome(object sender, EventArgs e)
        {

        }

        private void Telefone(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            Exibir();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonincluicontato(object sender, EventArgs e)
        {
            Contato contato = new Contato();

            contato.Nome = textBoxNome.Text;
            contato.Sobrenome = textBoxSobrenome.Text;
            contato.Telefone = textBoxTelefone.Text;


            listBox1.Items.Add(contato.ToString());

            Escrever(contato);
            Ler();
            Exibir();
            LimparCampos();
        }

        private void textBoxSobrenome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
