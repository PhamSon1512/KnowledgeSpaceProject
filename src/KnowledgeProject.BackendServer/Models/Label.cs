﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KnowledgeSpaceProject_BackendServer.Models
{
    [Table("Labels")]
    public class Label
    {
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
    }
}