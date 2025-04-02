using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession() 
        {
            CurrentPlayer = new Player
            {
                Name = "Eli",
                CharacterClass = "Mage",
                HitPoints = 10,
                Gold = 10000,
                ExperiencePoints = 0,
                Level = 1
            };

            CurrentLocation = new Location
            {
                Name = "Home",
                XCoordinate = 0,
                YCoordinate = -1,
                Description = "This is your house",
                ImageName = "/Engine;component/Images/Locations/Home.png" //Image is currently not displaying
            };
        }
    }
}
