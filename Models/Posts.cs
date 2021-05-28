using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPostApi.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "The title can only be 100 characters in length.")]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
    }
}
