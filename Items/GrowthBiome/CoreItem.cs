using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace SauceMod.Items.GrowthBiome
{
    class CoreItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Growth Core");
            Tooltip.SetDefault("It faintly pulses in your hands");
        }
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("CoreTile");

        }
    }
}
