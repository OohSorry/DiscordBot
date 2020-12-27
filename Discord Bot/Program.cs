using System;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Net;
using DSharpPlus.Lavalink;
using DSharpPlus.Interactivity;
using DSharpPlus.Interactivity.Enums;
using DSharpPlus.Interactivity.Extensions;
using Microsoft.Extensions.Logging;


namespace MyFirstBot
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        internal static async Task MainAsync()
        {

            var discord = new DiscordClient(new DiscordConfiguration()
            {
                Token = "",
                TokenType = TokenType.Bot
            });

            var commands = discord.UseCommandsNext(new CommandsNextConfiguration()
            {
                StringPrefixes = new[] { "!" , ".", "ислам/" }
            });

            discord.UseInteractivity(new InteractivityConfiguration()
            {
                PollBehaviour = PollBehaviour.KeepEmojis,
                Timeout = TimeSpan.FromSeconds(30)
            });


            commands.RegisterCommands<salam>();
            commands.RegisterCommands<curse>();
            commands.RegisterCommands<fizra>();
            commands.RegisterCommands<help>();

            new DiscordConfiguration()
            {
                MinimumLogLevel = LogLevel.Debug
            };


            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}