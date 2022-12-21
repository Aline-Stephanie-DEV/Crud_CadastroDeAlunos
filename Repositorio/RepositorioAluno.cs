using EM.Domain;
using FirebirdSql.Data.FirebirdClient;
using System.Linq.Expressions;

namespace EM.Repository
{
    public class RepositorioAluno : RepositorioAbstrato<Aluno>
    {
        readonly FbConnection connectionBD = new(@"DataSource=localhost; Port=3054; Database=D:\DBESTAGIO.FDB; username = sysdba; password = masterkey");
        public override void Add(Aluno aluno)
        {
            connectionBD.Open();
            FbCommand cmd = new($"insert into TBALUNO(ALUMATRICULA, ALUNOME, ALUNOSEXO, ALUNASCIMENTO, ALUNOCPF) values " +
                $"({aluno.Matricula}, '{aluno.Nome}', {(int)aluno.Sexo}, '{aluno.Nascimento.ToString("dd.MM.yyyy")}', '{aluno.CPF}');", connectionBD);
            cmd.ExecuteNonQuery();
            connectionBD.Close();
        }
        public override void Remove(Aluno aluno)
        {
            connectionBD.Open();
            FbCommand cmd = new($"delete from TBALUNO " +
                $"where (ALUMATRICULA={aluno.Matricula});", connectionBD);
            cmd.ExecuteNonQuery();
            connectionBD.Close();
        }
        public override void Update(Aluno aluno)
        {
            connectionBD.Open();
            FbCommand cmd = new($"update TBALUNO " +
                $"set ALUMATRICULA={aluno.Matricula}, " +
                $"ALUNOME = '{aluno.Nome}', " +
                $"ALUNOSEXO = {(int)aluno.Sexo}, " +
                $"ALUNASCIMENTO = '{aluno.Nascimento:dd.MM.yyyy}'," +
                $"ALUNOCPF = '{aluno.CPF}' " +
                $"where ALUMATRICULA = {aluno.Matricula};", connectionBD);
            cmd.ExecuteNonQuery();
            connectionBD.Close();
        }
        public override IEnumerable<Aluno> GetAll()
        {
            List<Aluno> alunos = new();
            connectionBD.Open();
            FbCommand cmd = new($"select * from TBALUNO;", connectionBD);
            FbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Aluno aluno = new
                    (Convert.ToInt32(reader[0]),
                    Convert.ToString(reader[1]),
                    (EnumeradorSexo)(reader[2]),
                    (DateTime)reader[3],
                    (Cpf)(reader[4]).ToString().Replace("-","").Replace(".", ""));
                    alunos.Add(aluno);                    
            }
            reader.Close();
            cmd.ExecuteNonQuery();
            connectionBD.Close();
           
            return alunos.OrderBy(a => a.Matricula); ;
        }
        public override IEnumerable<Aluno> Get(Expression<Func<Aluno, bool>> predicate)
        {
            return GetAll().Where(predicate.Compile());
        }
        public Aluno GetByMatricula(int matricula)
        {
            return GetAll().First(am => am.Matricula == matricula);
        }
        public IEnumerable<Aluno> GetByContendoNoNome(string parteDoNome)
        {
            return GetAll().Where(pn => pn.Nome.Contains(parteDoNome));
        }
    }
}