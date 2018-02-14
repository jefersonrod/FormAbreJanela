using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAbreJanela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listar lis = new Listar();
            lis.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Atualizar updt = new Atualizar();
            updt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Apagar delete = new Apagar();
            delete.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar lis = new Listar();
            lis.Show();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atualizar updt = new Atualizar();
            updt.Show();
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apagar delete = new Apagar();
            delete.Show();
        }
    }
}
