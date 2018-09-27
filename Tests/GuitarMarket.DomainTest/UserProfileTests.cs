using GuitarMarket.Domain.UserProfiles;
using System;
using Xunit;

namespace GuitarMarket.DomainTest
{
    public class UserProfileTests
    {

        private readonly UserProfile _profile;
        private const int Id = 1;



        public UserProfileTests()
        {
            _profile = new UserProfile();
        }

        [Fact]
        public void TestSetAndGetId()
        {
            _profile.Id = Id;

            Assert.Equal(_profile.Id,Id);
        }

        [Theory]
        [InlineData("Test User Name")]
        public void TestSetAndGetUserNasme(string userName)
        {
            _profile.UserName = userName;

            Assert.Equal(_profile.UserName, userName);
        }
    }
}
