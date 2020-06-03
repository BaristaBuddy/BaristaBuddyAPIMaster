﻿using BaristaBuddyApi.Data;
using BaristaBuddyApi.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaristaBuddyApi.Repositories
{
    public class StoreModifierRepository : IstoreModifierRepository
    {

            private BaristaBuddyDbContext _context;

            public StoreModifierRepository(BaristaBuddyDbContext _context)
            {
                this._context = _context;
            }

            public async Task<StoreModifierDTO> DeleteMofifier(int modifierId , int storeId)
            {
                var modofier = await _context.StoreModifier.FindAsync(modifierId);

                if (modifierId == null)
                {
                    return null;
                }

                var modifierToReturn = await GetOneModifier(modifierId,storeId);

                _context.Remove(modofier);
                await _context.SaveChangesAsync();

                return modifierToReturn;

            }

    
        public async Task<IEnumerable<StoreModifierDTO>> GetAllModifiers(int storeId)
            {
                var allModifier = await _context.StoreModifier
                    .Where(modifier => modifier.StoreId == storeId)
                    .Select(modifer => new StoreModifierDTO
                    {
                        ModifierId= modifer.ModifierId,
                        Name=modifer.Name,
                        Description =modifer.Description,
                        StoreId = modifer.StoreId
                 
                    }).ToListAsync();

                return allModifier;
            }

            public async Task<StoreModifierDTO> GetOneModifier(int storeId, int ModifierId)
           {
            var oneModifier = await _context.StoreModifier
                  .Where(modifier => modifier.StoreId == storeId)
                  .Select(modifer => new StoreModifierDTO
                  {
                      ModifierId = modifer.ModifierId,
                      Name = modifer.Name,
                      Description = modifer.Description,
                      StoreId = modifer.StoreId


            ).FirstOrDefaultAsync();

              return oneModifier;
           }

        //public Task<StoreModifierDTO> GetOneModifier(int modifierId)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<StoreModifierDTO> SaveNewItem(CreateItem createItemData, int storeId)
        //    {
        //        var newItem = new Item
        //        {
        //            StoreId = storeId,
        //            ItemId = createItemData.ItemId,
        //            Name = createItemData.Name,
        //            Ingredients = createItemData.Ingredients,
        //            ImageUrl = createItemData.ImageUrl,
        //            Price = createItemData.Price
        //        };

        //        _context.Item.Add(newItem);
        //        await _context.SaveChangesAsync();

        //        var itemToRetun = await GetOneItem(storeId, createItemData.ItemId);
        //        return itemToRetun;
        //    }

        //public Task<StoreModifierDTO> SaveNewModifier(StoreModifierDTO modifier)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<bool> UpdateItem(int storeId, int itemId, Item item)
        //    {
        //        _context.Entry(item).State = EntityState.Modified;

        //        try
        //        {
        //            await _context.SaveChangesAsync();
        //            return true;
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ItemExists(itemId))
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //    }

        //public Task<bool> UpdateModifier(int modifierId)
        //{
        //    throw new NotImplementedException();
        //}

        //private bool ItemExists(int id)
        //    {
        //        return _context.Item.Any(e => e.ItemId == id);
        //    }
        //}
    
}
