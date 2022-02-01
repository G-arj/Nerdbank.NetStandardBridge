# Nerdbank.NetStandardBridge

***A reference + facade library to bring additional types to .NET Standard.***

[![NuGet package](https://img.shields.io/nuget/v/Nerdbank.NetStandardBridge.svg)](https://nuget.org/packages/Nerdbank.NetStandardBridge)

## Features

Defines the following types in a .NET Standard 2.0 library:

* `ImportedFromTypeLibAttribute`
* `TypeLibVersionAttribute`

These types get forwarded to the appropriate runtime types.
The assembly in the package *is* required at runtime unless all referencing projects actually target a framework that already defines the attributes.
