using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libBindingLibrary.a", LinkTarget.Simulator, ForceLoad = true)]
