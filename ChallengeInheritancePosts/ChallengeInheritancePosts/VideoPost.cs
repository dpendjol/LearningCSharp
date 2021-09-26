using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// importing namespace timers
using System.Threading;

namespace ChallengeInheritancePosts
{
    class VideoPost : Post
    {
        private bool IsPlaying = false;
        // Challenge: add a deriving class "VideoPost" with a property VideoURL and Length
        protected string VideoURL { get; set; }
        // length movie in seconds
        protected int Length { get; set; }

        Timer timerEverySecond;
        int second = 0;

        // create the required constructor to create a video post
        public VideoPost(string title, bool isPublic, string postMadeBy, string videoURL, int length) : base(title, isPublic, postMadeBy)
        {
            this.VideoURL = videoURL;
            this.Length = length;
        }

        // override the standard to string method
        public override string ToString()
        {
            return $"{this.ID} - {this.Title} - {this.PostMadeBy} - {this.VideoURL} with length {this.Length} - {(this.IsPublic ? "Public" : "NOT public")}";
        }

        public void Play()
        {
            this.IsPlaying = true;
            // set timer with length of movie (argument timer is in milliseconds, hence the 1000
            //Timer timerLengthMovie = new Timer(this.Length * 1000);
            // set a timer thats goes off every second
            timerEverySecond = new Timer(Playing, null, 0, 1000);
        }

        public void Stop()
        {
            if (IsPlaying)
            {
                this.IsPlaying = false;
                timerEverySecond.Dispose();
                Console.WriteLine("Movie stopt @{0}", second);
                this.second = 0;
            }

        }
    
        private void Playing(Object source)
        {
            if (IsPlaying && (this.Length > this.second))
            {
                second++;
                Console.WriteLine("Playing video {0}", second);
            } else
            {
                Stop();
            }
        }

    }
}
