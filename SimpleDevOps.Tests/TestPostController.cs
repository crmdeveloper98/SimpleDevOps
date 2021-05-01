﻿using Microsoft.AspNetCore.Mvc;
using SimpleDevOps.Controllers;
using SimpleDevOps.Models;
using SimpleDevOps.Repository;
using System;
using System.Collections.Generic;
using Xunit;

namespace SimpleDevOps.Tests
{
    public class TestPostController : IDisposable
    {
        private PostRepository _repository;

        public TestPostController() => _repository = new PostRepository();

        [Fact]
        public void Test_Index_View_Result()
        {
            //Arrange
            var controller = new HomeController(null, _repository);
            //Act
            var result = controller.Index();
            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Test_Index_Return_Result()
        {
            //Arrange 
            var controller = new HomeController(null, _repository);
            //Act 
            var result = controller.Index();
            //Assert 
            Assert.NotNull(result);
        }

        [Fact]
        public void Test_Index_GetPosts_MatchData()
        {
            //Arrange 
            var controller = new HomeController(null, _repository);
            //Act 
            var result = controller.Index();
            //Assert 
            var viewResult = Assert.IsType<ViewResult>(result);
            var model =
           Assert.IsAssignableFrom<List<PostViewModel>>(viewResult.ViewData.Model);
            Assert.Equal(3, model.Count);
            Assert.Equal(101, model[0].Id);
            Assert.Equal("DevOps Demo Title 1", model[0].Title);
        }

        public void Dispose()
        {
            _repository = null;
        }
    }
}
