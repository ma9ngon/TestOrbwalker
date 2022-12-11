using System;
using System.Reflection;
using TestOrbwalker.Properties;
using EnsoulSharp.SDK;
using EnsoulSharp.SDK.Utility;

namespace TestOrbwalker
{
    internal class Init
    {
        private static void Main(string[] args)
        {
            GameEvent.OnGameLoad += OnGameLoad;
        }

        private static void OnGameLoad()
        {
            // Cracked by UltraPanda ~ discord.gg/V4ZdTKtZgN

	    // Loader
            Logging.Write(false, true, "InfoA")(LogLevel.Info, "Cracked by UltraPanda ~ Have Fun!");
            Logging.Write(false, true, "InfoC")(LogLevel.Info, "For future updates join here >> discord.gg/V4ZdTKtZgN");

            try
            {
                Assembly assembly = Assembly.Load(Resources.TestOrbwalker);
                if (assembly != null)
                {
                    if (assembly.EntryPoint != null)
                    {
                        assembly.EntryPoint.Invoke(null, new object[]
                       {
                            new string[1]
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.Write(false, true, "TestOrbwalker")(LogLevel.Error, "Failed to load, try to contact UltraPanda#6211");
            }
        }
    }
}