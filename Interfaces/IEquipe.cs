using System.Collections.Generic;
using mvc_e_players.Models;

namespace mvc_e_players.Interfaces
{
    public interface IEquipe
    {
         void Criar (Equipe e);

         List<Equipe> LerTodas();

         void Alterar(Equipe e);

         void Deletar(int id);
    }
}