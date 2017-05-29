using DEA.Common;
using DEA.Common.Items;
using DEA.Common.Preconditions;
using DEA.Database.Repositories;
using DEA.Services;
using DEA.Services.Handlers;
using Discord.Commands;

namespace DEA.Modules.Owners
{
    [Global]
    [Require(Attributes.ServerOwner)]
    [Summary("These commands may only be used by a user with the set mod role with a permission level of 3, or the ownership of the server.")]
    public partial class Owners : DEAModule
    {
        private readonly GuildRepository _guildRepo;
        private readonly GangRepository _gangRepo;
        private readonly UserRepository _userRepo;
        private readonly RankHandler _RankHandler;
        private readonly GameService _gameService;
        private readonly Item[] _items;

        public Owners(GuildRepository guildRepo, UserRepository userRepo, GangRepository gangRepo, RankHandler rankHandler, GameService gameService, Item[] items)
        {
            _guildRepo = guildRepo;
            _gangRepo = gangRepo;
            _userRepo = userRepo;
            _RankHandler = rankHandler;
            _gameService = gameService;
            _items = items;
        }
    }
}