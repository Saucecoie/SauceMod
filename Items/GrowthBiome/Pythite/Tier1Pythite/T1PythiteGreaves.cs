using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SauceMod.Items.GrowthBiome.Pythite.Tier1Pythite
{
    class T1PythiteGreaves : ModItem 
    {
        [AutoloadEquip(EquipType.Legs)]
        public class ExampleLeggings : ModItem
        {
            public override void SetStaticDefaults()
            {
                DisplayName.SetDefault("Pythite Greaves");
                Tooltip.SetDefault("This is a modded leg armor."
                    + "\n5% increased movement speed");
            }

            public override void SetDefaults()
            {
                item.width = 18;
                item.height = 18;
                item.value = 3000;
                item.rare = 1;
                item.defense = 6;
            }

            public override void UpdateEquip(Player player)
            {
                player.moveSpeed += 0.05f;
            }

            public override void AddRecipes()
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(mod.ItemType("T1PythiteBarItem"), 18);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}

