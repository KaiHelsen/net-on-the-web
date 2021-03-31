using System;
using System.CodeDom.Compiler;

namespace net_on_the_web.Models
{
    public class RandomNameGenerator
    {
        private static string[] firstNames =
        {
            "Slab",
            "Fridge",
            "Punt",
            "Butch",
            "Bold",
            "Splint",
            "Flint",
            "Bolt",
            "Thick",
            "Blast",
            "Buff",
            "Trunk",
            "Fist",
            "Stump",
            "Smash",
            "Punch",
            "Buck",
            "Dirk",
            "Rip",
            "Slate",
            "Crud",
            "Brick",
            "Gristle",
            "Bob",
            "Lump",
            "Touch",
            "Reef",
            "Big",
            "Smoke",
            "Eat",
            "Hack",
            "Roll",
        };
        private static string[] lastNames =
        {
            "BulkHead",
            "LargeMeat",
            "Speedchunk",
            "Deadlift",
            "Bigflank",
            "ChestHair",
            "Ironstag",
            "Vanderhuge",
            "McRunfast",
            "HardCheese",
            "Drinklots",
            "Slamchest",
            "Rockbone",
            "Beefknob",
            "Lampjaw",
            "Rockgroin",
            "Plankchest",
            "Chunkmen",
            "Hardpec",
            "Steakface",
            "Slabrock",
            "Bonemeal",
            "HardMeat",
            "Slagcheek",
            "Sideiron",
            "McThornbody",
            "Fistcrunch",
            "Hardback",
            "Johnson",
            "Thickneck",
            "Buttsteak",
            "Squatthrust",
            "Beefbroth",
            "Rustrod",
            "BlastBody",
            "McLargeHuge",
            "ManMuscle",
            "Punchbeef",
            "Blowfist",
            "Fizzlebeef",

        };

        public static string generate()
        {
            Random rand = new Random();
            return firstNames[rand.Next(firstNames.Length)] + " " + lastNames[rand.Next(firstNames.Length)];
        }
    }
}