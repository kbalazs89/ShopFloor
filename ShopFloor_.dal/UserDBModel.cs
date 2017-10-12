using System;
using System.ComponentModel.DataAnnotations;

namespace ShopFloor.dal
{
    public class UserDBModel
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Cash { get; set; }
        public bool Admin { get; set; }
    }
}