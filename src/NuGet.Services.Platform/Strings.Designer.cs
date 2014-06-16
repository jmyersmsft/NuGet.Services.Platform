﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.Services {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.Services.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to This request cannot be performed over an insecure connection. Retry your request using HTTPS..
        /// </summary>
        internal static string AdminKeyAuthenticationHandler_CannotAuthenticateOverHttp {
            get {
                return ResourceManager.GetString("AdminKeyAuthenticationHandler_CannotAuthenticateOverHttp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not load NuGet Services Platform. Ensure the target service has at least version 3.0.3 of the services platform installed..
        /// </summary>
        internal static string AppLauncher_CouldNotLoadPlatform {
            get {
                return ResourceManager.GetString("AppLauncher_CouldNotLoadPlatform", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find an Azure Management Certificate. Use the &quot;Azure.ManagementCertThumbprint&quot; config setting to specify one..
        /// </summary>
        internal static string AzureHub_MissingCertificate {
            get {
                return ResourceManager.GetString("AzureHub_MissingCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not identify the Azure Subscription for the current environment. Expected the certificate to contain the Subscription Name and ID in the Target portion of the Subject Name. For example: &quot;CN=nuget-env-0-service, OU=SubName[SubId], OU=azure-management, OU=env, OU=nuget-services ...&quot;.
        /// </summary>
        internal static string AzureHub_MissingSubscription {
            get {
                return ResourceManager.GetString("AzureHub_MissingSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; was specified in configuration, but &quot;{1}&quot; was not. BOTH &quot;Azure.SubscriptionId&quot; and &quot;Azure.SubscriptionName&quot; MUST be specified if one is specified..
        /// </summary>
        internal static string AzureHub_MissingSubscriptionConfigSetting {
            get {
                return ResourceManager.GetString("AzureHub_MissingSubscriptionConfigSetting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;null&gt;.
        /// </summary>
        internal static string AzureHub_NullThumbprint {
            get {
                return ResourceManager.GetString("AzureHub_NullThumbprint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to start service host!.
        /// </summary>
        internal static string ConsoleApplicationHost_FailedToStart {
            get {
                return ResourceManager.GetString("ConsoleApplicationHost_FailedToStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service host is starting, press Ctrl-C to shut down..
        /// </summary>
        internal static string ConsoleApplicationHost_Running {
            get {
                return ResourceManager.GetString("ConsoleApplicationHost_Running", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid Datacenter Name. Expected a name in the format: &quot;&lt;product&gt;-&lt;environment&gt;-&lt;datacenter id&gt;&quot;.
        /// </summary>
        internal static string DatacenterName_InvalidName {
            get {
                return ResourceManager.GetString("DatacenterName_InvalidName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid Environment Name. Expected a name in the format: &quot;&lt;product&gt;-&lt;environment&gt;&quot;.
        /// </summary>
        internal static string EnvironmentName_InvalidName {
            get {
                return ResourceManager.GetString("EnvironmentName_InvalidName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation would cause current position to move beyond the maximum allowed read length of {1}.
        /// </summary>
        internal static string MaxSizeStream_PositionIsPastMaximumAllowedLength {
            get {
                return ResourceManager.GetString("MaxSizeStream_PositionIsPastMaximumAllowedLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unknown error occurred..
        /// </summary>
        internal static string NuGetHttpService_UnknownError {
            get {
                return ResourceManager.GetString("NuGetHttpService_UnknownError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Host must be set using SetHost before invoking this method..
        /// </summary>
        internal static string NuGetService_HostNotSet {
            get {
                return ResourceManager.GetString("NuGetService_HostNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, I don&apos;t know how to make coffee. I can make a nice Earl Grey though!.
        /// </summary>
        internal static string NuGetServiceInformationMiddleware_Body {
            get {
                return ResourceManager.GetString("NuGetServiceInformationMiddleware_Body", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I&apos;m a teapot.
        /// </summary>
        internal static string NuGetServiceInformationMiddleware_ReasonPhrase {
            get {
                return ResourceManager.GetString("NuGetServiceInformationMiddleware_ReasonPhrase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The zip entry&apos;s claimed decompressed size is incorrect..
        /// </summary>
        internal static string SafeZipPackage_EntryDecompressedSizeIncorrect {
            get {
                return ResourceManager.GetString("SafeZipPackage_EntryDecompressedSizeIncorrect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The zip entry size is invalid..
        /// </summary>
        internal static string SafeZipPackage_EntryLengthInvalid {
            get {
                return ResourceManager.GetString("SafeZipPackage_EntryLengthInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The zip entry is larger than the allowed size..
        /// </summary>
        internal static string SafeZipPackage_EntryTooLong {
            get {
                return ResourceManager.GetString("SafeZipPackage_EntryTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package does not contain a manifest..
        /// </summary>
        internal static string SafeZipPackage_MissingManifest {
            get {
                return ResourceManager.GetString("SafeZipPackage_MissingManifest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown Sql Server: {0}.
        /// </summary>
        internal static string ServiceConfiguration_UnknownSqlServer {
            get {
                return ResourceManager.GetString("ServiceConfiguration_UnknownSqlServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown Storage Account: {0}.
        /// </summary>
        internal static string ServiceConfiguration_UnknownStorageAccount {
            get {
                return ResourceManager.GetString("ServiceConfiguration_UnknownStorageAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service type must be a class.
        /// </summary>
        internal static string ServiceDefinition_TypeMustBeClass {
            get {
                return ResourceManager.GetString("ServiceDefinition_TypeMustBeClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service type must be non-abstract.
        /// </summary>
        internal static string ServiceDefinition_TypeMustBeNonAbstract {
            get {
                return ResourceManager.GetString("ServiceDefinition_TypeMustBeNonAbstract", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service type must inherit from NuGetService.
        /// </summary>
        internal static string ServiceDefinition_TypeMustInheritFromNuGetService {
            get {
                return ResourceManager.GetString("ServiceDefinition_TypeMustInheritFromNuGetService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This host does not support IP endpoints.
        /// </summary>
        internal static string ServiceHost_DoesNotSupportEndpoints {
            get {
                return ResourceManager.GetString("ServiceHost_DoesNotSupportEndpoints", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid NuGetService, it must inherit from NuGet.Services.NuGetService.
        /// </summary>
        internal static string ServiceHost_NotAValidServiceType {
            get {
                return ResourceManager.GetString("ServiceHost_NotAValidServiceType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid Service Host Instance Name. Expected a name in the format: &quot;&lt;product&gt;-&lt;environment&gt;-&lt;datacenter id&gt;-&lt;host name&gt;_IN&lt;instance id&gt;&quot;.
        /// </summary>
        internal static string ServiceHostInstanceName_InvalidName {
            get {
                return ResourceManager.GetString("ServiceHostInstanceName_InvalidName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid Service Host Name. Expected a name in the format: &quot;&lt;product&gt;-&lt;environment&gt;-&lt;datacenter id&gt;-&lt;host name&gt;&quot;.
        /// </summary>
        internal static string ServiceHostName_InvalidName {
            get {
                return ResourceManager.GetString("ServiceHostName_InvalidName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid Service Name. Expected a name in the format: &quot;&lt;product&gt;-&lt;environment&gt;-&lt;datacenter id&gt;-&lt;host name&gt;_IN&lt;instance id&gt;-&lt;service name&gt;&quot;.
        /// </summary>
        internal static string ServiceName_InvalidName {
            get {
                return ResourceManager.GetString("ServiceName_InvalidName", resourceCulture);
            }
        }
    }
}
