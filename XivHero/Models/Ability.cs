﻿namespace XivHero.Models;

public class Ability
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Name { get; set; }

    public static readonly Dictionary<string, List<string>> AbilityNamesByJob = new()
    {
        {
            "Astrologian",
            new()
            {
                "Malefic",
                "Benefic",
                "Combust",
                "Lightspeed",
                "Helios",
                "Ascend",
                "Essential_Dignity",
                "Benefic_II",
                "Play",
                "Draw",
                "Undraw",
                "Aspected_Benefic",
                "Redraw",
                "Aspected_Helios",
                "Gravity",
                "Combust_II",
                "Divination",
                "Synastry",
                "Astrodyne",
                "Malefic_II",
                "Collective_Unconscious",
                "Celestial_Opposition",
                "Earthly_Star",
                "Stellar_Detonation",
                "Malefic_III",
                "Minor_Arcana",
                "Crown_Play",
                "Combust_III",
                "Malefic_IV",
                "Celestial_Intersection",
                "Horoscope",
                "Neutral_Sect",
                "Gravity_II",
                "Exaltation",
                "Macrocosmos",
                "Microcosmos"
            }
        },
        {
            "Bard",
            new()
            {
                "Heavy_Shot",
                "Straight_Shot",
                "Raging_Strikes",
                "Venomous_Bite",
                "Bloodletter",
                "Repelling_Shot",
                "Quick_Nock",
                "Windbite",
                "Mage_s_Ballad",
                "The_Warden_s_Paean",
                "Barrage",
                "Army_s_Paeon",
                "Rain_of_Death",
                "Battle_Voice",
                "The_Wanderer_s_Minuet",
                "Pitch_Perfect",
                "Empyreal_Arrow",
                "Iron_Jaws",
                "Sidewinder",
                "Troubadour",
                "Caustic_Bite",
                "Stormbite",
                "Nature_s_Minne",
                "Refulgent_Arrow",
                "Shadowbite",
                "Burst_Shot",
                "Apex_Arrow",
                "Ladonsbite",
                "Blast_Arrow",
                "Radiant_Finale"
            }
        },
        {
            "Black Mage",
            new()
            {
                "Blizzard",
                "Fire",
                "Transpose",
                "Thunder",
                "Blizzard_II",
                "Scathe",
                "Fire_II",
                "Thunder_II",
                "Manaward",
                "Manafont",
                "Fire_III",
                "Blizzard_III",
                "Freeze",
                "Thunder_III",
                "Aetherial_Manipulation",
                "Flare",
                "Ley_Lines",
                "Sharpcast",
                "Blizzard_IV",
                "Fire_IV",
                "Between_the_Lines",
                "Thunder_IV",
                "Triplecast",
                "Foul",
                "Despair",
                "Umbral_Soul",
                "Xenoglossy",
                "High_Fire_II",
                "High_Blizzard_II",
                "Amplifier",
                "Paradox"
            }
        },
        {
            "Dancer",
            new()
            {
                "Cascade",
                "Fountain",
                "Windmill",
                "Standard_Step",
                "Standard_Finish",
                "Reverse_Cascade",
                "Bladeshower",
                "Fan_Dance",
                "Rising_Windmill",
                "Fountainfall",
                "Bloodshower",
                "Fan_Dance_II",
                "En_Avant",
                "Curing_Waltz",
                "Shield_Samba",
                "Closed_Position",
                "Ending",
                "Devilment",
                "Fan_Dance_III",
                "Technical_Step",
                "Technical_Finish",
                "Flourish",
                "Saber_Dance",
                "Improvisation",
                "Improvised_Finish",
                "Tillana",
                "Fan_Dance_IV",
                "Starfall_Dance",
                "Emboite",
                "Entrechat",
                "Jete",
                "Pirouette"
            }
        },
        {
            "Dark Knight",
            new()
            {
                "Hard_Slash",
                "Syphon_Strike",
                "Unleash",
                "Grit",
                "Unmend",
                "Souleater",
                "Flood_of_Darkness",
                "Blood_Weapon",
                "Shadow_Wall",
                "Edge_of_Darkness",
                "Dark_Mind",
                "Living_Dead",
                "Salted_Earth",
                "Plunge",
                "Abyssal_Drain",
                "Carve_and_Spit",
                "Bloodspiller",
                "Quietus",
                "Delerium",
                "The_Blackest_Night",
                "Stalwart_Soul",
                "Flood_of_Darkness",
                "Edge_of_Shadow",
                "Dark_Missionary",
                "Living_Shadow",
                "Oblation",
                "Salt_and_Darkness",
                "Shadowbringer"
            }
        },
        {
            "Dragoon",
            new()
            {
                "True_Thrust",
                "Vorpal_Thrust",
                "Life_Surge",
                "Piercing_Talon",
                "Disembowel",
                "Full_Thrust",
                "Jump",
                "Lance_Charge",
                "Elusive_Jump",
                "Doom_Spike",
                "Spineshatter_Dive",
                "Chaos_Thrust",
                "Dragonfire_Dive",
                "Battle_Litany",
                "Fang_and_Claw",
                "Wheeling_Thrust",
                "Geirskogul",
                "Sonic_Thrust",
                "Dragon_Sight",
                "Mirage_Dive",
                "Nastrond",
                "Coerthan_Torment",
                "High_Jump",
                "Raiden_Thrust",
                "Stardiver",
                "Draconian_Fury",
                "Heavens__Thrust",
                "Chaotic_Spring",
                "Wyrmwind_Thrust"
            }
        },
        {
            "Gunbreaker",
            new()
            {
                "Keen_Edge",
                "No_Mercy",
                "Brutal_Shell",
                "Camouflage",
                "Demon_Slice",
                "Royal_Guard",
                "Lightning_Shot",
                "Danger_Zone",
                "Solid_Barrel",
                "Burst_Strike",
                "Nebula",
                "Demon_Slaughter",
                "Aurora",
                "Superbolide",
                "Sonic_Break",
                "Rough_Divide",
                "Gnashing_Fang",
                "Savage_Claw",
                "Wicked_Talon",
                "Bow_Shock",
                "Heart_of_Light",
                "Heart_of_Stone",
                "Continuation",
                "Jugular_Rip",
                "Abdomen_Tear",
                "Eye_Gouge",
                "Fated_Circle",
                "Bloodfest",
                "Blasting_Zone",
                "Heart_of_Corundum",
                "Hypervelocity",
                "Double_Down"
            }
        },
        {
            "Machinist",
            new()
            {
                "Split_Shot",
                "Slug_Shot",
                "Hot_Shot",
                "Reassemble",
                "Gauss_Round",
                "Spread_Shot",
                "Clean_Shot",
                "Hypercharge",
                "Heat_Blast",
                "Rook_Autoturret",
                "Rook_Overdrive",
                "Rook_Overload",
                "Detonator",
                "Wildfire",
                "Ricochet",
                "Auto_Crossbow",
                "Heated_Split_Shot",
                "Tactician",
                "Drill",
                "Heated_Slug_Shot",
                "Heated_Clean_Shot",
                "Barrel_Stabilizer",
                "Flamethrower",
                "Bioblaster",
                "Air_Anchor",
                "Automaton_Queen",
                "Queen_Overdrive",
                "Arm_Punch",
                "Roller_Dash",
                "Pile_Bunker",
                "Scattergun",
                "Crowned_Collider",
                "Chain_Saw"
            }
        },
        {
            "Monk",
            new()
            {
                "Bootshine",
                "True_Strike",
                "Snap_Punch",
                "Meditation",
                "Twin_Snakes",
                "Arm_of_the_Destroyer",
                "Demolish",
                "Rockbreaker",
                "Thunderclap",
                "Mantra",
                "Four_point_Fury",
                "Perfect_Balance",
                "Dragon_Kick",
                "Form_Shift",
                "Tornado_Kick",
                "Elixir_Field",
                "Masterful_Blitz",
                "Flint_Strike",
                "Celestial_Revolution",
                "Riddle_of_Earth",
                "Riddle_of_Fire",
                "Brotherhood",
                "Enlightenment",
                "Anatman",
                "Six_sided_Star",
                "Shadow_of_the_Destroyer",
                "Rising_Phoenix",
                "Phantom_Rush"
            }
        },
        {
            "Ninja",
            new()
            {
                "Spinning_Edge",
                "Shade_Shift",
                "Gust_Slash",
                "Hide",
                "Throwing_Dagger",
                "Mug",
                "Trick_Attack",
                "Aeolian_Edge",
                "Ten",
                "Ninjutsu",
                "Chi",
                "Death_Blossom",
                "Assassinate",
                "Shukuchi",
                "Jin",
                "Kassatsu",
                "Hakke_Mujinsatsu",
                "Armor_Crush",
                "Dream_Within_a_Dream",
                "Huraijin",
                "Hellfrog_Medium",
                "Bhavacakra",
                "Ten_Chi_Jin",
                "Meisui",
                "Bunshin",
                "Phantom_Kamaitachi",
                "Hollow_Nozuchi",
                "Forked_Raiju",
                "Fleeting_Raiju",
                "Fuma_Shuriken",
                "Rabbit_Medium",
                "Katon",
                "Raiton",
                "Hyoton",
                "Huton",
                "Doton",
                "Suiton",
                "Goka_Mekkyaku",
                "Hyosho_Ranryu"
            }
        },
        {
            "Paladin",
            new()
            {
                "Fast_Blade",
                "Fight_or_Flight",
                "Riot_Blade",
                "Total_Eclipse",
                "Shield_Bash",
                "Iron_Will",
                "Shield_Lob",
                "Rage_of_Halone",
                "Spirits_Within",
                "Sheltron",
                "Sentinel",
                "Prominence",
                "Cover",
                "Circle_of_Scorn",
                "Hallowed_Ground",
                "Goring_Blade",
                "Divine_Veil",
                "Clemency",
                "Royal_Authority",
                "Intervention",
                "Holy_Spirit",
                "Requiescat",
                "Passage_of_Arms",
                "Holy_Circle",
                "Intervene",
                "Atonement",
                "Confiteor",
                "Holy_Sheltron",
                "Expiacion",
                "Blade_of_Faith",
                "Blade_of_Truth",
                "Blade_of_Valor"
            }
        },
        {
            "Reaper",
            new()
            {
                "Slice",
                "Waxing_Slice",
                "Shadow_of_Death",
                "Harpe",
                "Hell_s_Ingress",
                "Hell_s_Egress",
                "Spinning_Scythe",
                "Infernal_Slice",
                "Arcane_Crest",
                "Nightmare_Scythe",
                "Blood_Stalk",
                "Grim_Swathe",
                "Soul_Slice",
                "Soul_Scythe",
                "Gibbet",
                "Gallows",
                "Guillotine",
                "Unveiled_Gibbet",
                "Unveiled_Gallows",
                "Arcane_Circle",
                "Regress",
                "Gluttony",
                "Enshroud",
                "Void_Reaping",
                "Cross_Reaping",
                "Grim_Reaping",
                "Soulsow",
                "Harvest_Moon",
                "Lemure_s_Slice",
                "Lemure_s_Scythe",
                "Plentiful_Harvest",
                "Communio"
            }
        },
        {
            "Red Mage",
            new()
            {
                "Riposte",
                "Enchanted_Riposte",
                "Jolt",
                "Verthunder",
                "Corps_a_corps",
                "Veraero",
                "Scatter",
                "Verthunder_II",
                "Veraero_II",
                "Verfire",
                "Verstone",
                "Zwerchhau",
                "Enchanted_Zwerchhau",
                "Engagement",
                "Displacement",
                "Fleche",
                "Redoublement",
                "Acceleration",
                "Enchanted_Redoublement",
                "Moulinet",
                "Enchanted_Moulinet",
                "Vercure",
                "Contre_Sixte",
                "Embolden",
                "Manafication",
                "Jolt_II",
                "Verraise",
                "Impact",
                "Verflare",
                "Verholy",
                "Reprise",
                "Enchanted_Reprise",
                "Scorch",
                "Verthunder_III",
                "Veraero_III",
                "Magick_Barrier",
                "Resolution",
            }
        },
        {
            "Sage",
            new()
            {
                "Dosis",
                "Diagnosis",
                "Kardia",
                "Prognosis",
                "Egeiro",
                "Physis",
                "Phlegma",
                "Eukrasia",
                "Eukrasian_Diagnosis",
                "Eukrasian_Prognosis",
                "Eukrasian_Dosis",
                "Soteria",
                "Icarus",
                "Druochole",
                "Dyskrasia",
                "Kerachole",
                "Ixochole",
                "Zoe",
                "Pepsis",
                "Physis_II",
                "Taurochole",
                "Toxikon",
                "Haima",
                "Dosis_II",
                "Phlegma_II",
                "Eukrasian_Dosis_II",
                "Rhizomata",
                "Holos",
                "Panhaima",
                "Dosis_III",
                "Phlegma_III",
                "Eukrasian_Dosis_III",
                "Dyskrasia_II",
                "Toxikon_II",
                "Krasis",
                "Pneuma"
            }
        },
        {
            "Samurai",
            new()
            {
                "Hakaze",
                "Jinpu",
                "Third_Eye",
                "Enpi",
                "Shifu",
                "Fuga",
                "Gekko",
                "Iaijutsu",
                "Mangetsu",
                "Kasha",
                "Oka",
                "Yukikaze",
                "Meikyo_Shisui",
                "Hissatsu_Kaiten",
                "Hissatsu_Gyoten",
                "Hissatsu_Yaten",
                "Meditate",
                "Hissatsu_Shinten",
                "Hissatsu_Kyuten",
                "Ikishoten",
                "Hagakure",
                "Hissatsu_Guren",
                "Hissatsu_Senei",
                "Tsubame_gaeshi",
                "Shoha",
                "Shoha_II",
                "Fuko",
                "Ogi_Namikiri",
                "Kaeshi_Namikiri",
                "Higanbana",
                "Tenka_Goken",
                "Midare_Setsugekka",
                "Kaeshi_Higanbana",
                "Kaeshi_Goken",
                "Kaeshi_Setsugekka"
            }
        },
        {
            "Scholar",
            new()
            {
                "Ruin",
                "Bio",
                "Physick",
                "Summon_Eos",
                "Summon_Selene",
                "Resurrection",
                "Bio_II",
                "Adloquium",
                "Succor",
                "Ruin_II",
                "Aetherflow",
                "Lustrate",
                "Energy_Drain",
                "Art_of_War",
                "Sacred_Soil",
                "Indomitability",
                "Broil",
                "Deployment_Tactics",
                "Emergency_Tactics",
                "Dissipation",
                "Excogitation",
                "Broil_II",
                "Chain_Stratagem",
                "Biolysis",
                "Broil_III",
                "Recitation",
                "Summon_Seraph",
                "Broil_IV",
                "Art_of_War_II",
                "Protraction",
                "Expedient",
                "Whispering_Dawn",
                "Fey_Illumination",
                "Aetherpact",
                "Dissolve_Union",
                "Fey_Blessing",
                "Consolation"
            }
        },
        {
            "Summoner",
            new()
            {
                "Ruin",
                "Summon_Carbuncle",
                "Radiant_Aegis",
                "Physick",
                "Aethercharge",
                "Summon_Ruby",
                "Gemshine",
                "Ruby_Ruin",
                "Energy_Drain",
                "Fester",
                "Resurrection",
                "Summon_Topaz",
                "Topaz_Ruin",
                "Summon_Emerald",
                "Emerald_Ruin",
                "Outburst",
                "Precious_Brilliance",
                "Ruby_Outburst",
                "Topaz_Outburst",
                "Emerald_Outburst",
                "Summon_Ifrit",
                "Ruby_Ruin_II",
                "Topaz_Ruin_II",
                "Emerald_Ruin_II",
                "Summon_Titan",
                "Ruin_II",
                "Painflare",
                "Summon_Garuda",
                "Energy_Siphon",
                "Ruin_III",
                "Ruby_Ruin_III",
                "Topaz_Ruin_III",
                "Emerald_Ruin_III",
                "Dreadwyrm_Trance",
                "Astral_Impulse",
                "Astral_Flare",
                "Deathflare",
                "Astral_Flow",
                "Ruin_IV",
                "Searing_Light",
                "Summon_Bahamut",
                "Wyrmwave",
                "Enkindle_Bahamut",
                "Akh_Morn",
                "Ruby_Rite",
                "Topaz_Rite",
                "Emerald_Rite",
                "Tri_disaster",
                "Ruby_Disaster",
                "Topaz_Disaster",
                "Emerald_Disaster",
                "Fountain_of_Fire",
                "Brand_of_Purgatory",
                "Enkindle_Phoenix",
                "Everlasting_Flight",
                "Scarlet_Flame",
                "Revelation",
                "Summon_Phoenix",
                "Rekindle",
                "Ruby_Catastrophe",
                "Topaz_Catastrophe",
                "Emerald_Catastrophe",
                "Crimson_Strike",
                "Mountain_Buster",
                "Slipstream",
                "Summon_Ifrit_II",
                "Summon_Titan_II",
                "Summon_Garuda_II"
            }
        },
        {
            "White Mage",
            new()
            {
                "Stone",
                "Cure",
                "Aero",
                "Medica",
                "Raise",
                "Stone_II",
                "Cure_II",
                "Presence_of_Mind",
                "Regen",
                "Cure_III",
                "Holy",
                "Aero_II",
                "Medica_II",
                "Afflatus_Solace",
                "Asylum",
                "Thin_Air",
                "Tetragrammaton",
                "Stone_IV",
                "Divine_Benison",
                "Plenary_Indulgence",
                "Dia",
                "Glare",
                "Afflatus_Misery",
                "Afflatus_Rapture",
                "Temperance",
                "Glare_III",
                "Holy_III",
                "Aquaveil",
                "Liturgy_of_the_Bell"
            }
        },
        {
            "Consumables",
            new()
            {
                "Potion_of_Dexterity",
                "Potion_of_Intelligence",
                "Potion_of_Mind",
                "Potion_of_Strength",
                "Potion_of_Vitality"
            }
        },
        {
            "Healer Actions",
            new()
            {
                "Repose",
                "Esuna",
                "Swiftcast",
                "Lucid_Dreaming",
                "Surecast",
                "Rescue"
            }
        },
        {
            "Magical Ranged DPS Actions",
            new()
            {
                "Addle",
                "Swiftcast",
                "Lucid_Dreaming",
                "Surecast"
            }
        },
        {
            "Melee DPS Actions",
            new()
            {
                "Second_Wind",
                "Leg_Sweep",
                "Bloodbath",
                "Feint",
                "Arm_s_Length",
                "True_North",
                "Limit_Break"
            }
        },
        {
            "Physical Ranged DPS Actions",
            new()
            {
                "Leg_Graze",
                "Second_Wind",
                "Foot_Graze",
                "Peloton",
                "Head_Graze",
                "Arm_s_Length",
                "Limit_Break"
            }
        },
        {
            "Tank Actions",
            new()
            {
                "Rampart",
                "Low_Blow",
                "Provoke",
                "Interject",
                "Reprisal",
                "Arm_s_Length",
                "Shirk",
                "Limit_Break"
            }
        },
    };
}

