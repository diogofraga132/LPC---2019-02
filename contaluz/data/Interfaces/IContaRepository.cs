using System.Collections.Generic;
using domain.Models;

namespace TESTE.Interfaces
{
    public interface IContaRepository
    {   
        int Insert(Conta conta);
        int Update(Conta conta);
        int Delete(int id);
        Conta GetById(int id);
        List<Conta> GetAll();
    }
}