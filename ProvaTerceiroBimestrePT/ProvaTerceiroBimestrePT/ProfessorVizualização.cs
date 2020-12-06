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
    public partial class ProfessorVizualização : Form
    {

        List<Aluno> Alunos;
        List<Aluno2> AlunosFiltro;
        public ProfessorVizualização(List<Aluno> Alunos, List<Aluno2> AlunosFiltro)
        {
            InitializeComponent();
            this.Alunos = Alunos;
            this.AlunosFiltro = AlunosFiltro;
        }

        private void btnProcurarID_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                richTextBox1.AppendText($"{AlunosFiltro[Convert.ToInt16(textBProcurarName.Text)]}\n");
            }
            catch
            {
                MessageBox.Show($"Não existem alunos!", "Atenção!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();

                AlunosFiltro.Remove(AlunosFiltro[Convert.ToInt16(textBProcurarName.Text)]);

                Aluno2 umAluno = getAlunoAlterar2();
                AlunosFiltro.Insert(Convert.ToInt32(textBProcurarName.Text), umAluno);
                //Alunos.Insert(Convert.ToInt32(textBProcurarName.Text), umAluno);
                //LimparCampos();

                richTextBox1.AppendText(Convert.ToString(umAluno));
            }
            catch
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
            }
        }

        private void btnAlterarData_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime minDate = new DateTime(2020, 12, 6);
                DateTime maxDate = new DateTime(2020, 12, 13);
                if (dateAlterar.Value > minDate && dateAlterar.Value < maxDate)
                {
                    AlunosFiltro.Remove(AlunosFiltro[Convert.ToInt16(textBProcurarName.Text)]);
                    Aluno umAluno = getAlunoAlterar();
                    Alunos.Add(umAluno);
                    //LimparCampos();
                }
                else
                {
                    MessageBox.Show("A data precisa ser entre o dia 6 ao dia 13 de dezembro de 2020");
                }

            }
            catch
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
            }
        }
        private Aluno2 getAlunoAlterar2()
        {
            Aluno2 umAluno = new Aluno2();
            umAluno.Nome = tbNomeAlterar.Text;
            umAluno.Sobrenome = tBSobrenomeALterar.Text;
            umAluno.Curso = tBCursoAlterar.Text;
            umAluno.Data = dateAlterar.Value;
            try
            {
                umAluno.Nota = LerNumericos.LeFloat(tBNotaCursoAlterar.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
                //Console.WriteLine("Erro:" + e.ToString());
            }
            return umAluno;
        }
        private Aluno getAlunoAlterar()
        {
            Aluno umAluno = new Aluno();
            umAluno.Nome = tbNomeAlterar.Text;
            umAluno.Sobrenome = tBSobrenomeALterar.Text;
            umAluno.Curso = tBCursoAlterar.Text;
            umAluno.Data = dateAlterar.Value;
            try
            {
                umAluno.Nota = LerNumericos.LeFloat(tBNotaCursoAlterar.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
                //Console.WriteLine("Erro:" + e.ToString());
            }
            return umAluno;
        }
    }
}
