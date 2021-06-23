using System.Collections.Generic;
using ExemploEplayersMvc.Models;

namespace ExemploEplayersMvc.Interfaces
{
    public interface IEquipe
    {
        void Criar(Equipe e);

        List<Equipe> LerTodas();

        void Alterar(Equipe e);
        
        void Deletar(int id);
    }
}