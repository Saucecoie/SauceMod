using Terraria.ModLoader;

namespace SauceMod
{
	class SauceMod : Mod
	{
		public SauceMod()
		{
			properties = new ModProperties()
            		{
                		Autoload = true,
                		AutoloadGores = true,
                		AutoloadSounds = true,
                		AutoloadBackgrounds = true
            		};
            		instance = this;
		}
	}
}
