﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagrid_QuikTrip.Stores
{
    class StoreRepository
    {
        // we're using a static list here instead of a proper database
        // but the general idea still holds up once we cover databases
        // it's just another piece of code to replace and refactor nbd
        static List<Store> _store = new List<Store>();

        public List<Store> GetStores()
        {
            return _store;
        }

        public void SaveNewStore(Store store)
        {
            _store.Add(store);
        }
    }
}
