using System.Threading.Tasks;
using BUS.Domains;
using BUS.Services;
using Core.Tests.MockService;
using DAO.DAOs;
using Shared.ViewModels;
using Xunit;

namespace Core.Tests
{
    public class CategoryDAOTests : IClassFixture<SqliteInMemoryFixture>
    {
        private readonly SqliteInMemoryFixture _fixture;


        public CategoryDAOTests(SqliteInMemoryFixture fixture)
        {
            _fixture = fixture;
            _fixture.CreateDatabase();
        }

        [Fact]
        public async Task GetCate_Success()
        {
            // get MOCK
            var mapper = MapperMock.Get();
            // initial mock data
            var dbContext = _fixture.Context;
            dbContext.TypeProducts.Add(new TypeProduct { Name = "Product Type" });
            var category = new Category { Name = "Product Category", TypeProductId = 1 };
            dbContext.Categories.Add(category);
            await dbContext.SaveChangesAsync();
            // create dependency
            var cateDao = new CategoryDAO(dbContext);
            //test
            var result = cateDao.GetListItems(1);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void PostCate_Success()
        {
            // get MOCK
            var mapper = MapperMock.Get();
            // initial mock data
            var dbContext = _fixture.Context;
            dbContext.TypeProducts.Add(new TypeProduct { Name = "Product Type" });
            // create dependency
            var cateDao = new CategoryDAO(dbContext);
            // test
            var category = new Category { Name = "Product Category Post", TypeProductId = 1 };
            var result = cateDao.AddItem(category);

            var createAtAction = Assert.IsType<CategoryVM>(result);
            Assert.Equal("Product Category Post", createAtAction.Name);
        }
    }
}