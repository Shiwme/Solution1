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
			Projectile.penetrate = 1;
			Projectile.hostile = false;
			Projectile.DamageType = DamageClass.Magic;
			Projectile.tileCollide = true;
			Projectile.ignoreWater = true;
			Projectile.friendly = true;
			Projectile.extraUpdates = 1;

			AIType = ProjectileID.Bullet;

		}


		public override bool OnTileCollide(Vector2 oldVelocity)
		{
		    NewProjectile(ModProjectile.ProjectileType<CCProjectile>(),
			base.Center.X, base.Center.Y, 6f, 6f, 480,
			(int)((double)damage * 0.8), knockBack * 0.5f,
			owner);
			return base.OnTileCollide(oldVelocity);
		}
	}
}