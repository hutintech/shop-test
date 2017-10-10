﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string URL { get; set; }

        public int DisplayOrder { get; set; }

        [Required]
        public int GroupId { get; set; }

        [ForeignKey("GroupId")]
        public virtual MenuGroup MenuGroup { get; set; }

        public string Target { get; set; }

        public bool Status { get; set; }
    }
}