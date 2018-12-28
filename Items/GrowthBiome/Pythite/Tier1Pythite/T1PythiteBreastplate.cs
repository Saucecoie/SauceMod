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
    [AutoloadEquip(EquipType.Body)]
    class T1PythiteBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Pythite Breastplate");
            Tooltip.SetDefault("This is a modded body armor."
                + "\nImmunity to 'Archaic Toxin'");
               
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 4000;
            item.rare = 1;
            item.defense = 7;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Venom] = true;
            
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("T1PythiteBarItem"), 24);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
