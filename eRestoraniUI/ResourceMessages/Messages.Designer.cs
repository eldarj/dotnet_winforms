﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eRestoraniUI.ResourceMessages {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("eRestoraniUI.ResourceMessages.Messages", typeof(Messages).Assembly);
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
        ///   Looks up a localized string similar to Email je u pogrešnom formatu.
        /// </summary>
        internal static string edit_restoran_email_format_error {
            get {
                return ResourceManager.GetString("edit_restoran_email_format_error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Polje Email ne smije biti prazno.
        /// </summary>
        internal static string edit_restoran_obavezno_polje_email {
            get {
                return ResourceManager.GetString("edit_restoran_obavezno_polje_email", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Polje Naziv ne smije biti prazno.
        /// </summary>
        internal static string edit_restoran_obavezno_polje_naziv {
            get {
                return ResourceManager.GetString("edit_restoran_obavezno_polje_naziv", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unijeli ste pogrešno korisničko ime ili lozinku.
        /// </summary>
        internal static string login_user_fail {
            get {
                return ResourceManager.GetString("login_user_fail", resourceCulture);
            }
        }
    }
}