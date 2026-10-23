using CustomerPortal.Backend.Helpers;
using CustomerPortal.Backend.UnitsOfWork.Interfaces;
using CustomerPortal.Shared.Entities;
using CustomerPortal.Shared.Enums;
using System.Runtime.InteropServices;

namespace CustomerPortal.Backend.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUsersUnitOfWork _usersUnitOfWork;
        private readonly IFileStorage _fileStorage;
        private readonly IRuntimeInformationWrapper _runtimeInformationWrapper;

        public SeedDb(DataContext context, IUsersUnitOfWork usersUnitOfWork, IFileStorage fileStorage,
             IRuntimeInformationWrapper runtimeInformationWrapper)
        {
           _context = context;
           _usersUnitOfWork = usersUnitOfWork;
           _fileStorage = fileStorage;
           _runtimeInformationWrapper = runtimeInformationWrapper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();           
            await CheckRolesAsync();
            await CheckUsersAsync();

        }

        private async Task CheckUsersAsync()
        {
            await CheckUserAsync("Ahmed", "Almershady", "Ahmednet380@gmail.com", "+964", "322 311 4620", "babil 40 strret hilla", "AhmedAlmershady.jpg", UserType.Admin , UserStatus.Active);
            await CheckUserAsync("Ledys", "Bedoya", "ledys@gmail.com", "+964", "322 311 4620", "babil 40 strret hilla", "LedysBedoya.jpg", UserType.User, UserStatus.Active);
            await CheckUserAsync("Brad", "Pitt", "brad@gmail.com", "+964", "322 311 4620", "babil 40 strret hilla", "Brad.jpg", UserType.User, UserStatus.Active);
            await CheckUserAsync("Angelina", "Jolie", "angelina@gmail.com", "+964", "322 311 4620", "babil 40 strret hilla", "Angelina.jpg", UserType.User, UserStatus.Active);
            await CheckUserAsync("Bob", "Marley", "bob@gmail.com", "+964", "322 311 4620", "babil 40 strret hilla", "bob.jpg", UserType.User, UserStatus.Active);
            await CheckUserAsync("Celia", "Cruz", "celia@gmail.com", "+964", "322 311 4620", "babil 40 strret hilla", "celia.jpg", UserType.Admin, UserStatus.Active);
            await CheckUserAsync("Fredy", "Mercury", "fredy@gmail.com", "+964", "322 311 4620", "babil 40 strret hilla", "fredy.jpg", UserType.User, UserStatus.Active);
            await CheckUserAsync("Hector", "Lavoe", "hector@gmail.com", "+964", "322 311 4620", "babil 40 strret hilla", "hector.jpg", UserType.User, UserStatus.Active);
            await CheckUserAsync("Liv", "Taylor", "liv@gmail.com", "+964", "322 311 4620", "babil 40 strret hilla", "liv.jpg", UserType.User, UserStatus.Active);
            await CheckUserAsync("Otep", "Shamaya", "otep@gmail.com", "+964", "322 311 4620", "babil 40 strret hilla", "otep.jpg", UserType.User, UserStatus.Active);
            await CheckUserAsync("Ozzy", "Osbourne", "ozzy@gmail.com", "+964", "322 311 4620", "babil 40 strret hilla", "ozzy.jpg", UserType.User, UserStatus.Active);
            await CheckUserAsync("Selena", "Quintanilla", "selenba@gmail.com", "+964", "322 311 4620", "babil 40 strret hilla", "selena.jpg", UserType.User, UserStatus.Active);
        }

        private async Task<User> CheckUserAsync(string firstName, string lastName, string email, string countryCode,
            string phoneNumber, string address, string image, UserType userType , UserStatus userStatus)
        {
            var user = await _usersUnitOfWork.GetUserAsync(email);
            if (user == null)
            {
               
                string filePath;
                if (_runtimeInformationWrapper.IsOSPlatform(OSPlatform.Windows))
                {
                    filePath = $"{Environment.CurrentDirectory}\\images\\users\\{image}";
                }
                else
                {
                    filePath = $"{Environment.CurrentDirectory}/images/users/{image}";
                }

                var fileBytes = File.ReadAllBytes(filePath);
                var imagePath = await _fileStorage.SaveFileAsync(fileBytes, ".jpg", "users");

                user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    PhoneNumber = phoneNumber,
                    Address = address,                   
                    UserType = userType,
                    Photo = imagePath,
                    UserStatus= userStatus,
                    CountryCode = "+964"
                };

                await _usersUnitOfWork.AddUserAsync(user, "Function@80");
                await _usersUnitOfWork.AddUserToRoleAsync(user, userType.ToString());

                var token = await _usersUnitOfWork.GenerateEmailConfirmationTokenAsync(user);
                await _usersUnitOfWork.ConfirmEmailAsync(user, token);
            }

            return user;

        }

       

        private async Task CheckRolesAsync()
        {
            await _usersUnitOfWork.CheckRoleAsync(UserType.Admin.ToString());
            await _usersUnitOfWork.CheckRoleAsync(UserType.User.ToString());
        }
    }
}
