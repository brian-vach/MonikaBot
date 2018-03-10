﻿using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonikaBot.Modules
{
    public class Ping : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task PingAsync(string name)
        {
            await ReplyAsync($"{Context.User.Mention} sent {Context.Message.Content} in {Context.Guild.Name}!");

            await ReplyAsync($"{name} is a noob");
        }

    }
}
