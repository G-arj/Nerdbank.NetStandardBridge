// Copyright (c) Andrew Arnott. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if NETSTANDARD2_0

namespace System.Runtime.InteropServices
{
    /// <summary>Specifies the version number of an exported type library.</summary>
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [ComVisible(true)]
    public sealed class TypeLibVersionAttribute : Attribute
    {
        /// <summary>Initializes a new instance of the <see cref="System.Runtime.InteropServices.TypeLibVersionAttribute" /> class with the major and minor version numbers of the type library.</summary>
        /// <param name="major">The major version number of the type library.</param>
        /// <param name="minor">The minor version number of the type library.</param>
        public TypeLibVersionAttribute(int major, int minor)
        {
            this.MajorVersion = major;
            this.MinorVersion = minor;
        }

        /// <summary>Gets the major version number of the type library.</summary>
        /// <returns>The major version number of the type library.</returns>
        public int MajorVersion { get; }

        /// <summary>Gets the minor version number of the type library.</summary>
        /// <returns>The minor version number of the type library.</returns>
        public int MinorVersion { get; }
    }
}

#else

[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Runtime.InteropServices.TypeLibVersionAttribute))]

#endif
