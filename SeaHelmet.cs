using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Myfirstproject.Items.Bars;
using Myfirstproject.Items.Armor;

namespace Myfirstproject.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SeaHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			 DisplayName.SetDefault("Sea Helmet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Made from the energy of the sea."
				+ "\nIncreases Melee damage by 7%"
				+ "\nIncreases movement speed by 3%");
		}

		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;
			Item.value = 120000;
			Item.rare = 2;
			Item.defense = 5;
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.07f;
			player.moveSpeed += 0.03f;
			player.setBonus = "Add buff `Iron Skin`";
			player.AddBuff = BuffID.Ironskin;
		}

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
			return body.type == ModContent.ItemType<SeaChestplate>() && legs.type == ModContent.ItemType<SeaLeggings>();
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<SeaBar>(), 7);
			recipe.AddTile(TileID.Hellforge);
			recipe.Register();
		}
	}
}