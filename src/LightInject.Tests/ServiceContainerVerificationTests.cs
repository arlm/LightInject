﻿#if NET40 || NET452 || NETSTANDARD11 || NETSTANDARD13 || NET46
using Xunit;

namespace LightInject.Tests
{
    using System;
    using System.IO;

    [Trait("Category", "Verification")]
    [Collection("Verification")]
    public class ServiceContainerVerificationTests : ServiceContainerTests
    {
        internal override IServiceContainer CreateContainer()
        {
            return VerificationContainerFactory.CreateContainerForAssemblyVerification();
        }
    }
}
#endif