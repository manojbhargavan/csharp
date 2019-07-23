using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleNullables
{
    public class PlayerCharacter
    {


        public string Name { get; set; }
        public int? DaySinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        //Nullable<T> == T?
        public Nullable<bool> IsNoob { get; set; }

    }
}
