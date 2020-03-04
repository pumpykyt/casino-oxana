using casino_oxana_back.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace casino_oxana_back.Entities
{
    [Table("UserBalance")]
    public class UserBalanceModel
    {
        [Key,ForeignKey("UserOf")]
        public int Id { get; set; }
        [Required]
        public decimal Balance { get; set; }
        [Required]
        public decimal AllWinningsAmount { get; set; }
        [Required]
        public virtual ApplicationUser User { get; set; }
        public string UserId { get; set; }


    }
}