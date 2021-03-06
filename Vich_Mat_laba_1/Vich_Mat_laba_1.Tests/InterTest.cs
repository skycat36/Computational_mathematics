// <copyright file="InterTest.cs">Copyright ©  2017</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vich_Mat_laba_1;

namespace Vich_Mat_laba_1.Tests
{
    /// <summary>Этот класс содержит параметризованные модульные тесты для Inter</summary>
    [PexClass(typeof(Inter))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class InterTest
    {
        /// <summary>Тестовая заглушка для LagrangInterp()</summary>
        [PexMethod]
        internal double LagrangInterpTest([PexAssumeUnderTest]Inter target)
        {
            double result = target.LagrangInterp();
            return result;
            // TODO: добавление проверочных утверждений в метод InterTest.LagrangInterpTest(Inter)
        }
    }
}
