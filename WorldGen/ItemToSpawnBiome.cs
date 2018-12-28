using BaseMod;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace SauceMod.Items
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
            GrowthBiome biome = new GrowthBiome();
            Point origin = new Point((int)(player.Center.X / 16f), (int)(player.Center.Y / 16f));
            origin.Y = BaseWorldGen.GetFirstTileFloor(origin.X, origin.Y) - 10;
            bool desobj = WorldGen.destroyObject;
            WorldGen.destroyObject = true;
            biome.Place(origin, WorldGen.structures);
            WorldGen.destroyObject = desobj;
            return true;
        }
    }


}


