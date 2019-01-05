using BaseMod;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.World.Generation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace SauceMod
{
    public class SauceWorld : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int InfectionIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Micro Biomes"));
            tasks.Insert(InfectionIndex + 1, new PassLegacy("Infection Biome", delegate (GenerationProgress progress)
            {
                for (int k = 0; k < 3; k++)
                {
                    InfectionCave(progress);
                }
            }));
        }
        
        public void InfectionCave()
        {
            Point origin = new Point((int)(Main.maxTilesX * Main.rand.Next(.1f, .9f)), (int)(Main.maxTilesY * Main.rand.Next(.4f, .8f)));
            origin.Y = BaseWorldGen.GetFirstTileFloor(origin.X, origin.Y, true);
            InfectionClear delete = new InfectionClear();
            InfectionCave biome = new InfectionCave();
            delete.Place(origin, WorldGen.structures);
            biome.Place(origin, WorldGen.structures);
        }
    }
    
    public class InfectionClear : MicroBiome
    {
        public override bool Place(Point origin, StructureMap structures)
        {
            //this handles generating the actual tiles, but you still need to add things like treegen etc. I know next to nothing about treegen so you're on your own there, lol.

            Mod mod = SauceMod.instance;
            int biomeRadius = 300;

            Dictionary<Color, int> colorToTile = new Dictionary<Color, int>();
            colorToTile[new Color(0, 255, 0)] = -2;
            colorToTile[Color.Black] = -1; //don't touch when genning				


            Texture2D Infection = mod.GetTexture("WorldGen/SauceWorld_Tiles");

            TexGen gen = BaseWorldGenTex.GetTexGenerator(Infection, colorToTile);
            Point newOrigin = new Point(origin.X, origin.Y); //biomeRadius);

            WorldUtils.Gen(newOrigin, new Shapes.Circle(biomeRadius), Actions.Chain(new GenAction[] //remove all fluids in sphere...
            {
                new Modifiers.RadialDither(biomeRadius - 5, biomeRadius),
                new Actions.SetLiquid(0, 0)
            }));
            WorldUtils.Gen(new Point(origin.X - (gen.width / 2), origin.Y - 20), new Shapes.Rectangle(gen.width, gen.height), Actions.Chain(new GenAction[] //remove all fluids in the volcano...
            {
                new Actions.SetLiquid(0, 0)
            }));
            gen.Generate(origin.X - (gen.width / 2), origin.Y, true, true);

            return true;
        }
    }

    public class InfectionCave : MicroBiome
    {
        public override bool Place(Point origin, StructureMap structures)
        {
            //this handles generating the actual tiles, but you still need to add things like treegen etc. I know next to nothing about treegen so you're on your own there, lol.

            Mod mod = SauceMod.instance;
            int biomeRadius = 300;

            Dictionary<Color, int> colorToTile = new Dictionary<Color, int>();
            colorToTile[new Color(0, 255, 0)] = mod.TileType("InfectedGrowthTissueTile");
            colorToTile[new Color(0, 0, 255)] = -2; //turn into air
            colorToTile[Color.Black] = -1; //don't touch when genning		

            Dictionary<Color, int> colorToWall = new Dictionary<Color, int>();
            colorToWall[new Color(0, 255, 0)] = mod.WallType("CoreWall");
            colorToWall[Color.Black] = -1; //don't touch when genning				
            

            Texture2D Infection = mod.GetTexture("WorldGen/SauceWorld_Tiles");

            Texture2D InfectionWalls = mod.GetTexture("WorldGen/SauceWorld_Walls");

            TexGen gen = BaseWorldGenTex.GetTexGenerator(Infection, colorToTile, InfectionWalls, colorToWall);
            Point newOrigin = new Point(origin.X, origin.Y); //biomeRadius);

            WorldUtils.Gen(newOrigin, new Shapes.Circle(biomeRadius), Actions.Chain(new GenAction[] //remove all fluids in sphere...
            {
                new Modifiers.RadialDither(biomeRadius - 5, biomeRadius),
                new Actions.SetLiquid(0, 0)
            }));
            WorldUtils.Gen(new Point(origin.X - (gen.width / 2), origin.Y - 20), new Shapes.Rectangle(gen.width, gen.height), Actions.Chain(new GenAction[] //remove all fluids in the volcano...
            {
                new Actions.SetLiquid(0, 0)
            }));
            gen.Generate(origin.X - (gen.width / 2), origin.Y, true, true);

            return true;
        }
    }
}
