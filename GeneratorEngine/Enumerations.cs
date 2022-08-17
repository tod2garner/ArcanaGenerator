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
        Instant = 100,
        OneRound = 101,
        OneMinute = 300,
        TenMinutes = 500,
        OneHour = 1000,
        EightHours = 2000,
        UntilNextShortRest = 3000,
        UntilNextLongRest = 4000,
        OneDay = 5000,
        OneMonth = 10000
    }

    public enum RangeType
    {
        Self,
        Melee,
        Distance //Value is adjusted later by actual distance, not built-in here
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
        AttackRoll = 100,
        SavingThrow = 125,
        CannotMiss = 250
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
        StraightLine = 100,
        OverheadArcing = 101,
        Meteor = 102,
        Rolling = 80,
        Bouncing = 125,
        Chaining = 150,
        Piercing = 151,
        Splitting = 152,
        Homing = 175
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
        Piercing = 100,
        Slashing = 101,
        Bludgeoning = 102,
        Necrotic = 130,
        Fire = 131,
        Cold = 150,
        Lightning = 151,
        Thunder = 152,
        Acid = 153,
        Poison = 154,
        Psychic = 160,
        Radiant = 200,
        Force = 201
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
