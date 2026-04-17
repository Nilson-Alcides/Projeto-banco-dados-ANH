using Segundo_App_BancoDados.Models;
using Segundo_App_BancoDados.Repository.Contract;

namespace Segundo_App_BancoDados.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly string _conexaoMySQL;

        public UsuarioRepository(IConfiguration conf)
        {
           _conexaoMySQL = conf.GetConnectionString("ConexaoMySQL");
        }
        public void Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> ObterTodosUsuarios()
        {
            throw new NotImplementedException();
        }

        public Usuario ObterUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
