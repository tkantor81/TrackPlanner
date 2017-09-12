namespace TrackPlanner
{
    public class Curve : Track
    {
        public Curve()
        {
            Nodes.Add(new Node(0));
            Nodes.Add(new Node(135));
        }

        public override void Draw()
        {
            // TODO
        }
    }
}
