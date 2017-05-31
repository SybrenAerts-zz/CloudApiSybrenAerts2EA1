using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using XamarinAllianceApp.Helpers;
using XamarinAllianceApp.Models;

namespace XamarinAllianceApp.Services
{
    public class CharacterService
    {

        /// <summary>
        /// Get the list of characters
        /// </summary>
        /// <returns>ObservableCollection of Character objects</returns>
        public async Task<ObservableCollection<Character>> GetCharactersAsync()
        {
            IMobileServiceTable<Character> CharacterTable = App.Client.GetTable<Character>();

            var characters = await CharacterTable.ToListAsync();

            return new ObservableCollection<Character>(characters);
        }
    }
}
