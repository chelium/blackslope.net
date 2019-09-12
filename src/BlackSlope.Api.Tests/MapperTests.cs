using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace BlackSlope.Api.Tests
{
    public class MapperTests
    {
        private readonly IServiceCollection _services;

        public MapperTests()
        {
            _services = new ServiceCollection();
            _services.AddAutoMapper();
        }

        [Fact]
        public void Mapper_Successful()
        {
            var serviceProvider = _services.BuildServiceProvider();
            var mapper = (IMapper)serviceProvider.GetService(typeof(IMapper));
            mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}
