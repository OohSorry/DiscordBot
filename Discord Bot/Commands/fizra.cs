using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
public class fizra : BaseCommandModule
{
    [Command("физра")]
    public async Task GreetCommand(CommandContext ctx)
    {
        await ctx.RespondAsync("рот ебал теста по физре. Клоунская хуитааа");
    }


}