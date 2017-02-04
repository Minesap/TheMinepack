using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack
{
	class TheMinepack : Mod
	{
		public TheMinepack()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Gold Bar", new int[] // Any Gold Bar
            {
                ItemID.GoldBar,
                ItemID.PlatinumBar,  
            });
            RecipeGroup.RegisterGroup("Gold Bar", group);
        }

    }
}
