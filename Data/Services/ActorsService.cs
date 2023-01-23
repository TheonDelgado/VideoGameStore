using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VideoGameStore.Models;

namespace VideoGameStore.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext context;

        public ActorsService(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(Actor actor)
        {
            
        }

        public void Delete(int id)
        {
            
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await context.Actors.ToListAsync();

            return result;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}