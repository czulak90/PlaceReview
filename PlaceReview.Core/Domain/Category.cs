using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceReview.Core.Domain
{
    public class Category
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }

        protected Category()
        {
        }

        protected Category(string name, string description)
        {
            SetName(name);
            SetDescription(description);
        }

        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Category name can not be empty.");
            }
            if (name.Length < 3)
            {
                throw new Exception("Category name must contains at last 3 characters.");
            }
            if (name.Length > 50)
            {
                throw new Exception("Category name can not contains more thanat 50 characters.");
            }
            Name = name;
        }

        private void SetDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new Exception("Description can not be empty.");
            }
            if (description.Length < 10)
            {
                throw new Exception("Description must contains at last 10 characters.");
            }
            if (description.Length > 100)
            {
                throw new Exception("Description  can not contains more thanat 100 characters.");
            }
            Description = description;
        }

        public static Category Create(string name, string description) => new Category(name, description);
    }
}
