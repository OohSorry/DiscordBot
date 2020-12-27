using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Interactivity.Enums;
using DSharpPlus.Interactivity.Extensions;
using DSharpPlus.Interactivity;
using DSharpPlus.Entities;

public class curse : BaseCommandModule
{
    [Command("курсач")]
    public async Task GreetCommand(CommandContext ctx)
    {
        await ctx.RespondAsync("Ебашьте курсачи жаба и сисярп");
        await ctx.RespondAsync(":regional_indicator_f::regional_indicator_u::regional_indicator_c::regional_indicator_k:");
    }

}
