using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace SauceMod.Items.GrowthBiome.Pythite.Tier2Pythite
{
    class T2PythiteBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Prime Pythite Bow");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("T2PythiteBarItem"), 8);
            recipe.AddIngredient(ItemID.Cobweb, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}

