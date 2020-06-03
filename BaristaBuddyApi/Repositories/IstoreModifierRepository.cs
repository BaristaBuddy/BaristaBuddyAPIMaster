﻿using BaristaBuddyApi.Models;
using BaristaBuddyApi.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaristaBuddyApi.Repositories
{
    public interface IstoreModifierRepository
    {
        Task<IEnumerable<StoreModifierDTO>> GetAllModifier(int storeId);
        Task<StoreModifierDTO> GetOneModifier(int modifierId , int storeId);
        Task<bool> UpdateModifier( int modifierId, int storeId);
        Task<StoreModifierDTO> SaveNewModifier(StoreModifierDTO modifier, int storeId);
        Task<StoreModifierDTO> DeleteModifier(int modifierId , int storeId); 
    }
}
