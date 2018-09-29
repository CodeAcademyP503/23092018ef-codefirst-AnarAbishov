using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCodeFirst.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(55)]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength:55)]
        public string Surname { get; set; }

        [Required]
        [StringLength(maximumLength: 55)]
        [Index(IsUnique = true)]
        public string PasportNumber { get; set; }
     
    }
}
