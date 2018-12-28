using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace SauceMod.Items.GrowthBiome
{
    class InfectedGrowthTissueItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Infected Growth Tissue");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("InfectedGrowthTissueTile");

        }
    }
}
