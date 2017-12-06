using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMathematicalMod.Projectiles
{
    public class ParabolaProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            projectile.name = "Parabola Projectile";
        }
        
        public override void SetDefaults()
        {
            projectile.width = 10;
            projectile.height = 10;
            projectile.alpha = 255;
            projectile.timeLeft = 600;
            projectile.penetrate = true;
            projectile.friendly = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
        }
        
        public override void AI()
        {
        
        }
    }
}
