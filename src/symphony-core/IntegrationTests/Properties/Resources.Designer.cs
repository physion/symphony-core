﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntegrationTests.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("IntegrationTests.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Controller
        ///[
        ///	Clock &quot;Clock&quot;
        ///	
        ///	DAQController &quot;Symphony.Heka,Symphony.Heka.HekaDAQController,&quot;
        ///	[
        ///		Provides Clock &quot;Clock&quot;
        ///		Clock &quot;Clock&quot;
        ///		Configuration
        ///		[
        ///
        ///		]
        ///		InputStream &quot;In0&quot; &quot;Symphony.Heka.HekaDAQInputStream&quot;
        ///		[
        ///			Clock &quot;Clock&quot;
        ///			Configuration
        ///			[
        ///				MeasurementConversionTarget &quot;V&quot;
        ///			]
        ///			SampleRate 1000 Hz
        ///		]
        ///		OutputStream &quot;Out0&quot; &quot;Symphony.Heka.HekaDAQOutputStream&quot;
        ///		[
        ///			Clock &quot;Clock&quot;
        ///			Configuration
        ///			[
        ///				MeasurementConversionTarget &quot;V&quot;
        ///			]
        ///			SampleRate  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HekaConfig {
            get {
                return ResourceManager.GetString("HekaConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Controller
        ///[
        ///	Clock &quot;Clock&quot;
        ///	
        ///	DAQController &quot;Symphony.SimulationDAQController,Symphony.SimulationDAQController.SimulationDAQController,&quot;
        ///	[
        ///		Provides Clock &quot;Clock&quot;
        ///		Clock &quot;Clock&quot;
        ///		Configuration
        ///		[
        ///
        ///		]
        ///		InputStream &quot;In0&quot; &quot;Symphony.Core.DAQInputStream&quot;
        ///		[
        ///			Clock &quot;Clock&quot;
        ///			Configuration
        ///			[
        ///				MeasurementConversionTarget &quot;V&quot;
        ///			]
        ///			SampleRate 1000 Hz
        ///		]
        ///		OutputStream &quot;Out0&quot; &quot;Symphony.Core.DAQOutputStream&quot;
        ///		[
        ///			Clock &quot;Clock&quot;
        ///			Configuration
        ///			[
        ///				MeasurementConver [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LowGainConfig {
            get {
                return ResourceManager.GetString("LowGainConfig", resourceCulture);
            }
        }
    }
}
