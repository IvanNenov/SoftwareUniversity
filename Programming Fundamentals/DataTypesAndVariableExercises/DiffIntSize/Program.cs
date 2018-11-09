using System;

namespace DiffIntSize
{
    class Program
    {
        static void Main(string[] args)
        {
            double takenPictures = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine());
            double uploadTime = double.Parse(Console.ReadLine());

            double usefulFiltredPictures = (takenPictures * (filterFactor / 100));
            double usefulFiltredPicturesRounded = Math.Ceiling(usefulFiltredPictures);
            double allFiltredPicturesTime = takenPictures * filterTime;
            double uploadFiltredPicturesTime = usefulFiltredPicturesRounded * uploadTime;
            double totalTime = allFiltredPicturesTime + uploadFiltredPicturesTime;

            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            string timeResult = string.Format("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                time.Days,
                time.Hours,
                time.Minutes,
                time.Seconds);
            Console.WriteLine(timeResult);
        }
    }
}
