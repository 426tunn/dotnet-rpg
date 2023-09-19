using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos.Character
{
    public class UpdateCharacterDto
    {
        public int Id {get; set; }
        public string Name { get; set; } = "Frayo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;

        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpGClass Class { get; set; } = RpGClass.Knight; 
        
    }
}