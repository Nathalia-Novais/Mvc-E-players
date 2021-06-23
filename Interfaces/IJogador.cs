using System.Collections.Generic;
using mvc_e_players.Models;

namespace mvc_e_players.Interfaces
{
    public interface IJogador
    {
        void Criar (Jogador j);

        List<Jogador> LerTodas();

        void Alterar (Jogador j);

        void Deletar(int id);
        

        
    }
}