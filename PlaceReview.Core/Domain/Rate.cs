using System;

namespace PlaceReview.Core.Domain
{
    public class Rating
    {
        public Guid UserId { get; protected set; }
        public int Value { get; protected set; }
        public DateTime RatedAt { get; protected set; }

        protected Rating()
        {
        }

        protected Rating(Guid userId, int value)
        {
            UserId = UserId;
            SetValue(value);
            RatedAt = DateTime.UtcNow;
        }

        private void SetValue(int value)
        {
            if (value < 0 || value > 10)
            {
                throw new Exception("Rating value must be greater than or equal to 0 and less than or equal to 10.");
            }
            Value = value;
        }

        public static Rating Create(Guid userId, int value) => new Rating(userId, value);
    }
}