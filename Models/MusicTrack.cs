using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RPGHelper.Models
{
    public class MusicTrack
    {
        //foreign id
        [Required]
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser User { get; set; }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        [Required]
        public string URL { get; set; }
    }
}
