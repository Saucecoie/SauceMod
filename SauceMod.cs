using Terraria.ModLoader;

namespace SauceMod
{
	class SauceMod : Mod
	{
        internal static SauceMod instance;

        public SauceMod()
		{
			Properties = new ModProperties()
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
