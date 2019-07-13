using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sciencemodkek.Items.Weapons.Conversions.Bows
{
	public class EnchantedBow : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 24;
			item.width = 18;
			item.height = 56;
			item.ranged = true;
			item.useTime = 20;
			item.shoot = 1;
			item.shootSpeed = 9.5f;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 5;
                        item.value = Item.sellPrice(0, 1, 0, 0);
                        item.useAmmo = AmmoID.Arrow;
                        item.rare = 2;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Enchanted Bow");
			Tooltip.SetDefault("Transforms Wooden Arrows into Jester's Arrows");
		}
                public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.WoodenArrowFriendly) // or ProjectileID.WoodenArrowFriendly
			{
				type = ProjectileID.JestersArrow; // or ProjectileID.FireArrow;
			}
			return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
		}

					public override Vector2? HoldoutOffset()
		{
			return new Vector2(-4, 0);
		}

             		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(989, 1);
                        recipe.AddIngredient(null, "BowToken", 1);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe(); 

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this);
                        recipe.AddIngredient(null, "SwordToken", 1);
			recipe.AddTile(114);
			recipe.SetResult(989);
			recipe.AddRecipe(); 

			recipe = new ModRecipe(mod);        
			recipe.AddIngredient(this);
                        recipe.AddIngredient(null, "TomeToken", 1);
			recipe.AddTile(114);
			recipe.SetResult(null, "EnchantedTome");
			recipe.AddRecipe(); 
                 }
	}
}
