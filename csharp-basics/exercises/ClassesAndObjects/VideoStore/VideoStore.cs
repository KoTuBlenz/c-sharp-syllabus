using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _videoList=new List<Video>() { };
        public VideoStore() { }

        public void AddVideo(string title)
        {
            _videoList.Add(new Video(title));
        }

        //Returns a Video object from a video list by its title
        private Video VideoByTitle(string title)
        {
            int index = _videoList.FindIndex(video => video.Title == title);
            if (index < 0)
            {
                Console.WriteLine("Video was not found!");
                Console.ReadKey();
                return null;
            }
            else
            {
                return _videoList[index];
            }
        }

        public void Checkout(string title)
        {
            if (VideoByTitle(title).Available())
            {
                VideoByTitle(title)?.BeingCheckedOut();
            }
            else
            {
                Console.WriteLine("Video is no avalible");
                Console.ReadKey();
            }
        }

        public void ReturnVideo(string title)
        {
            VideoByTitle(title)?.BeingReturned();
        }

        public void TakeUsersRating(double rating, string title)
        {
            VideoByTitle(title)?.ReceivingRating(rating);
           
        }

        public void ListInventory()
        {
            foreach(Video video in _videoList)
            {
                Console.WriteLine(video);
            }
        }
    }
}
