using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
public class help : BaseCommandModule
{
    [Command("хелп")]
    public async Task GreetCommand(CommandContext ctx)
    {
        await ctx.RespondAsync("Для использования команд есть три префикса: \n ! \t . \t ислам/ \n Доступные команды: \n хелп \n физра \n курсач \n салам ");
    }


}