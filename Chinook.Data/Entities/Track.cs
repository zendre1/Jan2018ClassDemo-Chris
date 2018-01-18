﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion
namespace Chinook.Data.Entities
{
    [Table("Tracks")]
    public class Track
    {
        [Key]
        public int TrackId { get; set; }

        [StringLength(200, ErrorMessage = "Track Title exceeds 200 characters!")]
        public string Name { get; set; }
        public int AlbumId { get; set; }
        public int MediaTypeId { get; set; }
        public int GenreId { get; set; }
        [StringLength(220, ErrorMessage = "Composer exceeds 220 characters!")]
        public string Composer { get; set; }
        public int Milliseconds { get; set; }
        public int Bytes { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
