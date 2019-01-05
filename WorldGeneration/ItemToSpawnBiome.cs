using BaseMod;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace SauceMod.WorldGeneration
{
    class ItemToSpawnBiome : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Something Strange");
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 56;
            item.maxStack = 1;
            item.rare = 10;
            item.value = BaseMod.BaseUtility.CalcValue(0, 0, 0, 0);
            item.useStyle = 1;
            item.useAnimation = 45;
            item.useTime = 45;

        }

        public override bool UseItem(Player player)
        {
            int x = Main.maxTilesX;
            int y = Main.maxTilesY;
            int tilesX = (int)player.Center.X;
            int tilesY = (int)player.Center.Y;

            Point origin = new Point(tilesX, tilesY);
            origin.Y = BaseWorldGen.GetFirstTileFloor(origin.X, origin.Y, true);
            InfectionClear delete = new InfectionClear();
            InfectionCave biome = new InfectionCave();
            delete.Place(origin, WorldGen.structures);
            biome.Place(origin, WorldGen.structures);
            return true;
        }
    }


}


