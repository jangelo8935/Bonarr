using NzbDrone.Common.Messaging;
using NzbDrone.Core.Tv;

namespace NzbDrone.Core.MediaFiles.Events
{
    public class MovieFolderCreatedEvent : IEvent
    {
        public Movie Movie { get; private set; }
        public MovieFile MovieFile { get; private set; }
        public string SeriesFolder { get; set; }
        public string SeasonFolder { get; set; }
        public string MovieFolder { get; set; }

        public MovieFolderCreatedEvent(Movie movie, MovieFile episodeFile)
        {
            Movie = movie;
            MovieFile = episodeFile;
        }
    }
}
