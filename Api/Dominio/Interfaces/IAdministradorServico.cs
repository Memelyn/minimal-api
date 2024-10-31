using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  MinimalAPI.Dominio.Entidades;
using MinimalAPI.DTOs;

namespace MinimalAPI.Dominio.Interfaces;

    public interface IAdministradorServico
    {
      Administrador? Login (LoginDTO loginDTO);  
      Administrador Incluir (Administrador administador);  
      Administrador? BuscaPorId (int id);  
       List<Administrador> Todos (int? pagina);  
    }





// using MinimalAPI.Dominio.Entidades;
// using MinimalAPI.DTOs;
// namespace MinimalAPI.Dominio.Interfaces;

// public interface IAdministradorServico
// {
//     Administrador? Login (LoginDTO loginDTO);
// }