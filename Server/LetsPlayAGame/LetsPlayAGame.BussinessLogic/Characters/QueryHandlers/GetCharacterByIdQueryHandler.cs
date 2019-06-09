using LetsPlayAGame.BussinessLogic.CQRS;
using LetsPlayAGame.Data;
using LetsPlayAGame.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace LetsPlayAGame.BussinessLogic.Characters.QueryHandlers
{
    public class GetCharacterByIdQueryHandler
    {
        private readonly LetsPlayGameDbContext dbContext;
        public const string CharacterNotFoundErrorMessage = "character-not-found";

        public GetCharacterByIdQueryHandler(LetsPlayGameDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Result Handle(Guid id)
        {
            var result = dbContext.Characters
                .Include(c => c.Skills)
                .Include(c => c.Stats)
                .SingleOrDefault(c => c.Id == id);

            if (result == null)
            {
                return Result.Failed(CharacterNotFoundErrorMessage);
            }

            return Result.Success(result);
        }
    }
}
