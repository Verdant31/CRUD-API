//Aqui estamos criando a estrutura da tabela que armazena as informações DO USUARIO.

namespace Api.Domain.Entities
{
  public class UserEntity : BaseEntity
  {
    public string Name { get; set; }

    public string Email { get; set; }

  }
}
