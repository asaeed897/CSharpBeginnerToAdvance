using System;

namespace CSharpAdvance
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo phtot)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply Contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }
}