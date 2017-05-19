﻿using DEA.Common;
using DEA.Common.Utilities;
using DEA.Database.Repositories;
using DEA.Services;
using System.Collections.Generic;

namespace DEA.Modules.Crime
{
    public partial class Crime : DEAModule
    {
        private readonly UserRepository _userRepo;
        private readonly GangRepository _gangRepo;
        private readonly ModerationService _moderationService;
        private readonly GameService _gameService;
        private readonly InteractiveService _interactiveService;
        private readonly Item[] _items;
        private readonly List<CommandTimeout> _commandTimeouts;

        public Crime(UserRepository userRepo, GangRepository gangRepo, ModerationService moderationService, GameService gameService, InteractiveService interactiveService, Item[] items, List<CommandTimeout> commandTimeouts)
        {
            _userRepo = userRepo;
            _gangRepo = gangRepo;
            _moderationService = moderationService;
            _gameService = gameService;
            _interactiveService = interactiveService;
            _items = items;
            _commandTimeouts = commandTimeouts;
        }
    }
}