
namespace DFKCSharp.DFK;
public static class Constants
{
    public static List<string> Classes { get; } = new()
    {
        "Warrior",
        "Knight",
        "Thief",
        "Archer",
        "Priest",
        "Wizard",
        "Monk",
        "Pirate",
        "Berserker",
        "Seer",
        "Legionnaire",
        "Scholar",
        "Paladin",
        "DarkKnight",
        "Summoner",
        "Ninja",
        "Shapeshifter",
        "Bard",
        "Dragoon",
        "Sage",
        "Spellbow",
        "DreadKnight"
    };
	public static string GetStats(int id) => id switch 
    {
		0 => "Strength",
		1 => "Dexterity",
		2 => "Agility",
		3 => "Vitality",
		4 => "Endurance",
		5 => "Intelligence",
		6 => "Wisdom",
		_ => "Luck"
	};
    public static string GetClass(int id) => id switch {
        0 => "Warrior",
        1 => "Knight",
        2 => "Thief",
        3 => "Archer",
        4 => "Priest",
        5 => "Wizard",
        6 => "Monk",
        7 => "Pirate",
        8 => "Berserker",
        9 => "Seer",
        10 => "Legionnaire",
        11 => "Scholar",
        16 => "Paladin",
        17 => "DarkKnight",
        18 => "Summoner",
        19 => "Ninja",
        20 => "Shapeshifter",
        21 => "Bard",
        24 => "Dragoon",
        25 => "Sage",
        26 => "Spellbow",
        _ => "DreadKnight"
    };
    public static string GetProfession(int id) => id switch
    {
        0 => "mining",
        2 => "gardening",
        4 => "fishing",
        _ => "foraging"
    };
    public static string GetStatBoost(int id) => id switch
	{
		0 => "STR",
		2 => "AGI",
        4 => "INT",
        6 => "WIS",
        8 => "LCK",
        10 => "VIT",
        12 => "END",
        _ => "DEX",
    };
}