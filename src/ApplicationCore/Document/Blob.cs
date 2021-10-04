using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApplicationCore.Document
{
    [Table("Blob")]
    public class Blob : BaseEntity
    {      
        public virtual byte[] Data { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public Guid? ReferenceId { get; set; }
        public int? BlockNo { get; set; }
        public virtual byte[] Thumbnail { get; set; }

    }
}
