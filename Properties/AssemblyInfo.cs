﻿/* 
InjectModuleInitializer

Command line program to inject a module initializer into a .NET assembly.

Copyright (C) 2009-2016 Einar Egilsson
http://einaregilsson.com/module-initializers-in-csharp/

This program is licensed under the MIT license: http://opensource.org/licenses/MIT
 */
using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("InjectModuleInitializer")]
[assembly: AssemblyDescription("Inject a module initializer into a .NET assembly")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Einar Egilsson")]
[assembly: AssemblyProduct("InjectModuleInitializer")]
[assembly: AssemblyCopyright("Copyright © Einar Egilsson 2009-2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("945b78d2-a443-48d5-ad51-1abb4fa1d9f3")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.5.0.0")]
[assembly: AssemblyFileVersion("1.5.0.0")]
