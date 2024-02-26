using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Newtonsoft.Json;
using UserFactoryAPI.Data;

namespace UserFactoryAPI.Utils
{
    public class UserFunctions
    {
        public static string GetRandomGender(Random random)
        {
            string[] genders = { "Hombre", "Mujer", "Otro" };
            return genders[random.Next(0, genders.Length)];
        }

        public static string GetRandomNationality(Random random)
        {
            return Nationalities.nationalities[random.Next(0, Nationalities.nationalities.Length)];
        }

        public static string GetRandomFirstName(Random random, String gender)
        {
            if (gender == "Hombre")
            {
                return FirstNames.firstNamesMan[random.Next(0, FirstNames.firstNamesMan.Length)];
            }
            else
            if (gender == "Mujer")
            {
                return FirstNames.firstNamesWoman[random.Next(0, FirstNames.firstNamesWoman.Length)];
            }
            else
            {
                return FirstNames.firstNames[random.Next(0, FirstNames.firstNames.Length)];
            }

        }

        public static string GetRandomLastName(Random random)
        {

            return LastNames.lastNames[random.Next(0, LastNames.lastNames.Length)];
        }

        public static string GetRandomPhoneNumber(Random random)
        {
            return $"+{random.Next(100000000, 999999999)}";
        }

        public static string GetRandomStreetName(Random random)
        {

            return StreetNames.streetNames[random.Next(0, StreetNames.streetNames.Length)];
        }

        public static string GetRandomCity(Random random)
        {

            return Cities.cities[random.Next(0, Cities.cities.Length)];
        }

        public static string GetRandomState(Random random)
        {

            return States.states[random.Next(0, States.states.Length)];
        }

        public static string GetRandomCountry(Random random)
        {
            return Countries.countries[random.Next(0, Countries.countries.Length)];
        }
        public static string GetRandomImages(Random random, string gender)
        {
            var image = "";
            var carpeta = "";
            Console.WriteLine(gender);
            if (gender == "Hombre")
            {
                image = Images.ImagesNameMan[random.Next(0, Images.ImagesNameMan.Length)];
                carpeta = "Hombre";
            }
            else
            if (gender == "Mujer")
            {
                image = Images.ImagesNameWoman[random.Next(0, Images.ImagesNameWoman.Length)];
                carpeta = "Mujer";
            }
            else
            {
                var randomGender = random.Next(0, 2);
                if (randomGender == 0)
                {
                    image = Images.ImagesNameMan[random.Next(0, Images.ImagesNameMan.Length)];
                    carpeta = "Hombre";
                }
                else
                {
                    image = Images.ImagesNameWoman[random.Next(0, Images.ImagesNameWoman.Length)];
                    carpeta = "Mujer";
                }

            }
            return $"https://res.cloudinary.com/dbarwsgb4/image/upload/v1707679246/{carpeta}/{image}.jpg"; ;
        }
    }
}
