using System;
using System.Collections.Generic;
using ATest.Controllers;
using ATest.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Web;
using NUnit.Framework;

namespace Test
{
   


    [TestClass]
    public class UnitTest1
    {
        //private List<Book> GetTestBooks()
        //{
        //    var testBooks = new List<Book>();
        //    testBooks.Add(new Book { Id = 1, Author = "John Smith", Title = "SRE 101" });
        //    testBooks.Add(new Book { Id = 2, Author = "Jane Archer", Title = "DevOps is a lie" });

        //    return testBooks;
        //}

        [TestMethod]
        public void TestMethod1()
        {
           
        }


        //[TestMethod]
        //public void TestMetod2()
        //{
        //    var testBooks = GetTestBooks();
        //    var controller = new BookController(testBooks);

        //    var result = await controller.GetBook(1) as Book;//id 1 
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(testBooks[1].Author, result);
        //    Assert.AreEqual(testBooks[1].Title, result);
        //}

        //[TestMethod]
        //public void TestMetod3()
        //{
        //    var testBooks = GetTestBooks();
        //    var controller = new BookController(testBooks);

        //    var result = await controller.GetBook(2) as Book;//id 2
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(testBooks[2].Author, result);
        //    Assert.AreEqual(testBooks[2].Title, result);
        //}

    }
}
