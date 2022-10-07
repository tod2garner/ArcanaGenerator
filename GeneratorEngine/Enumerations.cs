namespace GeneratorEngine
{
    public enum EffectType
    {
        Penalty = 0,
        Damage,
        Buff,
        Debuff,
        Utility,
    }

    public enum SchoolOfMagic
    {
        Any = 0,
        Abjuration,
        Conjuration,
        Divination,
        Enchantment, 
        Evocation,
        Illusion,
        Necromancy,
        Transmutation
    }

    public enum CastTime
    {
        Action,
        BonusAction,
        Reaction,
        OneMinute,
        OneHour
    }

    public enum Duration
    {
        Instant,
        OneRound,
        OneMinute,
        TenMinutes,
        OneHour,
        EightHours,
        UntilNextShortRest,
        UntilNextLongRest,
        OneDay,
        OneMonth
    }

    public enum RangeType
    {
        Self,
        Melee,
        Distance
    }

    public enum DeliveryType
    {
        Touch,
        None,//Like polymorph or hideous laughter, no visible delivery, it "just happens"
        AreaOfEffect,
        Projectile,
        AreaProjectile,
        Weapon
    }

    public enum AttackOrSavingThrow
    {
        AttackRoll,
        SavingThrow,
        CannotMiss
    }

    public enum SavingThrowType
    {
        STR,
        DEX,
        CON,
        WIS,
        INT,
        CHA
    }

    public enum ProjectileType
    {
        StraightLine,
        OverheadArcing,
        Meteor,
        GroundLevel,
        Bouncing,
        Chaining,
        Piercing,
        Splitting
    }

    public enum AreaOfEffectShape
    {
        Line,
        Sphere,
        Cube,
        Cylinder,
        Square,
        Cone
    }

    public enum DamageType
    {
        Piercing,
        Slashing,
        Bludgeoning,
        Necrotic,
        Fire,
        Cold,
        Lightning,
        Thunder,
        Acid,
        Poison,
        Psychic,
        Radiant,
        Force
    }

    public enum RepeatType
    {
        None,
        Action,
        BonusAction,
        Free
    }

    public enum DiceSize
    {
        d4 = 2,
        d6 = 3,
        d8 = 4,
        d10 = 5,
        d12 = 6
    }

    public enum PowerLevel
    {
        Minor,
        Lesser,
        Greater,
        Major,
        Random
    }
}
