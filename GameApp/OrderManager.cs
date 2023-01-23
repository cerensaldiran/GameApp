using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public class OrderManager :  IOrderService
    {
        public void Buy(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.Name+" is bought : " + game.GameName +" "+game.GamePrice + " TL");
        }
    }
}
