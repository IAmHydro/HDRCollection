using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Spells;

namespace AddonTemplate
{
    public static class SpellManager
    {
        // You will need to edit the types of spells you have for each champ as they
        // don't have the same type for each champ, for example Xerath Q is chargeable,
        // right now it's  set to Active.
        public static Spell.Skillshot Q { get; private set; }
        public static Spell.Targeted W { get; private set; }
        public static Spell.Skillshot E { get; private set; }
        public static Spell.Targeted R { get; private set; }

        static SpellManager()
        {
            foreach (var spellInfo in SpellDatabase.GetSpellInfoList("Caitlyn"))
            {
                switch (spellInfo.Slot)
                {
                    case SpellSlot.Unknown:
                        break;
                    case SpellSlot.Q:
                        Q = new Spell.Skillshot(SpellSlot.Q, (uint)spellInfo.Range, SkillShotType.Linear, (int)spellInfo.Delay, (int)spellInfo.MissileSpeed, (int)spellInfo.Radius, DamageType.Physical);
                        break;
                    case SpellSlot.W:
                        W = new Spell.Targeted(SpellSlot.Q, (uint)spellInfo.Range);
                        Extensions.
                        break;
                    case SpellSlot.E:
                        E = new Spell.Skillshot(SpellSlot.E, (uint)spellInfo.Range, SkillShotType.Linear, (int)spellInfo.Delay, (int)spellInfo.MissileSpeed, (int)spellInfo.Radius, DamageType.Physical);
                        break;
                    case SpellSlot.R:
                        R = new Spell.Targeted(SpellSlot.R, (uint)spellInfo.Range, DamageType.Physical);
                        break;
                    case SpellSlot.Summoner1:
                        break;
                    case SpellSlot.Summoner2:
                        break;
                    case SpellSlot.Item1:
                        break;
                    case SpellSlot.Item2:
                        break;
                    case SpellSlot.Item3:
                        break;
                    case SpellSlot.Item4:
                        break;
                    case SpellSlot.Item5:
                        break;
                    case SpellSlot.Item6:
                        break;
                    case SpellSlot.Trinket:
                        break;
                    case SpellSlot.Recall:
                        break;
                    case SpellSlot.OathSworn:
                        break;
                    case SpellSlot.CapturePoint:
                        break;
                    case SpellSlot.Internal:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
            }
            ;

            // Initialize spells
            

            // TODO: Uncomment the other spells to initialize them
            //W = new Spell.Chargeable(SpellSlot.W);
            //E = new Spell.Skillshot(SpellSlot.E);
            //R = new Spell.Targeted(SpellSlot.R);
        }

        public static void Initialize()
        {
            // Let the static initializer do the job, this way we avoid multiple init calls aswell
        }
    }
}
