using System.Collections.Generic;

namespace TrackPlanner
{
    public class Circuit
    {
        public string Name { get; set; }
        public List<Track> Route { get; } = new List<Track>();

        public void AddTrack(Track track)
        {
            Route.Add(track);
        }
    }
}
