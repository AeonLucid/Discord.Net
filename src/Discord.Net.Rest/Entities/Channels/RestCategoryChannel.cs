using Model = Discord.API.Channel;

namespace Discord.Rest
{
    public class RestCategoryChannel : RestGuildChannel
    {
        internal RestCategoryChannel(BaseDiscordClient discord, IGuild guild, ulong id) : base(discord, guild, id)
        {
        }
        
        internal new static RestCategoryChannel Create(BaseDiscordClient discord, IGuild guild, Model model)
        {
            var entity = new RestCategoryChannel(discord, guild, model.Id);
            entity.Update(model);
            return entity;
        }
    }
}