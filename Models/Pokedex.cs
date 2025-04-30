using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonDraft.Models
{
    
    public class Pokedex
    {
        public Pokedex(){ }
        internal Pokedex(string[] linePieces)
        {
            DexNum = int.Parse(linePieces[0]);
            Name = linePieces[1];
            Hp = int.Parse(linePieces[2]);
            Atk = int.Parse(linePieces[3]);
            Def = int.Parse(linePieces[4]);
            Spa = int.Parse(linePieces[5]);
            Spd = int.Parse(linePieces[6]);
            Spe = int.Parse(linePieces[7]);
            Bst = int.Parse(linePieces[8]);
            TypeA = linePieces[9];
            TypeB = linePieces[10];
            AbilityA = linePieces[11];
            AbilityB = linePieces[12];
            AbilityC = linePieces[13];
            Tier = linePieces[14];
            Trainer = linePieces[15];       
        }

        public int Id { get; set; }
        public int DexNum { get; set; }
        public string? Name { get; set; }
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Spa { get; set; }
        public int Spd { get; set; }
        public int Spe { get; set; }
        public int Bst { get; set; }
        public string? TypeA { get; set; }
        public string? TypeB { get; set; }
        public string? AbilityA { get; set; }
        public string? AbilityB { get; set; }
        public string? AbilityC { get; set; }
        public string? Tier { get; set; }
        public string? Trainer { get; set; }    
    }
}
