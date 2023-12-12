using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GuicheApp
{
    public partial class MainForm : Form
    {
        private Guiches guiches;

        public MainForm()
        {
            InitializeComponent();
            guiches = new Guiches();
        }

        private void GerarGuicheButton_Click(object sender, EventArgs e)
        {
            Guiche novoGuiche = new Guiche(guiches.ListaGuiches.Count + 1);
            guiches.Adicionar(novoGuiche);
            MessageBox.Show($"Guichê {novoGuiche.Id} gerado com sucesso!", "Novo Guichê", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChamarGuicheButton_Click(object sender, EventArgs e)
        {
            if (guiches.ListaGuiches.Count > 0)
            {
                Guiche guicheChamado = guiches.ListaGuiches[0];
                guicheChamado.Chamar(guiches.FilaSenhas);
                MessageBox.Show($"Chamando guichê {guicheChamado.Id}", "Chamar Guichê", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não há guichês disponíveis.", "Chamar Guichê", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListarSenhasButton_Click(object sender, EventArgs e)
        {
            List<string> senhas = new List<string>();
            foreach (Guiche guiche in guiches.ListaGuiches)
            {
                foreach (Senha senha in guiche.Atendimentos)
                {
                    senhas.Add($"Guichê {guiche.Id}: {senha.DadosCompletos()}");
                }
            }

            string mensagem = senhas.Count > 0 ? string.Join(Environment.NewLine, senhas) : "Nenhuma senha foi atendida.";
            MessageBox.Show(mensagem, "Lista de Senhas Atendidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListarAtendimentosButton_Click(object sender, EventArgs e)
        {
            List<string> atendimentos = new List<string>();
            foreach (Guiche guiche in guiches.ListaGuiches)
            {
                foreach (Senha senha in guiche.Atendimentos)
                {
                    atendimentos.Add($"Guichê {guiche.Id}: {senha.DadosCompletos()}");
                }
            }

            string mensagem = atendimentos.Count > 0 ? string.Join(Environment.NewLine, atendimentos) : "Nenhum atendimento registrado.";
            MessageBox.Show(mensagem, "Lista de Atendimentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}