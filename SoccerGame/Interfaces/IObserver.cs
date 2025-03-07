using SoccerGame.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Interfaces
{
    public interface IObserver
    {
        void Update(GameContext context);
    }
}
