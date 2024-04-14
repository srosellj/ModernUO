using ModernUO.Serialization;

namespace Server.Mobiles
{
    [SerializationGenerator(0, false)]
    public partial class RidableLlama : BaseMount
    {
        public override string DefaultName => "a ridable llama";

        [Constructible]
        public RidableLlama() : base(0xDC, 0x3EA6, AIType.AI_Animal, FightMode.Aggressor
        )
        {
            BaseSoundID = 0x3F3;

            SetStr(21, 49);
            SetDex(56, 75);
            SetInt(16, 30);

            SetHits(15, 27);
            SetMana(0);

            SetDamage(Core.T2A ? 2 : 3, Core.T2A ? 6 : 5);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 10, 15);
            SetResistance(ResistanceType.Fire, 5, 10);
            SetResistance(ResistanceType.Cold, 5, 10);
            SetResistance(ResistanceType.Poison, 5, 10);
            SetResistance(ResistanceType.Energy, 5, 10);

            SetSkill(SkillName.MagicResist, 15.1, 20.0);
            SetSkill(SkillName.Tactics, 19.2, 29.0);
            SetSkill(SkillName.Wrestling, 19.2, 29.0);

            Fame = 300;
            Karma = 0;

            VirtualArmor = Core.T2A ? 16 : 0;

            Tamable = true;
            ControlSlots = 1;
            MinTameSkill = Core.T2A ? 50.0 : 29.1;
        }

        public override int StepsMax => 2560;
        public override string CorpseName => "a llama corpse";

        public override int Meat => Core.T2A ? 7 : 1;
        public override int Hides => 12;
        public override FoodType FavoriteFood => FoodType.FruitsAndVeggies | FoodType.GrainsAndHay;
    }
}
