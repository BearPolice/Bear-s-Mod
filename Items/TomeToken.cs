using Terraria.ID;
using Terraria.ModLoader;

namespace Sciencemodkek.Items
{
	public class TomeToken : ModItem
	{
		public override void SetStaticDefaults() {
                        DisplayName.SetDefault("Magic Token");
			Tooltip.SetDefault("Used to convert weapons into Magic Weapons");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = 0;
			item.rare = -11;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(149, 1);
			recipe.AddIngredient(null, "BlankToken", 1);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
