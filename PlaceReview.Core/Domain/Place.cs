using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlaceReview.Core.Domain
{
    public class Place
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Descritpion { get; protected set; }
        private ICollection<Review> _reviews = new List<Review>();
        public IEnumerable<Review> Reviews
        {
            get { return _reviews; }
            set { _reviews = new List<Review>(value); }
        }
        private ISet<Category> _categories = new HashSet<Category>();
        public IEnumerable<Category> Categories
        {
            get { return _categories; }
            set { _categories = new HashSet<Category>(value); }
        }
        private ISet<Image> Images = new HashSet<Image>();
        public Address Address { get; protected set; }
        public Coordinate Coordinate { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
        public IEnumerable<Rating> Ratings { get; protected set; }
        public User CreatedBy { get; protected set; }
        public User Owner { get; protected set; }

        public double AvarageRate
        {
            get
            {
                if (Ratings.Any())
                    return Math.Round(Ratings.Average(x => x.Value), 1);
                return 0;
            }
        }

        public double NumberOfReviews
        {
            get
            {
                return Reviews.Count();
            }
        }

        protected Place()
        {
        }

        public void SetName(string name)
        {
        }

        public void SetDescription(string name)
        {
        }

        public void AddCategory(Category category)
        {
            if (_categories.SingleOrDefault(x => x.Name == category.Name) == null)
            {
                _categories.Add(category);
                UpdatedAt = DateTime.UtcNow;
            }
        }

        public void RemoveCategory(string name)
        {
            var placeCategory = _categories.SingleOrDefault(x => x.Name == name);
            if (placeCategory != null)
            {
                _categories.Remove(placeCategory);
                UpdatedAt = DateTime.UtcNow;
            }
        }
    }
}
