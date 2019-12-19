using CarCity.Models;
using CarCity.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject1
{
    public class RoleServiceTests
    {
        [Fact]
        public async Task AddTest()
        {
            var fakeRepository = Mock.Of<IRoleRepository>();
            var movieService = new RoleService(fakeRepository);
            var movie = new Role() { Name = "Create Actor" };
            await movieService.AddAndSave(movie);
        }
        [Fact]
        public async Task GetMoviesTest()
        {
            var movies = new List<Role>
            {
                new Role() { Name = "test movie 1" },
                new Role() { Name = "test movie 2" },
            };

            var fakeRepositoryMock = new Mock<IRoleRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(movies);


            var movieService = new RoleService(fakeRepositoryMock.Object);

            var resultMovies = await movieService.GetRoles();

            Assert.Collection(resultMovies, movie =>
            {
                Assert.Equal("test movie 1", movie.Name);
            },
            movie =>
            {
                Assert.Equal("test movie 2", movie.Name);
            });
        }
    }
}
