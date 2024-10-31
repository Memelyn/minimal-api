using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  MinimalAPI.Dominio.Entidades;
using MinimalAPI.DTOs;

namespace MinimalAPI.Dominio.Interfaces;

    public interface IVeiculoServico
    {
      List<Veiculo> Todos (int? pagina = 1, string? nome = null, string? marca= null);  

      Veiculo? BuscaPorId (int id);

      void Incluir (Veiculo veiculo);
      void Atualizar (Veiculo veiculo);
      void Apagar (Veiculo veiculo);
    }





// using MinimalAPI.Dominio.Entidades;
// using MinimalAPI.DTOs;
// namespace MinimalAPI.Dominio.Interfaces;

// public interface IAdministradorServico
// {
//     Administrador? Login (LoginDTO loginDTO);
// }