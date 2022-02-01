// Copyright (c) Andrew Arnott. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Reflection;
using System.Runtime.InteropServices;

public class AttributesTests
{
#if NETCOREAPP3_1_OR_GREATER
    [Theory]
    [InlineData(typeof(TypeLibVersionAttribute))]
    [InlineData(typeof(ImportedFromTypeLibAttribute))]
    [Trait("Category", "SkipWhenLiveUnitTesting")] // fails because forwarded types aren't compiled in, I guess
    public void TypeForwardersInPlace(Type type)
    {
        Assembly lib = Assembly.Load($"Nerdbank.NetStandardBridge");
        Assert.Contains(type, lib.GetForwardedTypes());
    }
#endif
}
