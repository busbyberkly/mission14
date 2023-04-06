using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission14API.Data
{
    public class MovieCollection
    {
        [Key]
        public int MovieID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public string Edited { get; set; }
        public string Lentto { get; set; }
        public string Notes { get; set; }
    }
}
