﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourChallenge.Data
{
    public class Reply : Comment
    {
        [Key]
        public int ReplyID { get; set; }
        [Required]
        public string ReplyComment { get; set; }
        //[ForeignKey(nameof(Comment))]
        //public virtual Comment Comment { get; set; }
    }
}