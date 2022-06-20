using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Myfirstproject.Items
{
	public class HiltOfTheCursedCross : ModItem
	{
		public override void SetStaticDefaults()
		{
			 DisplayName.SetDefault("Hilt Of The Cursed Cross"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This handle smells of rot and evil.");
		}

		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;
			Item.maxStack = 1;
			Item.rare = 0;
			Item.value = 10000;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Emerald, 1);
			recipe.AddIngredient(ItemID.GoldBar, 3);
			recipe.AddIngredient(ItemID.CorruptSeeds, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.Register();
		}
	}
}