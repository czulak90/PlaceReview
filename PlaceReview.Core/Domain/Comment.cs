using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceReview.Core.Domain
{
    public class Comment
    {
        public Guid UserId { get; protected set; }
        public string Name { get; protected set; }
        public Guid PlaceId { get; protected set; }
        public string Text { get; protected set; }
       
        public DateTime CreatedAt { get; protected set; }

        protected Comment()
        {
        }

        public Comment(User user, Place place)
        {
          //  UserId = 
        }
    }
}

