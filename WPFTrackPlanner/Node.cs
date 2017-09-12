namespace TrackPlanner
{
    public class Node
    {
        public Node(int angle)
        {
            Angle = angle;
        }

        public int Angle { get; }
        public bool Connected { get; set; }
    }
}
