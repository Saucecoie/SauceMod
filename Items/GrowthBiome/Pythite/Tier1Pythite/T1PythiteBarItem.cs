using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace SauceMod.Items.GrowthBiome.Pythite.Tier1Pythite
{
    class T1PythiteBarItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pythite Bar");
            Tooltip.SetDefault("Now in a more stable, less infectious and deadly form!");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("T1PythiteOreItem"), 4);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}


