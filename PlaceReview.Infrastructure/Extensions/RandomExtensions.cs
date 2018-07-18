using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceReview.Infrastructure.Extensions
{
    public static class RandomExtensions
    {
        public static double NextDouble(this Random random, double minValue, double maxvalue)
            => random.NextDouble() * (maxvalue - minValue) + minValue;
    }
}
