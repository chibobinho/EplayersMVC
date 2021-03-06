using System.Collections.Generic;
using ExemploEplayersMvc.Models;

namespace ExemploEplayersMvc.Interfaces
{
    public interface IJogador
    {
        void Criar(Jogador j);
        List<Jogador> LerTodos();
        void Alterar(Jogador j);
        void Deletar(int id);
    }
}