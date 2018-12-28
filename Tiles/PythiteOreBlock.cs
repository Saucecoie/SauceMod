using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SauceMod.Tiles
{
    class PythiteOreBlock : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            soundType = 21;
            minPick = 65;
            Main.tileSpelunker[Type] = true;

            ModTranslation MapHoverTranslation = CreateMapEntryName();
            MapHoverTranslation.SetDefault("Pythite Ore");
            AddMapEntry(Color.YellowGreen, MapHoverTranslation);

            drop = mod.ItemType("T1PythiteOreItem");
           
        }
    }
}

