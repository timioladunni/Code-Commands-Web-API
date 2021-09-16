using Commander.Models;
using Microsoft.Extensions.Hosting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommaderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id = 0, HowTo="Boil an egg", Line="Boil water", Platform= "Kettle and Pan" },
                new Command {Id = 1, HowTo="Cut Bread", Line="Get a Knife", Platform= "knife and chopping board" },
                new Command {Id = 2, HowTo="Make a cup of tea", Line="Place teabag in cup", Platform= "Kettle and Cup" },
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id = 0, HowTo="Boil an egg", Line="Boil water", Platform= "Kettle and Pan" }; 
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
