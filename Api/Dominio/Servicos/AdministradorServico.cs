
using MinimalAPI.Dominio.Interfaces;
using MinimalAPI.Dominio.Entidades;
using MinimalAPI.DTOs;
using MinimalAPI.Infraestrutura.Db;


namespace MinimalAPI.Dominio.Servicos;

public class AdministradorServico : IAdministradorServico
{
    private readonly DbContexto _contexto;

    public AdministradorServico(DbContexto contexto)
    {
        _contexto = contexto;
    }

    public Administrador Incluir(Administrador administador)
    {
        _contexto.Administradores.Add(administador);
        _contexto.SaveChanges();

        return administador;
    }

    public Administrador? Login (LoginDTO loginDTO)
    {
        var adm = _contexto.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
       
        return  adm;
       
    }

    public List<Administrador> Todos(int? pagina)
    {
        var query = _contexto.Administradores.AsQueryable();

        //paginação

        int itensPorPagina = 10;

        if(pagina != null)
        
            query = query.Skip(((int)pagina - 1)* itensPorPagina).Take(itensPorPagina);
    
        

        return query.ToList();
    }

     public Administrador? BuscaPorId(int id)
    {
        return _contexto.Administradores.Where(v => v.Id == id).FirstOrDefault();
    }

    }

