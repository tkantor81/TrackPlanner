namespace TrackPlanner
{
    public class Cross : Track
    {
        public Cross()
        {
            Nodes.Add(new Node(30));
            Nodes.Add(new Node(150));
            Nodes.Add(new Node(210));
            Nodes.Add(new Node(330));
        }

        public override void Draw()
        {
            // TODO
        }
    }
}
