using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sciencemodkek.Items.Weapons.Conversions.Guns
{
	public class IceGun : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ice Pistol");
			Tooltip.SetDefault("Turns Normal Bullets into 'Ice Bullets' (Crystal Bullets)");
		}

			public override void SetDefaults() {
			item.damage = 17;
			item.ranged = true;
			item.width = 83;
			item.height = 22;
			item.useTime = 28;
			item.useAnimation = 20;
			item.crit = 2;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 20;
			item.rare = 1;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Bullet;
		}

			public override Vector2? HoldoutOffset()
		{
			return new Vector2(-3, 0);
		}

			public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
			{
				type = ProjectileID.CrystalBullet; // or ProjectileID.FireArrow;
			}
			return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
		}

			public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(724, 1);
			recipe.AddIngredient(null, "BowToken", 1);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this);
			recipe.AddIngredient(null, "TomeToken", 1);
			recipe.AddTile(114);
			recipe.SetResult(null, "IceBlast", 1);
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