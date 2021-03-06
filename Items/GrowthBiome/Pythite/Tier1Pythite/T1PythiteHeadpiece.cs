﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SauceMod.Items.GrowthBiome.Pythite.Tier1Pythite
{
    [AutoloadEquip(EquipType.Head)]
    class T1PythiteHeadpiece : ModItem
    {
        
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pythite Headpiece");
            Tooltip.SetDefault("Just wearing it makes you feel sick.");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 12;
            item.value = 3500;
            item.rare = 1;
            item.defense = 6;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("T1PythiteBreastplate") && legs.type == mod.ItemType("T1PythiteGreaves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Nani";
            player.minionDamage *= 1.1f;
            player.maxMinions++;
            //your attacks also cause archaic disease
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("T1PythiteBarItem"), 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
//this is for summoner