﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Facturacion.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://facturacion-terpel-gtic-apimanager-dev-apicast-production.cloudapps.terpe" +
            "l.com/facturacion/services/EnviarFacturaDian")]
        public string Facturacion_FacturaFuses_EnviarFacturaDian {
            get {
                return ((string)(this["Facturacion_FacturaFuses_EnviarFacturaDian"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("https://facturacion-terpel-gtic-apimanager-dev-apicast-production.cloudapps.terpe" +
            "l.com/facturacion/services/EnviarFacturaDian")]
        public string Facturacion_FacturaFuse_EnviarFacturaDian {
            get {
                return ((string)(this["Facturacion_FacturaFuse_EnviarFacturaDian"]));
            }
        }
    }
}
