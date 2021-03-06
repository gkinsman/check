﻿using System;
using Shouldly;
using Xunit;

namespace Checkk.Tests
{
    public class TestsForExamples
    {
        [Fact]
        public void FirstSetOfReadmeExamples()
        {
            var firstName = "";
            var lastName = "Lastname";
            var dateOfBirth = new DateTime(1989, 1, 1);

            Check.That(() => firstName).IsNotNull();
            Check.That(() => lastName).IsNotNullOrEmpty();
            Check.That(() => dateOfBirth.Year < 1990);

            var i1 = 10;
            var ex1 = Should.Throw<Exception>(() => Check.That(() => i1 > 20).IsTrue());
            ex1.Message.ShouldBe("(i1 > 20) should be true");
        }
    }
}
