﻿using System;
using Check.Exceptions;
using Shouldly;
using Xunit;

namespace Check.Tests
{
    public class CheckStringInvariantIsNotNullOrEmptyTests
    {
        [Fact]
        public void OnNonEmptyStringPasses()
        {
            const string test = "hi";

            Should.NotThrow(() => Check.That(() => test).IsNotNullOrEmpty());
        }

        [Fact]
        public void OnEmptyStringFails()
        {
            var test = string.Empty;

            Should.Throw<InvariantShouldNotBeNullOrEmptyException>(
                () => Check.That(() => test).IsNotNullOrEmpty());
        }

        [Fact]
        public void OnNullStringFails()
        {
            string test = null;

            Should.Throw<InvariantShouldNotBeNullOrEmptyException>(
                () => Check.That(() => test).IsNotNullOrEmpty());
        }

        [Fact]
        public void FailureMessageIsValid()
        {
            string test = null;

            var exception = Should.Throw<Exception>(() => Check.That(() => test).IsNotNullOrEmpty());

            exception.Message.ShouldBe("test should not be null or empty");
        }
    }
}
