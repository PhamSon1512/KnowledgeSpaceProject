﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KnowledgeSpaceProject_BackendServer.Models
{
    [Table("LabelInKnowledgeBases")]
    public class LabelInKnowledgeBase
    {
        public int KnowledgeBaseId { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string LabelId { get; set; }
    }
}