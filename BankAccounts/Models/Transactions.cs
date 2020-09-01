using System.ComponentModel.DataAnnotations;
using System;
namespace BankAccounts.Models
{

    public class Transaction
    {
        [Key]
        public int TransactionId {get;set;}
        [Required]
        public double Amount {get;set;}
        public int UserId { get; set; }
        public User Spender {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }

}