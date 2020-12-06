using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaTerceiroBimestrePT
{
    public partial class VizualizaçãoAluno : Form
    {
        List<Aluno> Alunos;
        List<Aluno2> AlunosFiltro;
        public VizualizaçãoAluno(List<Aluno> Alunos, List<Aluno2> AlunosFiltro)
        {
            InitializeComponent();
            this.Alunos = Alunos;
            this.AlunosFiltro = AlunosFiltro;
        }

        private Aluno2 getAluno2()
        {
            Aluno2 umAluno = new Aluno2();
            umAluno.Nome = textBNomeContinuar.Text;
            umAluno.Sobrenome = textBSobrenomeContinuar.Text;
            umAluno.Curso = textBCursoContinuar.Text;
            umAluno.Data = dateTimePContinuar.Value;
            //try
            //{
            //    umTorcedor.Nota = LerNumericos.LeFloat(tbNotaCursoIncluir.Text);
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show($"Valores Inválidos!", "Atenção!");
            //    //Console.WriteLine("Erro:" + e.ToString());
            //}
            return umAluno;
        }

        private void btnConcluirCurso_Click(object sender, EventArgs e)
        {
            try
            {
                Alunos.Remove(Alunos[Convert.ToInt16(tBPesquisar2.Text)]);
                Aluno2 umAluno = getAluno2();
                AlunosFiltro.Add(umAluno);
                //LimparCampos();
            }
            catch
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
            }
        }

        private void btnPesquisar2_Click(object sender, EventArgs e)
        {
            try
            {
                rTBPesquisar2.Clear();
                rTBPesquisar2.AppendText($"{Alunos[Convert.ToInt16(tBPesquisar2.Text)]}\n");
            }
            catch
            {
                MessageBox.Show($"Não existem alunos!", "Atenção!");
            }
        }

    }
}
