using Microsoft.AspNetCore.Mvc;
using EM.Repository;
using EM.Domain;
using EM.Web.Models;

namespace EM.Web.Controllers
{
    public class AlunoController : Controller
    {
        readonly RepositorioAluno repositorioAluno = new();
        readonly AlunoViewModel modelViewModel = new();
        public IActionResult Index()
        {           
            AlunoViewModel model = new();
            model.Alunos.AddRange(repositorioAluno.GetAll());
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Matricula,Nome,Sexo,Nascimento,CPF")] AlunoViewModel modelViewModel)
        {
            try
            {
                if (!string.IsNullOrEmpty(modelViewModel.CPF)) 
                {
                    modelViewModel.CPF = modelViewModel.CPF.Replace(".", "").Replace("-", "").Replace(" ","");
                }
                
                Cpf cpf = (Cpf)modelViewModel.CPF;
                Aluno aluno1 = new(modelViewModel.Matricula, modelViewModel.Nome, modelViewModel.Sexo, modelViewModel.Nascimento, cpf){
                    Matricula = modelViewModel.Matricula,
                    Nome = modelViewModel.Nome,
                    Sexo = modelViewModel.Sexo,
                    Nascimento = modelViewModel.Nascimento,
                    CPF = cpf
                };
                foreach (Aluno aluno2 in repositorioAluno.GetAll())
                {
                    if (aluno1.Matricula == aluno2.Matricula) { return RedirectToAction(nameof(Index)); }
                }
                if (modelViewModel.Nascimento > DateTime.Today) { return RedirectToAction(nameof(Index)); }               
                repositorioAluno.Add(aluno1);
                await Task.Run(Create);
                return RedirectToAction(nameof(Index));                
            }
            catch (Exception) { return RedirectToAction(nameof(Index)); }
        }
        public IActionResult Edit(int id)
        {
            var alunoEncontrado = repositorioAluno.GetByMatricula(id);
            AlunoViewModel model = new() {
                Matricula = alunoEncontrado.Matricula,
                Nome = alunoEncontrado.Nome,
                Sexo = alunoEncontrado.Sexo,
                Nascimento = alunoEncontrado.Nascimento,
                CPF = alunoEncontrado.CPF 
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Matricula, [Bind("Nome,Sexo,Nascimento,CPF")] AlunoViewModel modelViewModel)
        {
            try
            {
                if (!string.IsNullOrEmpty(modelViewModel.CPF))
                {
                    modelViewModel.CPF = modelViewModel.CPF.Replace(".", "").Replace("-", "").Replace(" ", "");
                }
                Cpf cpf = (Cpf)modelViewModel.CPF;
                Aluno aluno1 = new(Matricula, modelViewModel.Nome, modelViewModel.Sexo, modelViewModel.Nascimento, cpf)
                {                   
                    Nome = modelViewModel.Nome,
                    Sexo = modelViewModel.Sexo,
                    Nascimento = modelViewModel.Nascimento,
                    CPF = cpf
                };
                if (modelViewModel.Nascimento > DateTime.Today) { return RedirectToAction(nameof(Index)); }
                await Task.Run(() => repositorioAluno.Update(aluno1));
                return RedirectToAction(nameof(Index));
            }
            catch (Exception) { return RedirectToAction(nameof(Index)); }
        }
        public IActionResult Delete(int id)
        {
            Aluno alunoEncontrado = repositorioAluno.GetByMatricula(id);
            if (alunoEncontrado != null)
            {              
                AlunoViewModel model = new()
                {
                    Matricula = alunoEncontrado.Matricula,
                    Nome = alunoEncontrado.Nome,
                    Sexo = alunoEncontrado.Sexo,
                    Nascimento = alunoEncontrado.Nascimento,
                    CPF = alunoEncontrado.CPF
                };
                return View(model);
            }
            return NotFound();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Aluno aluno1 = repositorioAluno.GetByMatricula(id);
            if (aluno1 != null)
            {                
                await Task.Run(() => repositorioAluno.Remove(aluno1));
                return RedirectToAction(nameof(Index));
            }
            return Problem("Tente novamente");
        }        
        public IActionResult Pesquisar([Bind("Pesquisa")] AlunoViewModel alunoViewModel)
        {

            if (int.TryParse(alunoViewModel.Pesquisa, out int codigoMatricula))
            {
                try
                {
                    alunoViewModel.Alunos.Add(repositorioAluno.GetByMatricula(codigoMatricula));
                    return View("Index", alunoViewModel);
                }
                catch { return RedirectToAction(nameof(Index)); }
            }
            else if (string.IsNullOrEmpty(alunoViewModel.Pesquisa))
            {
                return RedirectToAction(nameof(Index)); 
            }
            alunoViewModel.Alunos.AddRange(repositorioAluno.GetByContendoNoNome(alunoViewModel.Pesquisa));
            return View("Index", alunoViewModel);            
        }
    }
}
