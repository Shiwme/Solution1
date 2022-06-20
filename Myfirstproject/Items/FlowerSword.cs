using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Myfirstproject.Items
{
	public class FlowerSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			 DisplayName.SetDefault("Flower Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Im f*ck this code.");
		}

		public override void SetDefaults()
		{
			Item.damage = 32;
			Item.DamageType = DamageClass.Melee;
			Item.width = 60;
			Item.height = 60;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 7;
			Item.value = 1600000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Fireblossom, 2);
			recipe.AddIngredient(ItemID.Daybloom, 2);
			recipe.AddIngredient(ItemID.Wood, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}