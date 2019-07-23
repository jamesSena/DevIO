using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevIO.UI.Site.Data;
using DevIO.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Controllers
{
    public class DBController : Controller
    {
        private readonly MyDBContext _contexto;
        public DBController(MyDBContext contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "jamesson",
                DataNascimento = DateTime.Now,
                Email = "jamesson@hotmail.com"
            };
            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();
            var aluno2 = _contexto.Alunos.Find(aluno.Id);
            var aluno3 = _contexto.Alunos.FirstOrDefault(a=>a.Email.Equals("jamesson@hotmail.com"));

            var aluno4 = _contexto.Alunos.Where(a => a.Email.Equals("james"));
            aluno.Nome = "James";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();
            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();
            return View();
        }
    }
}