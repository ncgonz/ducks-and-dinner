﻿using System.Collections.Generic;
using DucksAndDinner.Api.Controllers;
using DucksAndDinner.Api.Models;

namespace DucksAndDinner.Api.DAL
{
    public class DuckRepository : IDuckRepository
    {
        readonly AppContext _context;

        public DuckRepository(AppContext context)
        {
            _context = context;
        }

        public void Save(Duck newDuck)
        {
            _context.Ducks.Add(newDuck);
            _context.SaveChanges();
        }

        public Duck Get(int id)
        {
            return _context.Ducks.Find(id);
        }

        public IEnumerable<Duck> GetAll()
        {
            return _context.Ducks;
        }
    }
}