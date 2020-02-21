using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCharacter.Models
{
    public class Spell
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpellID { get; set; }
        public string SpellName { get; set; }
        public int Damage { get; set; }
    }
}
