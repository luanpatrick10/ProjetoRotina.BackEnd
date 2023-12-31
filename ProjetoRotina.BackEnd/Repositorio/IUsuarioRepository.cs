﻿using ProjetoRotina.BackEnd.DTOS;
using ProjetoRotina.BackEnd.Entidades;

namespace ProjetoRotina.BackEnd.Repositorio
{
    public interface IUsuarioRepository
    {
        void Criar(Usuario usuario);
        Usuario Obter(int id);
        void Atualizar(Usuario usuario);
        void Deletar(Usuario usuario);
        LogadoDTO LogarPorEmailESenha(string email, string senha);
    }
}
