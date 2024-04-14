using ModernUO.Serialization;

namespace Server.Mobiles
{
    [SerializationGenerator(0, false)]
    public partial class DesertOstard : BaseMount
    {
        public override string DefaultName => Core.T2A ? "an oclock" : "a desert ostard";

        [Constructible]
        public DesertOstard() : base(0xD2, 0x3EA3, AIType.AI_Animal, FightMode.Aggressor)
        {
            BaseSoundID = 0x270;

            SetStr(94, 170);
            SetDex(56, 75);
            SetInt(6, 10);

            SetHits(Core.T2A ? 57 : 71, Core.T2A ? 102 : 88);
            SetMana(0);

            SetDamage(Core.T2A ? 7 : 5, Core.T2A ? 15 : 11);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 15, 20);
            SetResistance(ResistanceType.Fire, 5, 15);

            SetSkill(SkillName.MagicResist, Core.T2A ? 27.0 : 25.1, Core.T2A ? 32.0 : 30.0);
            SetSkill(SkillName.Tactics, Core.T2A ? 29.0 : 25.3, Core.T2A ? 44.0 : 40.0);
            SetSkill(SkillName.Wrestling, Core.T2A ? 29.0 : 29.3, 44.0);

            Fame = 450;
            Karma = 0;

            VirtualArmor = Core.T2A ? 18 : 0;

            Tamable = true;
            ControlSlots = 1;
            MinTameSkill = Core.T2A ? 45.0 : 29.1;
        }

        public override string CorpseName => "an ostard corpse";

        public override int Meat => Core.T2A ? 15 : 3;
        public override FoodType FavoriteFood => FoodType.FruitsAndVeggies | FoodType.GrainsAndHay;
        public override PackInstinct PackInstinct => PackInstinct.Ostard;
    }
}
