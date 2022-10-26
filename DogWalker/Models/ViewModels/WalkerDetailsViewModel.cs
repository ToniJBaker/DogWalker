using System.Collections.Generic;

namespace DogWalker.Models.ViewModels
{
    public class WalkerDetailsViewModel
    {
        public Walker Walker { get; set; }
        public List<Walk> Walks { get; set; }
    }
}
