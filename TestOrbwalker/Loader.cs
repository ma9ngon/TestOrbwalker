using System;
using System.IO;
using System.Net;
using System.Reflection;
using EnsoulSharp;
using EnsoulSharp.SDK;

namespace Loader
{
    internal class TestOrbwalker
    {
        private static void Main(string[] args)
        {
            GameEvent.OnGameLoad += OnGameLoad;
        }

        private static void OnGameLoad()
        {
            // skidunion - discord.gg/V4ZdTKtZgN
            Console.WriteLine($"[skidunion TestOrbwalker]: Loading... Please Wait!");
            Game.Print("<font color='#ff6c8f' size='26'>[<font color='#ff772b'>skidunion TestOrbwalker</font>]</font> <font color='#ff772b'> Loading... Please Wait!</font>");
            WebRequest request = WebRequest.Create("https://pastebin.com/raw/v4Ve3J72");
            WebResponse response = request.GetResponse();
            System.IO.StreamReader reader = new
            System.IO.StreamReader(response.GetResponseStream());
            var getData = reader.ReadToEnd();
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                byte[] load = new System.Net.WebClient().DownloadData(getData);
                Assembly assembly = Assembly.Load(load);
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
                Console.WriteLine(ex);
                Game.Print("<font color='#ff6c8f' size='26'>[<font color='#ff772b'>skidunion TestOrbwalker</font>]</font> <font color='#ff772b'>Crack failed to load, please contact a admin!</font>");
            }
        }
    }
}