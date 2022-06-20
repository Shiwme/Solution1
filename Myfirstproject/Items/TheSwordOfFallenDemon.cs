using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Myfirstproject.Items
{
	public class TheSwordOfFallenDemon : ModItem
	{
		public override void SetStaticDefaults()
		{
			 DisplayName.SetDefault("The Sword Of Fallen Demon"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Very hot to the touch, it burns.");
		}

		public override void SetDefaults()
		{
			Item.damage = 34;
			Item.DamageType = DamageClass.Melee;
			Item.width = 60;
			Item.height = 60;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = 1;
			Item.knockBack = 7;
			Item.value = 2700000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = 34;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Fireblossom, 3);
			recipe.AddIngredient(ItemID.Flamelash, 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddTile(TileID.Hellforge);
			recipe.Register();
		}
	}
}