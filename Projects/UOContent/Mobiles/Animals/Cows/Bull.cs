using ModernUO.Serialization;

namespace Server.Mobiles
{
    [SerializationGenerator(0, false)]
    public partial class Bull : BaseCreature
    {
        [Constructible]
        public Bull() : base(AIType.AI_Animal, FightMode.Aggressor)
        {
            Body = Utility.RandomList(0xE8, 0xE9);
            BaseSoundID = 0x64;

            if (Utility.RandomBool())
            {
                Hue = 0x901;
            }

            SetStr(77, 111);
            SetDex(56, 75);
            SetInt(47, 75);

            SetHits(50, 64);
            SetMana(0);

            SetDamage(4, 9);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 25, 30);
            SetResistance(ResistanceType.Cold, 10, 15);

            SetSkill(SkillName.MagicResist, Core.T2A ? 18.0 : 17.6, 25.0);
            SetSkill(SkillName.Tactics, Core.T2A ? 68.0 : 67.6, 85.0);
            SetSkill(SkillName.Wrestling, 40.1, 57.5);

            Fame = 600;
            Karma = 0;

            VirtualArmor = 28;

            Tamable = true;
            ControlSlots = 1;
            MinTameSkill = Core.T2A ? 80.0 : 71.1;
        }

        public override string CorpseName => "a bull corpse";
        public override string DefaultName => "a bull";

        public override int Meat => Core.T2A ? 50 : 10;
        public override int Hides => 15;
        public override FoodType FavoriteFood => FoodType.GrainsAndHay;
        public override PackInstinct PackInstinct => PackInstinct.Bull;
    }
}
