using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tournamenttracker.template.Domain.Entities;
using tournamenttracker.template.Infrastructure.Persistance.Mock;
using Xunit;

namespace tournamenttracker.template.Infrastructure.Tests
{
    public class PlayerRepoTests
    {
        private MockPlayerRepo _sut;
        public PlayerRepoTests()
        {
            _sut = new MockPlayerRepo();
        }


        [Theory]
        [InlineData("687094d3-87ec-4b93-8e95-0f4463e63e4c")]
        public void GetPlayer_ShouldGetPlayer_WhenGivenPlayerId(string guid)
        {
            // Arrange


            // Act
            var player = _sut.GetPlayer(Guid.Parse(guid));

            // Assert
           
        }
    }
}
