using System;

namespace mvc_e_players.Models
{
    public class Partida
    {
        public int IdPartida { get; set; }

        public int IdJogador1 { get; set; }

        public int IdJogador2 { get; set; }

        public DateTime HorarioInicio { get; set; }

        public DateTime HorarioTermino { get; set; }

    }
}