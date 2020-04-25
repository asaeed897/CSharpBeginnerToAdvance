using System;

namespace CSharpAdvance
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo); // our define delegate

        // Without delegate
        public void Process(string path)
        {

            var photo = Photo.Load(path);
            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }
        // With our delegate
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);

            photo.Save();
        }
        // with predefined Generic delegate
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);

            photo.Save();
        }
    }
}