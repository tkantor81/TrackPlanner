using System.Collections.Generic;

namespace TrackPlanner
{
    public abstract class Track
    {
        const int NODES_MAX_COUNT = 4;

        public int Rotation { get; set; }
        public bool Selected { get; set; }
        public List<Node> Nodes { get; } = new List<Node>(NODES_MAX_COUNT);

        public abstract void Draw();
    }
}
