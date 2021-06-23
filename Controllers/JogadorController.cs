using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvc_e_players.Models;

namespace mvc_e_players.Controllers
{
    [Route("Jogador")]
    public class JogadorController : Controller
    {
        Jogador jogadorModel = new Jogador();

        [Route("Listar")]

        public IActionResult index()
        {

            ViewBag.Jogadores = jogadorModel.LerTodas();
            return View();
        }

        [Route("Cadastrar")]

        public IActionResult Cadastrar(IFormCollection form)
        {

            Jogador novoJogador = new Jogador();
            novoJogador.IdJogador = Int32.Parse(form["IdJogador"]);
            novoJogador.Nome = form["Nome"];
            novoJogador.IdEquipe = Int32.Parse(form["IdEquipe"]);
            novoJogador.Email = form["Email"];
            novoJogador.Senha = form["Senha"];

            jogadorModel.Criar(novoJogador);

            ViewBag.Jogadores = jogadorModel.LerTodas();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            jogadorModel.Deletar(id);
            ViewBag.Jogadores = jogadorModel.LerTodas();
            return LocalRedirect("~/Jogador/Listar");
        }



    }
}