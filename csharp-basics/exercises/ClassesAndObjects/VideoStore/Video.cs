using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private double _totalRating;
        private int _timesRated;
        private bool _avalible=true;
        public Video(string title)
        {
            _title = title;   
        }

        public void BeingCheckedOut()
        {
            _avalible = false;
        }

        public void BeingReturned()
        {
            _avalible = true;
        }

        public void ReceivingRating(double rating)
        {
            _timesRated++;
            _totalRating += rating;
        }

        public double AverageRating()
        {
            return _totalRating/_timesRated;
        }

        public bool Available()
        {
            return _avalible;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"Title: \"{_title}\", average rating: {AverageRating()}. Avalible: {Available()}";
        }
    }
}
