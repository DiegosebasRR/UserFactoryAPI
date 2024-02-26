using UserFactoryAPI.Models;
using UserFactoryAPI.Utils;

namespace UserFactoryAPI.Services
{
    public class UsersServices
    {
        public static List<User> GenerateRandomUsers(int count, Random random)
        {
            var users = new List<User>();

            for (int i = 0; i < count; i++)
            {
                var gender = UserFunctions.GetRandomGender(random);
                var first = UserFunctions.GetRandomFirstName(random, gender);
                var last = UserFunctions.GetRandomLastName(random);

                var user = new User
                {
                    UserId = i + 1,
                    Gender = gender,
                    Nationality = UserFunctions.GetRandomNationality(random),
                    Email = $"{first + last}@example.com",
                    Password = Guid.NewGuid().ToString(),
                    Image = UserFunctions.GetRandomImages(random, gender),
                    Phone = UserFunctions.GetRandomPhoneNumber(random),
                    Cell = UserFunctions.GetRandomPhoneNumber(random),
                    Birth = DateTime.UtcNow.AddYears(-random.Next(18, 70)),
                    Name = new Name
                    {
                        Id = i + 1,
                        first = first,
                        last = last
                    },
                    Location = new Location
                    {
                        Id = i + 1,
                        StreetNumber = random.Next(1, 1000),
                        StreetName = UserFunctions.GetRandomStreetName(random),
                        City = UserFunctions.GetRandomCity(random),
                        State = UserFunctions.GetRandomState(random),
                        Country = UserFunctions.GetRandomCountry(random),
                        Postcode = random.Next(10000, 99999)
                    }
                };

                users.Add(user);
            }

            return users;
        }
    }
}
