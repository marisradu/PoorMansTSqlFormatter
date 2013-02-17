﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5448
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoorMansTSqlFormatterSSMSAddIn.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase, PoorMansTSqlFormatterPluginShared.ISqlSettings {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }

        public PoorMansTSqlFormatterLib.Formatters.TSqlStandardFormatterOptions Options
        {
            get
            {
                return new PoorMansTSqlFormatterLib.Formatters.TSqlStandardFormatterOptions(OptionsSerialized);
            }
            set
            {
                OptionsSerialized = value.ToSerializedString();
            }
        }

        private const string LOAD_LEGACY = "~load options from backward compatible settings";

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(LOAD_LEGACY)]
        public string OptionsSerialized
        {
            get
            {
                string serializedOptions = (string)this["OptionsSerialized"];
                if (serializedOptions == LOAD_LEGACY)
                    serializedOptions = LoadFromLegacySettings();
                return serializedOptions;
            }
            set
            {
                this["OptionsSerialized"] = value;
            }
        }

        private string LoadFromLegacySettings()
        {

            // In previous versions the Options were stored in individual setting properties.
            // So that this and future versions are backward compatible, 
            // If the settings file doesn't contain an Options element assume that the file has the old individual settings.

            var options = new PoorMansTSqlFormatterLib.Formatters.TSqlStandardFormatterOptions()
            {
                ExpandCommaLists = this.ExpandCommaLists,
                TrailingCommas = this.TrailingCommas,
                ExpandBooleanExpressions = this.ExpandBooleanExpressions,
                ExpandCaseStatements = this.ExpandCaseStatements,
                ExpandBetweenConditions = this.ExpandBetweenConditions,
                UppercaseKeywords = this.UppercaseKeywords,
                IndentString = this.IndentString,
                SpaceAfterExpandedComma = this.SpaceAfterExpandedComma,
                SpacesPerTab = this.SpacesPerTab,
                MaxLineWidth = this.MaxLineWidth,
                KeywordStandardization = this.KeywordStandardization,
                BreakJoinOnSections = this.BreakJoinOnSections
            };

            return options.ToSerializedString();

        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExpandCommaLists {
            get {
                return ((bool)(this["ExpandCommaLists"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TrailingCommas {
            get {
                return ((bool)(this["TrailingCommas"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExpandBooleanExpressions {
            get {
                return ((bool)(this["ExpandBooleanExpressions"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExpandCaseStatements {
            get {
                return ((bool)(this["ExpandCaseStatements"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExpandBetweenConditions {
            get {
                return ((bool)(this["ExpandBetweenConditions"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UppercaseKeywords {
            get {
                return ((bool)(this["UppercaseKeywords"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\t")]
        public string IndentString {
            get {
                return ((string)(this["IndentString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UpgradeCompleted {
            get {
                return ((bool)(this["UpgradeCompleted"]));
            }
            set {
                this["UpgradeCompleted"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Text Editor::Ctrl+K, Ctrl+F")]
        public string Hotkey {
            get {
                return ((string)(this["Hotkey"]));
            }
            set {
                this["Hotkey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SpaceAfterExpandedComma {
            get {
                return ((bool)(this["SpaceAfterExpandedComma"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int SpacesPerTab {
            get {
                return ((int)(this["SpacesPerTab"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("999")]
        public int MaxLineWidth {
            get {
                return ((int)(this["MaxLineWidth"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool KeywordStandardization {
            get {
                return ((bool)(this["KeywordStandardization"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool BreakJoinOnSections {
            get {
                return ((bool)(this["BreakJoinOnSections"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FirstInstallCompleted {
            get {
                return ((bool)(this["FirstInstallCompleted"]));
            }
            set {
                this["FirstInstallCompleted"] = value;
            }
        }
    }
}
