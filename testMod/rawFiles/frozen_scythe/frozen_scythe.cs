using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace skyblock
{
    public class frozen_scythe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frozen Scythe");
            Tooltip.SetDefault("Shoots 1 Ice Bolt. \nAnd slows enemies hit for 5 seconds!");
        }

        public override void SetDefaults()
        {
            Item.damage = 80;
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.value = 100;
            Item.autoReuse = true;
            Item.useStyle = 1;
            Item.magic = true;
            Item.shootSpeed = 30f;
            // Item.shoot = ;
            Item.mana = 20;
            Item.rare = ItemRarityID.Blue;
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
        }
    }
}
