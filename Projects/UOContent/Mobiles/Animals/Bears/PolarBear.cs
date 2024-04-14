using ModernUO.Serialization;

namespace Server.Mobiles
{
    [TypeAlias("Server.Mobiles.Polarbear")]
    [SerializationGenerator(0, false)]
    public partial class PolarBear : BaseCreature
    {
        [Constructible]
        public PolarBear() : base(AIType.AI_Animal, FightMode.Aggressor)
        {
            Body = 213;
            BaseSoundID = 0xA3;

            SetStr(116, 140);
            SetDex(81, 105);
            SetInt(26, 50);

            SetHits(70, 84);
            SetMana(0);

            SetDamage(Core.T2A ? 5 : 7, Core.T2A ? 14 : 12);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 25, 35);
            SetResistance(ResistanceType.Cold, 60, 80);
            SetResistance(ResistanceType.Poison, 15, 25);
            SetResistance(ResistanceType.Energy, 10, 15);

            SetSkill(SkillName.MagicResist, 45.1, 60.0);
            SetSkill(SkillName.Tactics, Core.T2A ? 70.0 : 60.1, Core.T2A ? 100.0 : 90.0);
            SetSkill(SkillName.Wrestling, Core.T2A ? 60.0 : 45.1, Core.T2A ? 90.0 : 70.0);

            Fame = 1500;
            Karma = 0;

            VirtualArmor = 18;

            Tamable = true;
            ControlSlots = 1;
            MinTameSkill = Core.T2A ? 50.0 : 35.1;
        }

        public override string CorpseName => "a polar bear corpse";
        public override string DefaultName => "a polar bear";

        public override int Meat => Core.T2A ? 11 : 2;
        public override int Hides => 16;
        public override FoodType FavoriteFood => FoodType.Fish | FoodType.FruitsAndVeggies | FoodType.Meat;
        public override PackInstinct PackInstinct => PackInstinct.Bear;
    }
}
