﻿using System.ComponentModel.DataAnnotations;

namespace BorrowLend.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Item name")]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Borrower { get; set; }

        [Required]
        public string Lender { get; set; }
    }
}
