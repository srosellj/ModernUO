using ModernUO.Serialization;

namespace Server.Mobiles
{
    [SerializationGenerator(0, false)]
    public partial class Gorilla : BaseCreature
    {
        [Constructible]
        public Gorilla() : base(AIType.AI_Animal, FightMode.Aggressor)
        {
            Body = 0x1D;
            BaseSoundID = 0x9E;

            SetStr(53, 95);
            SetDex(36, 55);
            SetInt(36, 60);

            SetHits(38, 51);
            SetMana(0);

            SetDamage(Core.T2A ? 2 : 4, Core.T2A ? 12 : 10);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 20, 25);
            SetResistance(ResistanceType.Fire, 5, 10);
            SetResistance(ResistanceType.Cold, 10, 15);

            SetSkill(SkillName.MagicResist, Core.T2A ? 43.0 : 45.1, Core.T2A ? 58.0 : 60.0);
            SetSkill(SkillName.Tactics, Core.T2A ? 43.0 : 43.3, 58.0);
            SetSkill(SkillName.Wrestling, Core.T2A ? 43.0 : 43.3, 58.0);

            Fame = 450;
            Karma = 0;

            VirtualArmor = 20;

            Tamable = true;
            ControlSlots = 1;
            MinTameSkill = Core.T2A ? 5.0 : -18.9;
        }

        public override string CorpseName => "a gorilla corpse";
        public override string DefaultName => "a gorilla";

        public override int Meat => Core.T2A ? 6 : 1;
        public override int Hides => 6;
        public override FoodType FavoriteFood => FoodType.FruitsAndVeggies | FoodType.GrainsAndHay;
    }
}
