using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " deleted from database");
        }

        public void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " saved to database.");
            }
            Console.WriteLine("Could not add to database");
           // throw new Exception("Not a valid gamer");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Database updated");
        }
    }
}
