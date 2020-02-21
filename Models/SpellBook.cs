using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCharacter.Models
{
    public enum Element
    {
        Fire, Water, Earth, Air
    }
    public class SpellBook
    {
        public int SpellBookID { get; set; }
        public int SpellID { get; set; }
        public int CharacterID { get; set; }
        public Element Element { get; set; }

        public Spell Spell { get; set; }
        public Character Character { get; set; }
    }
}
