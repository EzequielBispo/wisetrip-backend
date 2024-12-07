using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wisetrip_backend.Infrastructure.Repositories
{
    public class UsuarioRepository(ApplicationContext context) : IRegistroRepository
    {
        private readonly ApplicationContext? _context;

        public UsuarioEntity? Adicionar(UsuarioEntity usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }

        public UsuarioEntity? Editar(UsuarioEntity usuario)
        {
            _context.Usuario.Update(usuario);
            _context.SaveChanges();
            return usuario;
        }

        public UsuarioEntity? ObterPorId(int id)
        {
            return _context.Usuario.Find(id);
        }

        public IEnumerable<UsuarioEntity>? ObterTodos()
        {
            return _context.Usuario.ToList();
        }

        public UsuarioEntity? Remover(int id)
        {
            var usuario = _context.Usuario.Find(id);
            if (usuario != null)
            {
                _context.Usuario.Remove(usuario);
                _context.SaveChanges();
            }
            return usuario;
        }
    }
}
