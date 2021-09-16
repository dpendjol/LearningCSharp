using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeInheritancePosts
{
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost(string title, bool isPublic, string postMadeBy, string imageURL) : base(title, isPublic, postMadeBy)
        {
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return $"{this.ID} - {this.Title} - {this.PostMadeBy} - { this.ImageURL} - " + (this.IsPublic ? "Public" : "NOT public");
        }
    }
}
