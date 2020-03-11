using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Senai.Senatur.WebApi.Repositories
{
    public class PacotesRepository : IPacoteRepository
    {
        Senatur_Tarde ctx = new Senatur_Tarde();
        public List<Pacotes> Listar()
        {
            return ctx.Pacotes.ToList();
        }
        public Pacotes BuscarPorId(int id)
        {
            return ctx.Pacotes.FirstOrDefault(j => j.IdPacote == id);
        }
        public void Cadastrar(Pacotes novoPacote)
        {
            ctx.Pacotes.Add(novoPacote);
            ctx.SaveChanges();
        }
        public void Atualizar(int id, Pacotes pacoteAtualizado)
        {
            Pacotes pacoteBuscado = ctx.Pacotes.Find(id);
            pacoteBuscado.NomePacote = pacoteAtualizado.NomePacote;
            pacoteBuscado.Descricao = pacoteAtualizado.Descricao;
            pacoteBuscado.DataIda = pacoteAtualizado.DataIda;
            pacoteBuscado.DataVolta = pacoteAtualizado.DataVolta;
            pacoteBuscado.Valor = pacoteAtualizado.Valor;
            pacoteBuscado.Ativo = pacoteAtualizado.Ativo;
            pacoteBuscado.NomeCidade = pacoteAtualizado.NomeCidade;

            ctx.Pacotes.Update(pacoteBuscado);
            ctx.SaveChanges();
        }
    }
}
