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
    public partial class Form1 : Form
    {

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        List<Aluno> Alunos = new List<Aluno>();
        List<Aluno2> AlunosFiltro = new List<Aluno2>();
        private String arquivo = @"C:\Users\vibag\source\repos\save1\pessoa.txt ";

        private Aluno getAluno()
        {
            Aluno umAluno = new Aluno();
            umAluno.Nome = tBNomeIncluir.Text;
            umAluno.Sobrenome = tBSoobrenomeIncluir.Text;
            umAluno.Curso = tBCursoIncluir.Text;
            umAluno.Data = dateIncluir.Value;
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

        private void LimparCampos()
        {
            tBSoobrenomeIncluir.Clear();
            tBNomeIncluir.Clear();
            //tbNotaCursoIncluir.Clear();
            tBCursoIncluir.Clear();
            //tBCursoAlterar.Clear();
            //tBNotaCursoAlterar.Clear();
            //tBSobrenomeALterar.Clear();
            //tbNomeAlterar.Clear();

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno umAluno = getAluno();
                Alunos.Add(umAluno);
                LimparCampos();
            }
            catch
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
            }
        }

      

      

      
      

       

        private void btnPagAluno_Click(object sender, EventArgs e)
        {
            VizualizaçãoAluno vizualizaçãoAluno = new VizualizaçãoAluno(Alunos, AlunosFiltro);
            vizualizaçãoAluno.Show();
        }

        private void btnPagProfessor_Click(object sender, EventArgs e)
        {
            ProfessorVizualização professorVizualização = new ProfessorVizualização(Alunos, AlunosFiltro);
            professorVizualização.Show();
        }
    }
}
