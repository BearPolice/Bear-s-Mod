using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sciencemodkek.Items.Weapons.Conversions.Magic
{
	public class StarFlux : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Starflux");
			Tooltip.SetDefault("Shoots stars from the sky at the cost of mana");
		}

		public override void SetDefaults() {
			item.damage = 22;
			item.magic = true;
			item.mana = 8;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 24;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = false;
			item.shoot = 9;
			item.shootSpeed = 16f;
		}

			public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(65, 1);
			recipe.AddIngredient(null, "TomeToken", 1);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this);
			recipe.AddIngredient(null, "BowToken", 1);
			recipe.AddTile(114);
			recipe.SetResult(null, "StarFire", 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this);
			recipe.AddIngredient(null, "SwordToken", 1);
			recipe.AddTile(114);
			recipe.SetResult(65);
			recipe.AddRecipe();
		}
	}
}