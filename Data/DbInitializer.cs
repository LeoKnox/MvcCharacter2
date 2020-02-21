using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcCharacter.Data;
using MvcCharacter.Models;

namespace MvcCharacter.Data
{
    public class DbInitializer
    {
        public static void Initialize(MvcCharacterContext context)
        {
            context.Database.EnsureCreated();

            if (context.Character.Any())
            {
                return;
            }

            var characters = new Character[]
            {
                new Character { Name = "Aelien", Class = "Rogue", Def = 8, Atk = 13 },
                new Character { Name = "Eveehi", Class = "Warrior", Def = 12, Atk = 10 },
                new Character { Name = "Xingu", Class = "Wizard", Def = 7, Atk = 17 },
                new Character { Name = "Ynzon", Class = "Knight", Def = 11, Atk = 11 }
            };
            foreach (Character c in characters)
            {
                context.Character.Add(c);
            }
            context.SaveChanges();

            var spells = new Spell[]
            {
                new Spell { SpellName = "Fireblast", Damage = 8 },
                new Spell { SpellName = "Sword Strike", Damage = 4 },
                new Spell { SpellName = "Dagger Cut", Damage = 5 },
                new Spell { SpellName = "Shield Bash", Damage = 2 },
                new Spell { SpellName = "No Shadow Kick", Damage = 3 }
            };
            foreach (Spell s in spells)
            {
                context.Spells.Add(s);
            }
            context.SaveChanges();

            var spellbooks = new SpellBook[]
            {
                new SpellBook { SpellID = 1, CharacterID = 3, Element = Element.Fire },
                new SpellBook { SpellID = 2, CharacterID = 2, Element = Element.Air },
                new SpellBook { SpellID = 2, CharacterID = 4, Element = Element.Water },
                new SpellBook { SpellID = 4, CharacterID = 4, Element = Element.Fire },
                new SpellBook { SpellID = 3, CharacterID = 1, Element = Element.Water },
                new SpellBook { SpellID = 5, CharacterID = 3, Element = Element.Earth }
            };
            context.SaveChanges();
        }
    }
}
