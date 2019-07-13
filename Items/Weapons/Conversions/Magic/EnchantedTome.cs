using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sciencemodkek.Items.Weapons.Conversions.Magic
{
	public class EnchantedTome : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Enchanted Tome");
			Tooltip.SetDefault("Shoots an Enchanted Blade");
		}

		public override void SetDefaults() {
			item.damage = 24;
			item.magic = true;
			item.mana = 9;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5.25f;
			item.value = 4000;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = 173;
			item.shootSpeed = 15f;
		}

			public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(989, 1);
			recipe.AddIngredient(null, "TomeToken", 1);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this);
			recipe.AddIngredient(null, "BowToken", 1);
			recipe.AddTile(114);
			recipe.SetResult(null, "EnchantedBow", 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this);
			recipe.AddIngredient(null, "SwordToken", 1);
			recipe.AddTile(114);
			recipe.SetResult(989);
			recipe.AddRecipe();
		}
	}
}