using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sciencemodkek.Items.Weapons
{
	public class Blunderbuss : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("A timeless classic");
		}

		public override void SetDefaults() {
			item.damage = 24;
			item.ranged = true;
			item.width = 83;
			item.height = 22;
			item.useTime = 40;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 20;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = false;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 6);
			recipe.AddRecipeGroup("Wood", 10);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
			public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 2 + Main.rand.Next(2); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(5));
				
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
		
					public override Vector2? HoldoutOffset()
		{
			return new Vector2(-12, 0);
		}
		
		}
	}