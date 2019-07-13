using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sciencemodkek.Items.Weapons
{
	public class CrescentMoon : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("The Crescent Moon");
			Tooltip.SetDefault("The darkness of night in your hand");  //The (English) text shown below your weapon's name
		}

		public override void SetDefaults() {
			item.damage = 70;           //The damage of your weapon
			item.melee = true;          //Is your weapon a melee weapon?
			item.width = 40;            //Weapon's texture's width
			item.height = 40;           //Weapon's texture's height
			item.useTime = 32;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
			item.useAnimation = 20;         
			item.useStyle = 1;          
			item.knockBack = 6;
			item.shoot = 274;       
			item.value = Item.buyPrice(gold: 30);           
			item.rare = 2;              
			item.UseSound = SoundID.Item1;      
			item.autoReuse = true;          
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1327, 1);
			recipe.AddIngredient(485, 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
