using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sciencemodkek.Items.Weapons.Conversions.Magic
{
	public class IceBlast : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Ice Bolt");
			Tooltip.SetDefault("Shoots an ice bolt");
		}

		public override void SetDefaults() {
			item.damage = 17;
			item.magic = true;
			item.mana = 5;
			item.width = 40;
			item.height = 40;
			item.crit = 2;
			item.useTime = 23;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4.75f;
			item.value = 4000;
			item.rare = 1;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = 118;
			item.shootSpeed = 19f;
		}

			public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(724, 1);
			recipe.AddIngredient(null, "TomeToken", 1);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this);
			recipe.AddIngredient(null, "BowToken", 1);
			recipe.AddTile(114);
			recipe.SetResult(null, "IceGun", 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this);
			recipe.AddIngredient(null, "SwordToken", 1);
			recipe.AddTile(114);
			recipe.SetResult(724);
			recipe.AddRecipe();
		}
	}
}