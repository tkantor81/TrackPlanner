namespace TrackPlanner
{
    public class Switch : Track
    {
        public Switch()
        {
            Nodes.Add(new Node(0));
            Nodes.Add(new Node(135));
            Nodes.Add(new Node(180));
        }

        public override void Draw()
        {
            // TODO
        }
    }
}
