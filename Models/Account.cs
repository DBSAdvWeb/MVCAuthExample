using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCAuthExample.Models
{
    public class Account
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Type {get; set;}
        [Column(TypeName = "decimal(18,4)")]
        public decimal Total {get; set;}
    }
}