// Copyright (c) Andrew Arnott. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if NETSTANDARD2_0

namespace System.Runtime.InteropServices
{
    /// <summary>Indicates that the types defined within an assembly were originally defined in a type library.</summary>
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [ComVisible(true)]
    public sealed class ImportedFromTypeLibAttribute : Attribute
    {
        /// <summary>Initializes a new instance of the <see cref="System.Runtime.InteropServices.ImportedFromTypeLibAttribute" /> class with the name of the original type library file.</summary>
        /// <param name="tlbFile">The location of the original type library file.</param>
        public ImportedFromTypeLibAttribute(string tlbFile)
        {
            this.Value = tlbFile;
        }

        /// <summary>Gets the name of the original type library file.</summary>
        /// <returns>The name of the original type library file.</returns>
        public string Value { get; }
    }
}

#else

[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Runtime.InteropServices.ImportedFromTypeLibAttribute))]

#endif
