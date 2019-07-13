using Terraria.ID;
using Terraria.ModLoader;

namespace Sciencemodkek.Items
{
	public class BlankToken : ModItem
	{
		public override void SetStaticDefaults() {
                        DisplayName.SetDefault("Blank Token");
			Tooltip.SetDefault("You could infuse this with some basic weapons");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = 0;
			item.rare = -1;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 3);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
