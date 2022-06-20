using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Myfirstproject.Items
{
	public class projectileTheForgottenScroll : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			 DisplayName.SetDefault("projectileTheForgottenScroll"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults()
		{

		}

		public override void AI()
		{
		}

	}
}