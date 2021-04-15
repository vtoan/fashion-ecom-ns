using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BUS;
using BUS.Domains;
using BUS.Services;
using Core.Controllers;
using Core.Tests.MockService;
using DAO.DAOs;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using Xunit;

namespace Core.Tests
{
    public class CategoryControllerTests : IClassFixture<SqliteInMemoryFixture>
    {
        private readonly SqliteInMemoryFixture _fixture;



        public CategoryControllerTests(SqliteInMemoryFixture fixture)
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
            var cateService = new CategoryService(cateDao, mapper);
            // test
            var cateController = new CategoryController(cateService);
            var result = cateController.GetList(1);
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
            var cateService = new CategoryService(cateDao, mapper);
            // test
            var categoryVM = new CategoryVM { Name = "Product Category Post", TypeProductId = 1 };
            var cateController = new CategoryController(cateService);
            var result = cateController.Create(categoryVM);

            var createAtAction = Assert.IsType<ActionResult<CategoryVM>>(result.Value);
            Assert.Equal("Product Category Post", createAtAction.Value.Name);
        }
    }
}