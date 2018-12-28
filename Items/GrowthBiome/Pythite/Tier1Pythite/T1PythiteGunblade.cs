using Microsoft.Xna.Framework;
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
    class T1PythiteGunblade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pythite Gunblade");
            Tooltip.SetDefault("It's both a gun and a blade.");
        }

        public override void SetDefaults()
        {
            item.damage = 21;          
            item.melee = true;          
            item.width = 72;            
            item.height = 54;           
            item.useTime = 16;         
            item.useAnimation = 16;       
            item.useStyle = 1;         
            item.knockBack = 4;        
            item.value = Item.buyPrice(gold: 1);         
            item.rare = 3;           
            item.UseSound = SoundID.Item1;     
            item.autoReuse = true;          
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("T1PythiteBarItem"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.damage = 26;
                item.ranged = true;
                item.width = 72;
                item.height = 54;
                item.useTime = 30;
                item.useAnimation = 30;
                item.useStyle = 5;
                item.noMelee = true; 
                item.knockBack = 6;
                item.value = 1500;
                item.rare = 2;
                item.UseSound = SoundID.Item11;
                item.autoReuse = true;
                item.shoot = 10; 
                item.shootSpeed = 13f;
                item.useAmmo = AmmoID.Bullet;


            }
            return base.CanUseItem(player);
        }


            public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (player.altFunctionUse == 2)
            {
                target.AddBuff(BuffID.Poisoned, 60);
            }
        }

        
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            speedX = new Vector2(speedX, speedY).Length() * (speedX > 0 ? 1 : -1);
            speedY = 0;
            Vector2 speed = new Vector2(speedX, speedY);
            speed = speed.RotatedByRandom(MathHelper.ToRadians(30));
            damage = (int)(damage * .5f);
            speedX = speed.X;
            speedY = speed.Y;
            return true;
        }
    }
}
