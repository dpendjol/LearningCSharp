using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeInheritancePosts
{
    class Post
    {
        private static int currentID;

        // properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected bool IsPublic { get; set; }
        protected string PostMadeBy { get; set; }

        /// <summary>
        /// When no parameters are given, standard post is generated.
        /// </summary>
        public Post()
        {
            this.ID = GetNextId();
            this.Title = "Standard post title " + this.ID;
            this.IsPublic = true;
            this.PostMadeBy = "Auto generated";
        }
        /// <summary>
        /// Post made by user
        /// </summary>
        /// <param name="title">String with the title of the post</param>
        /// <param name="isPublic">Boolean stating whether or not the post is visible to the public</param>
        /// <param name="postMadeBy">String containing username of post maker</param>
        public Post(string title, bool isPublic, string postMadeBy)
        {
            // To generate a unique ID, call a method that increments the ID with every new instance
            this.ID = GetNextId();
            this.Title = title;
            this.IsPublic = isPublic;
            this.PostMadeBy = postMadeBy;
        }

        /// <summary>
        /// Override the ToString method from the Object class.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return $"{ID} - {this.Title} - {this.PostMadeBy} - " + (this.IsPublic ? "This is public" : "This is NOT public");
        }

        /// <summary>
        /// Updates a post
        /// </summary>
        /// <param name="title">String containing new title of the post</param>
        /// <param name="isPublic">Boolean stating if the post is visible to the public</param>
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        private static int GetNextId()
        {
            return ++currentID;

        }
    }
}
