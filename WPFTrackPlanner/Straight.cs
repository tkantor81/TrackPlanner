namespace TrackPlanner
{
    public class Straight : Track
    {
        public Straight()
        {
            Nodes.Add(new Node(0));
            Nodes.Add(new Node(180));
        }

        public override void Draw()
        {
            // TODO
        }
    }
}
