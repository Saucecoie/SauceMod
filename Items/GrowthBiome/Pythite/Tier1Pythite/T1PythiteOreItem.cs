using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SauceMod.Items.GrowthBiome.Pythite.Tier1Pythite
{
	public class T1PythiteOreItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pythite Ore");
			Tooltip.SetDefault("Don't hold it for too long, it might be contagious!");
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
            item.createTile = mod.TileType("PythiteOreBlock");
            
        }
        public override void ModifyTooltips(List<TooltipLine> list)
        {
            float Depression = Math.Abs(Main.GameUpdateCount) / 5f;
            float Cake = 1f * (float)Math.Sin(Depression);
            Color colorone = Color.Lerp(Color.Yellow, Color.LimeGreen, Cake);
            foreach (TooltipLine line2 in list)
            {
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                {
                    line2.overrideColor = colorone;
                }
            }
        }

        public override void AddRecipes()
        {
         
        }
    }
}
