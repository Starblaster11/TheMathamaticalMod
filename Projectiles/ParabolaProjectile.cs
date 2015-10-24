using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMathematicalMod.Projectiles
{
    public class ParabolaProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Parabola Projectile";
        }
    }
}
