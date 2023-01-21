using System.ComponentModel.DataAnnotations.Schema;
using Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace Entities.Entities;

public class ApplicationUser : IdentityUser
{
    [Column("USR_Cpf")]
    public string Cpf { get; set; }

    [Column("USR_Type")]
    public UserType? Type { get; set; }
}