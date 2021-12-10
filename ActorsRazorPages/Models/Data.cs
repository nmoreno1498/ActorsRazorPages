using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActorsRazorPages.Models
{
    public class Data : IData
    {
        public List<Actor> ActorsList { get; set; }

        public List<Actor> ActorsInitializeData()
        {
            ActorsList = new List<Actor>()
            {
                new Actor(){Id = 1,FirstName="Kelly",LastName="Bailey" ,KnownFor="Kelly the great",OscarWinner=true,ImageName="/elrenacido.jpg"},
            };

            return ActorsList;
        }

       
    }
}
