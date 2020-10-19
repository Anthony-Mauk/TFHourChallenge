using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourChallenge.Data
{
    public class Like
    {
        public int Liked { get; set; }
        [ForeignKey(nameof(Liked))]
        public virtual Post LikedPost { get; set; }
        public int LikerID { get; set; }
        [ForeignKey(nameof(LikerID))]
        public virtual User Liker { get; set; }
    }
}

