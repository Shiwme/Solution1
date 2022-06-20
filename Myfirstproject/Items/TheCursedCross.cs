using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Myfirstproject.Projectile;

namespace Myfirstproject.Items
{
	public class TheCursedCross : ModItem
	{
		public override void SetStaticDefaults()
		{
			 DisplayName.SetDefault("The Cursed Cross"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("There is a curse on this cross.");
		}

		public override void SetDefaults()
		{
		    Item.DamageType = DamageClass.Magic;
			Item.damage = 37;
			Item.mana = 8;
			Item.width = 60;
			Item.height = 60;
			Item.useTime = 37;
			Item.useAnimation = 37;
			Item.useStyle = 5;
			Item.knockBack = 7;
			Item.value = 6900000;
			Item.rare = 4;
			Item.UseSound = SoundID.Item8;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<CCProjectile>();
			Item.shootSpeed = 7f;
			Item.noMelee = true;
		}
		
		
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Ruby, 2);
			recipe.AddIngredient(ModContent.ItemType<HiltOfTheCursedCross>(), 1);
			recipe.AddIngredient(ItemID.GoldBar, 12);
			recipe.AddTile(TileID.DemonAltar);
			recipe.Register();
		}

	}
}