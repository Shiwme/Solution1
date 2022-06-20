using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Myfirstproject.Items
{
	public class SpiderBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			 DisplayName.SetDefault("Spider Bow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Spider nightmare.");
		}

		public override void SetDefaults()
		{
		    Item.DamageType = DamageClass.Ranged;
			Item.damage = 28;
			Item.width = 50;
			Item.height = 50;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = 5;
			Item.knockBack = 3;
			Item.value = 1600000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
			Item.shoot = 1;
			Item.useAmmo = AmmoID.Arrow;
			Item.shootSpeed = 6.25f;
			Item.noMelee = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Bone, 30);
			recipe.AddIngredient(ItemID.Cobweb, 70);
			recipe.AddIngredient(ItemID.WoodenBow);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}