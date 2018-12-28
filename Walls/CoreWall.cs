using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace SauceMod.Walls
{
    class CoreWall : ModWall 
    {
        public override void SetDefaults()
        {
            AddMapEntry(new Color(13, 78, 35));
        }
    }
}
