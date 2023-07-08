using System.Numerics;

namespace CTW_FIA.Models.LocalModels
{
    public class GraphCount
    {
        public int Incidentcount { get; set; }
        public int Groupcount { get; set; }
        public int Personcount { get; set; }
        public int Explosivecount { get; set; }
       public   List<GraphDto> graphDtos { get; set; }
    }
}
