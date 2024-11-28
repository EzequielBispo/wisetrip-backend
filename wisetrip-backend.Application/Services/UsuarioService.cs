using System;

namespace wisetrip_backend.Application.Services;

public class UsuarioService
{
private readonly IUsuarioRepository _usuarioRepository;

        public SitesApplicationService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public UsuarioEntity? DeletarUsuario(int id)
        {
            return _usuarioRepository.DeletarUsuario(id);
        }

        public UsuarioEntity? EditarUsuario(SitesEntity entity)
        {
            return _usuarioRepository.EditarUsuario(entity);
        }

        public UsuarioEntity? ObterUsuarioPorId(int id)
        {
            return _usuarioRepository.ObterUsuarioPorId(id);
        }

        public IEnumerable<UsuarioEntity> BuscarTodosUsuarios()
        {
            return _usuarioRepository.BuscarTodosUsuarios();
        }

        public UsuarioEntity? SalvarUsuario(SitesEntity entity)
        {
            return _usuarioRepository.SalvarUsuario(entity);
        }

        public IEnumerable<UsuarioEntity> ObterSitesUsuario()
        {
            throw new NotImplementedException();
        }
}
