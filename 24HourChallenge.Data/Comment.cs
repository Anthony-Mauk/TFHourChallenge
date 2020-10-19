using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourChallenge.Data
{
    public class Comment
    {
        [ForeignKey("Id")] [Required] public int Id { get; set; }
        [Required] public string Text { get; set; }
        [ForeignKey("Author")] [Required] public User Author { get; set; }
        [Required] public Post CommentPost { get; set; }
    }
}
