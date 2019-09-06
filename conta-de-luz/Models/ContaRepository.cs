using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace conta_de_luz.Models
{
    public class ContaRepository
    {
        public static List<Conta> contas = new List<Conta>();
        public ContaRepository()
        {
        }
        public void Create(Conta conta)
        {
            contas.Add(conta);
            return RedirectToAction("Index");
        }
        public List<Conta> GetAll()
        {
            return contas;
        }
        public Conta GetById(int id)
        {
            return contas.Find(i => i.id == id);
        }
        public RedirectToActionResult Delete(Conta conta)
        {
            _repository.Delete(contas.id);
            return RedirectToAction("Index");
        }
    }
}