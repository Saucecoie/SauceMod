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
    class CoreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            soundType = SoundID.NPCHit20.SoundId;
            minPick = 9999;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            ModTranslation MapHoverTranslation = CreateMapEntryName();
            MapHoverTranslation.SetDefault("Growth Core");
            AddMapEntry(Color.YellowGreen, MapHoverTranslation);


        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("CoreItem"));
        }
    }
}
