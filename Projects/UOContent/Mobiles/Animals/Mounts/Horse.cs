using ModernUO.Serialization;

namespace Server.Mobiles
{
    [TypeAlias(
        "Server.Mobiles.BrownHorse",
        "Server.Mobiles.DirtyHorse",
        "Server.Mobiles.GrayHorse",
        "Server.Mobiles.TanHorse"
    )]
    [SerializationGenerator(0, false)]
    public partial class Horse : BaseMount
    {
        private static readonly int[] m_IDs =
        {
            0xC8, 0x3E9F,
            0xE2, 0x3EA0,
            0xE4, 0x3EA1,
            0xCC, 0x3EA2
        };

        public override string DefaultName => "a horse";

        [Constructible]
        public Horse() : base(0xE2, 0x3EA0, AIType.AI_Animal, FightMode.Aggressor)
        {
            var random = Utility.Random(4);

            Body = m_IDs[random * 2];
            ItemID = m_IDs[random * 2 + 1];
            BaseSoundID = 0xA8;

            SetStr(Core.T2A ? 44 : 22, Core.T2A ? 120 : 98);
            SetDex(56, 75);
            SetInt(6, 10);

            SetHits(Core.T2A ? 27 : 28, Core.T2A ? 72 : 45);
            SetMana(0);

            SetDamage(3, 4);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 15, 20);

            SetSkill(SkillName.MagicResist, 25.1, 30.0);
            SetSkill(SkillName.Tactics, 29.3, 44.0);
            SetSkill(SkillName.Wrestling, 29.3, 44.0);

            Fame = 300;
            Karma = 300;

            VirtualArmor = Core.T2A ? 18 : 0;

            Tamable = true;
            ControlSlots = 1;
            MinTameSkill = Core.T2A ? 45.0 : 29.1;
        }

        public override string CorpseName => "a horse corpse";

        public override int Meat => Core.T2A ? 15 : 3;
        public override int Hides => 10;
        public override FoodType FavoriteFood => FoodType.FruitsAndVeggies | FoodType.GrainsAndHay;
    }
}
