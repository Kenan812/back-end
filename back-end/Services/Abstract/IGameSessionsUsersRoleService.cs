﻿using back_end.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace back_end.Services.Abstract
{
    public interface IGameSessionsUsersRoleService
    {
        Task<GameSessionsUsersRole> Get(int id);
        Task<List<string>> GetUsernamesBySessionId(int id);
        Task<IEnumerable<GameSessionsUsersRole>> GetAll();
        Task Add(GameSessionsUsersRole role);
        Task<string> DistributeRoles(int sessionId);
        Task<IEnumerable<GameSessionsUsersRole>> GetBySessionId(int id);
    }
}
