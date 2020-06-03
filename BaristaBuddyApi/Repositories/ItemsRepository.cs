﻿using BaristaBuddyApi.Data;
using BaristaBuddyApi.Models;
using BaristaBuddyApi.Models.DTO;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaristaBuddyApi.Repositories
{
    

    
    public class ItemsRepository : IitemsRepository
    {
        private BaristaBuddyDbContext _context;

        public ItemsRepository(BaristaBuddyDbContext _context)
        {
            this._context = _context;
        }

        public async Task<ItemDTO> DeleteItem(int storeId, int itemId)
        {
            var item = await _context.Item.FindAsync(itemId);
            if (item == null)
            {
                return null;
            }

            var itemToReturn = await GetOneItem(storeId, itemId);

            _context.Remove(item);
            
            await _context.SaveChangesAsync();

            return itemToReturn;

        }

        public async Task<IEnumerable<ItemModifierDTO>> GetAllItemModifiers(int storeId, int itemId)
        {
            var allModifiers = await _context.itemModifier
                .Where(im => im.ItemId == itemId)
                .Select(im => new ItemModifierDTO
                {
                    ModifierName = im.Modifier.Name,
                    AdditionalCost = im.AdditionalCost
                }
                ).ToListAsync();

            return allModifiers;
                
        }

        public async Task<IEnumerable<ItemDTO>> GetAllItems(int storeId)
        {
            var allItems = await _context.Item
                .Where(item => item.StoreId == storeId)
                .Select(item => new ItemDTO
                {
                    ItemId = item.ItemId,
                    StoreId = item.StoreId,
                    Name = item.Name,
                    Ingredients = item.Ingredients,
                    ImageUrl = item.ImageUrl,
                    Price = item.Price
                }
                
                ).ToListAsync();

            return allItems;
        }

        public async Task<ItemDTO> GetOneItem(int storeId, int itemId)
        {
            var oneItem = await _context.Item
                .Where(item => item.StoreId == storeId)
                .Where(item => item.ItemId == itemId)
                .Select(item => new ItemDTO
                  {
                    ItemId = item.ItemId,
                    StoreId = item.StoreId,
                    Name = item.Name,
                    Ingredients = item.Ingredients,
                    ImageUrl = item.ImageUrl,
                    Price = item.Price
                }
                
                ).FirstOrDefaultAsync();

            return oneItem;
        }

        public async Task<ItemDTO> SaveNewItem(CreateItem createItemData, int storeId)
        {
            var newItem = new Item
            {
                StoreId = storeId,
                ItemId = createItemData.ItemId,
                Name = createItemData.Name,
                Ingredients = createItemData.Ingredients,
                ImageUrl = createItemData.ImageUrl,
                Price = createItemData.Price
            };

            _context.Item.Add(newItem);
            await _context.SaveChangesAsync();

            var itemToRetun = await GetOneItem(storeId, createItemData.ItemId);
            return itemToRetun;
        }

        public async Task<bool> UpdateItem(int storeId, int itemId, Item item)
        {
            _context.Entry(item).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(itemId))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        private bool ItemExists(int id)
        {
            return _context.Item.Any(e => e.ItemId == id);
        }
    }
}
