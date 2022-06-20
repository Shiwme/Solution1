using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Myfirstproject.Projectile
{
	public class CCProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			 DisplayName.SetDefault("CCProjectile"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults()
		{  
			Projectile.width = 10;
			Projectile.height = 10;
            Projectile.aiStyle = 1;
			Projectile.timeLeft = 600;
			Projectile.penetrate = 5;
			Projectile.hostile = false;
			Projectile.DamageType = DamageClass.Magic;
			Projectile.tileCollide = false;
			Projectile.ignoreWater = true;
			Projectile.friendly = true;
			Projectile.extraUpdates = 1;

			AIType = ProjectileID.Bullet;
		}
	}
}