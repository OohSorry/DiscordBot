using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
public class salam : BaseCommandModule
{
    [Command("салам")]
    public async Task GreetCommand(CommandContext ctx)
    {
        await ctx.RespondAsync("исламос алейкум");
    }


}

