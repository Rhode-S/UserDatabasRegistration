using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UserDatabasRegistration.Models
{
    /// <summary>
    /// Select Class Library (.NET Core) Project Template.
    /// Provide a Project Name as UserDatabasResgistration.
    /// Install the below Nuget Packages related to the Entity Framework Core:
    /// Microsoft.EntityFrameworkCore.
    /// Microsoft.EntityFrameworkCore.SqlServer.
    /// Microsoft.EntityFrameworkCore.Tools.
    /// Create Class DatabasRegistration.
    /// Create Folder DataContext for Migration with Add-Migration/Update-Database
    /// </summary>
    [Table("DatabasRegistration", Schema = "dbo")]
    public class DatabasRegistration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "InformtionUtilisateur Id")]
        public int UserID { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Name")]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Name")]
        public string LastName { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Contact")]
        public string Contact { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Genre")]
        public string Gender { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Name")]
        public string Username { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}    
