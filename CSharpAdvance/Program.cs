using System;

namespace CSharpAdvance
{
    // Generic Delegates  Action return void
    //System.Action<>  Func return TReturn
    //System.Func<>
    class Program
    {
        
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();
            // PhotoProcessor.PhotoFilterHandler filterHandler  = filters.ApplyContrast;
            Action<Photo> filterHandler  = filters.ApplyContrast;
            filterHandler += filters.ApplyBrightness;
            filterHandler += RemoveRedEyeFilter;
            photoProcessor.Process("image.jpg", filterHandler);
            // 7. Delegates
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}
