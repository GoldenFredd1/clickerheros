//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clickerheroes.autoplayer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("228")]
        public int top {
            get {
                return ((int)(this["top"]));
            }
            set {
                this["top"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1027")]
        public int bot {
            get {
                return ((int)(this["bot"]));
            }
            set {
                this["bot"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("96")]
        public int left {
            get {
                return ((int)(this["left"]));
            }
            set {
                this["left"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1516")]
        public int right {
            get {
                return ((int)(this["right"]));
            }
            set {
                this["right"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"//Start the game idle
Idle

// Level important low level ancients and get upgrades
0, 150, -1
1, 100, -1
2, 100, -1
4, 100, -1
5, 100, -1
7, 75, -1
9, 100, -1
11, 100, -1
12, 100, -1
13, 100, -1
14, 100, -1
15, 125, -1
16, 125, -1
17, 75, -1
19, 75, -1
20, 100, -1
22, 125, -1
23, 100 ,-1
24, 75, -1
25, 75, -1
BuyAllUpgrades

// Start progressing Tera
28, 1, -1
28, 10, 0
28, 30, 1
28, 50, 2
28, 100, 3, false, true
28, 1500, -1, false, true

// Start progressing Lilin and go Active
31, 1, -1
31, 10, 0
31, 25, 1
31, 50, 2
31, 100, 3, false, true
Active
31, 1500, -1, false, true

// Time to ascend Lilin reached 1500)
// This should always be the last task
Ascend")]
        public string taskList {
            get {
                return ((string)(this["taskList"]));
            }
            set {
                this["taskList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool useTaskList {
            get {
                return ((bool)(this["useTaskList"]));
            }
            set {
                this["useTaskList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool autoSkill {
            get {
                return ((bool)(this["autoSkill"]));
            }
            set {
                this["autoSkill"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool autoClicking {
            get {
                return ((bool)(this["autoClicking"]));
            }
            set {
                this["autoClicking"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool logging {
            get {
                return ((bool)(this["logging"]));
            }
            set {
                this["logging"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        public int dogcog {
            get {
                return ((int)(this["dogcog"]));
            }
            set {
                this["dogcog"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("55")]
        public int maxRunDuration {
            get {
                return ((int)(this["maxRunDuration"]));
            }
            set {
                this["maxRunDuration"] = value;
            }
        }
    }
}
