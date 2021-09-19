using System;
using System.ComponentModel.DataAnnotations;


//Aqui estamos criando a estrutura da tabela de Usuários
namespace Api.Domain.Entities
{
  public abstract class BaseEntity
  {
    [Key]
    public Guid Id { get; set; }

    private DateTime? _createdAt;

    public DateTime? CreatedAt
    {
      get { return _createdAt; }
      set { _createdAt = (value == null) ? DateTime.UtcNow : value; }
    }

    public DateTime? UpdatedAt { get; set; }

  }
}
