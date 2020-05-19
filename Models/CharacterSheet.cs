using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RPGHelper.Models
{
    public class CharacterSheet
    {
        public int Id { get; set; }

        //foreign id
        [Required]
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser User { get; set; }

        //basic info
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int Level { get; set; }

        public string Class { get; set; }

        public string Personality { get; set; }

        public int Exp { get; set; }

        //stats
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Condition { get; set; }
        public int Inteligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        //other
        public int ArmorClass { get; set; }

        public int Initative { get; set; }

        public int Hp { get; set; }

        public int HpTemp { get; set; }

        public string Notes { get; set; }
    }
}
