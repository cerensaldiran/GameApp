using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public  class GamerManager : IGamerService
    {
        private GamerCheckManager gamerCheckManager;

        public GamerManager(GamerCheckManager gamerCheckManager)
        {
            this.gamerCheckManager = gamerCheckManager;
        }

        public void Add(Gamer gamer)
        {
            if (gamerCheckManager.CheckIfRealPerson(gamer)==true)
            {
                Console.WriteLine("Gamer is added the system : " + gamer.Name);
            }
            else
            {
                Console.WriteLine("Validation is wrong!");
            }
           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer is deleted the system : " + gamer.Name);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer is updated the system : " + gamer.Name);
        }
    }
}
