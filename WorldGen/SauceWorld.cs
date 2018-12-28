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
        public override bool UseItem(Player player)
        {
            Dictionary<Color, int> colorToTile = new Dictionary<Color, int>();
            colorToTile[new Color(0, 0, 255)] = mod.TileType("InfectedGrowthTissueTile");
            colorToTile[Color.Black] = -1; 

            Dictionary<Color, int> colorToWall = new Dictionary<Color, int>();
            colorToWall[new Color(255, 0, 0)] = mod.WallType("CoreWall");
            colorToWall[Color.Black] = -1;

            TexGen gen = BaseWorldGenTex.GetTexGenerator(mod.GetTexture("Worldgeneration/SauceWorldGen_Tiles"), colorToTile, mod.GetTexture("Worldgeneration/SauceWorldGen_Walls)"), colorToWall, mod.GetTexture("Worldgeneration/GrowthWater"));

            Point origin = new Point((int)(player.Center.X / 16f), (int)(player.Center.Y / 16f));
            gen.Generate(origin.X, origin.Y + 2, true, true);
            return true;
        }
    }
}
