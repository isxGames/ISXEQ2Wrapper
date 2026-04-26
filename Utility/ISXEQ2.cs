using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.Utility
{
    /// <summary>
    /// Represents all of the data available about ISXEQ2 itself
    /// </summary>
    public class ISXEQ2 : LavishScriptObject
    {

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public ISXEQ2(LavishScriptObject copy) : base(copy) { }

        /// <summary>
        /// Constructor
        /// </summary>
        public ISXEQ2() : base(LavishScript.Objects.GetObject("ISXEQ2")) { }

        #endregion

        #region Members

        /// <summary>
        /// The ISXEQ2 API version string. Distinct from the build/product Version member.
        /// </summary>
        public string APIVersion
        {
            get
            {
                Trace.WriteLine(String.Format("ISXEQ2:APIVersion"));
                return this.GetStringFromLSO("APIVersion");
            }
        }

        /// <summary>
        /// Indicates whether or not Affliction Events are on or off
        /// </summary>
        public bool AfflictionEventsOn
        {
            get
            {
                Trace.WriteLine(String.Format("ISXEQ2:AfflictionEventsOn"));
                return this.GetBoolFromLSO("AfflictionEventsOn");
            }
        }

        /// <summary>
        /// Returns the total amount of EQ2Locations in the current zone or all zones
        /// </summary>
        /// <param name="allZones">show all zones</param>
        public int EQ2LocsCount(bool allZones = false)
        {   
            Trace.WriteLine(String.Format("ISXEQ2:EQ2LocsCount"));
            return !allZones ? this.GetIntFromLSO("EQ2LocsCount") : this.GetIntFromLSO("EQ2LocsCount", "AllZones");
        }

        /// <summary>
        /// Converts an amount of silver into a formatted currency string of the form
        /// "#p,#g,#s,#c". Internally the source converts to copper (silver*100) before
        /// formatting.
        /// </summary>
        /// <param name="amountInSilver">amount expressed in silver</param>
        /// <returns>formatted currency string</returns>
        public string GetCurrencyString(double amountInSilver)
        {
            Trace.WriteLine(String.Format("ISXEQ2:GetCurrencyString({0})",
                amountInSilver.ToString(CultureInfo.InvariantCulture)));
            return this.GetStringFromLSO("GetCurrencyString",
                amountInSilver.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Reads a previously-stored ISXEQ2 custom variable as a string. Returns the
        /// empty string when no variable with the given name has been stored.
        /// </summary>
        /// <param name="name">variable name</param>
        /// <returns>variable value as a string</returns>
        public string GetCustomVariable(string name)
        {
            Trace.WriteLine(String.Format("ISXEQ2:GetCustomVariable({0})", name));
            return this.GetStringFromLSO("GetCustomVariable", name);
        }

        /// <summary>
        /// Reads a previously-stored ISXEQ2 custom variable, parsed as the requested
        /// type. Valid 'type' values: "str", "int", "uint", "bool", "float". Returns
        /// the raw string form of the value (caller parses if a typed result is
        /// desired); supplying the type token influences the underlying source-side
        /// conversion path. Returns the empty string / "0" / "-1" on lookup miss
        /// depending on type.
        /// </summary>
        /// <param name="name">variable name</param>
        /// <param name="type">"str" / "int" / "uint" / "bool" / "float"</param>
        /// <returns>variable value as a string</returns>
        public string GetCustomVariable(string name, string type)
        {
            Trace.WriteLine(String.Format("ISXEQ2:GetCustomVariable({0}, {1})", name, type));
            return this.GetStringFromLSO("GetCustomVariable", name, type);
        }

        /// <summary>
        /// Indicates whether or not Actor Effects are initializing
        /// </summary>
        public bool InitializingActorEffects
        {
            get
            {
                Trace.WriteLine(String.Format("ISXEQ2:InitializingActorEffects"));
                return this.GetBoolFromLSO("InitializingActorEffects");
            }
        }

        /// <summary>
        /// Cached value of IsReady
        /// </summary>
        private bool? _isReady;

        /// <summary>
        /// Returns TRUE when the authentication and patching routines are complete and ISXEQ2 is truly ready.
        /// </summary>
        public bool IsReady
        {
            get
            {
                Trace.WriteLine(String.Format("ISXEQ2:IsReady"));
                if(!_isReady.HasValue)
                    _isReady = this.GetBoolFromLSO("IsReady");
                return _isReady.Value;
            }
        }

        /// <summary>
        /// Returns a boolean indicating whether or not a key board key is a valid eq2press key
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns>boolean indicating whether or not the key is valid</returns>
        public bool IsValidEQ2PressKey(string keyName)
        {
            Trace.WriteLine(String.Format("ISXEQ2:IsValidEQ2PressKey({0})", keyName));
            return this.GetBoolFromLSO("IsValidEQ2PressKey", keyName);
        }

        /// <summary>
        /// Rounds a numeric value to the nearest multiple of 'multiple' using the
        /// supplied numeric type. Valid 'type' values: "float", "int", "uint",
        /// "double". Returns the rounded value as a string (caller parses if a
        /// typed result is desired).
        /// </summary>
        /// <param name="type">"float" / "int" / "uint" / "double"</param>
        /// <param name="value">value to round</param>
        /// <param name="multiple">multiple to round to</param>
        /// <returns>rounded value as a string</returns>
        public string Round(string type, double value, double multiple)
        {
            Trace.WriteLine(String.Format("ISXEQ2:Round({0}, {1}, {2})", type,
                value.ToString(CultureInfo.InvariantCulture),
                multiple.ToString(CultureInfo.InvariantCulture)));
            return this.GetStringFromLSO("Round", type,
                value.ToString(CultureInfo.InvariantCulture),
                multiple.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Cached value of Version
        /// </summary>
        private string _version;

        /// <summary>
        /// The ISXEQ2 version
        /// </summary>
        public string Version
        {
            get
            {
                Trace.WriteLine(String.Format("ISXEQ2:Version"));
                return _version ?? (_version = this.GetStringFromLSO("Version"));
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Used to add an EQ2Location
        /// </summary>
        /// <param name="label">EQ2Location label</param>
        public bool AddLoc(string label)
        {
            Trace.WriteLine(String.Format("ISXEQ2:AddLoc({0})", label));
            return this.ExecuteMethod("AddLoc", label);
        }

        /// <summary>
        /// Used to add an EQ2Location
        /// </summary>
        /// <param name="label">EQ2location label</param>
        /// <param name="notes">EQ2Location notes</param>
        public bool AddLoc(string label, string notes)
        {
            Trace.WriteLine(String.Format("ISXEQ2:AddLoc({0}, {1})", label, notes));
            return this.ExecuteMethod("AddLoc", label, notes);
        }

        /// <summary>
        /// Clears the abilities cache which means it will be rebuilt automatically when abilities are next used
        /// </summary>
        public bool ClearAbilitiesCache()
        {
            Trace.WriteLine(String.Format("ISXEQ:ClearAbilitiesCache()"));
            return this.ExecuteMethod("ClearAbilitiesCache");
        }

        /// <summary>
        /// Clears all user-defined ISXEQ2 custom variables (those previously set via
        /// SetCustomVariable / read via GetCustomVariable).
        /// </summary>
        /// <returns>call success</returns>
        public bool ClearAllCustomVariables()
        {
            Trace.WriteLine(String.Format("ISXEQ2:ClearAllCustomVariables()"));
            return this.ExecuteMethod("ClearAllCustomVariables");
        }

        /// <summary>
        /// Clears the recipes cache. Currently a no-op in the source implementation
        /// (TODO-ADDBACK noted at DT-Miscellaneous.cpp:1209) but the method is still
        /// registered and dispatchable; included for forward compatibility.
        /// </summary>
        /// <returns>call success</returns>
        public bool ClearRecipesCache()
        {
            Trace.WriteLine(String.Format("ISXEQ2:ClearRecipesCache()"));
            return this.ExecuteMethod("ClearRecipesCache");
        }

        /// <summary>
        /// Disables Actor Events
        /// </summary>
        public bool DisableActorEvents()
        {
            Trace.WriteLine(String.Format("ISXEQ2:DisableActorEvents()"));
            return this.ExecuteMethod("DisableActorEvents");
        }

        /// <summary>
        /// Disables Affliction Events
        /// </summary>
        public bool DisableAfflictionEvents()
        {
            Trace.WriteLine(String.Format("DisableAfflictionEvents()"));
            return this.ExecuteMethod("DisableAfflictionEvents");
        }

        /// <summary>
        /// Disables ISXEQ2's custom zoning text overlays. The toggle is persisted to
        /// the General settings section ("Custom Zoning Texts Enabled").
        /// </summary>
        /// <returns>call success</returns>
        public bool DisableCustomZoningText()
        {
            Trace.WriteLine(String.Format("ISXEQ2:DisableCustomZoningText()"));
            return this.ExecuteMethod("DisableCustomZoningText");
        }

        /// <summary>
        /// Enables Actor Events
        /// </summary>
        public bool EnableActorEvents()
        {
            Trace.WriteLine(String.Format("ISXEQ2:EnableActorEvents()"));
            return this.ExecuteMethod("EnableActorEvents");
        }

        /// <summary>
        /// Enables Affliction Events
        /// </summary>
        public bool EnableAfflictionEvents()
        {
            Trace.WriteLine(String.Format("ISXEQ2:EnableAfflictionEvents()"));
            return this.ExecuteMethod("EnableAfflictionEvents");
        }

        /// <summary>
        /// Enables ISXEQ2's custom zoning text overlays. The toggle is persisted to
        /// the General settings section ("Custom Zoning Texts Enabled").
        /// </summary>
        /// <returns>call success</returns>
        public bool EnableCustomZoningText()
        {
            Trace.WriteLine(String.Format("ISXEQ2:EnableCustomZoningText()"));
            return this.ExecuteMethod("EnableCustomZoningText");
        }

        /// <summary>
        /// Used to enable or disable Enduring Breath
        /// </summary>
        /// <param name="benefits">Enable or Disable</param>
        public bool EnduringBreath(BenefitToggle benefits)
        {
            Trace.WriteLine(String.Format("ISXEQ2:EnduringBreath({0})", benefits.ToString()));
            return this.ExecuteMethod("EnduringBreath", benefits.ToString());
        }

        /// <summary>
        /// Switches the running ISXEQ2 install channel to the BETA build and triggers
        /// a re-patch / reload. Persisted to the main settings file.
        /// </summary>
        /// <returns>call success</returns>
        public bool InstallBeta()
        {
            Trace.WriteLine(String.Format("ISXEQ2:InstallBeta()"));
            return this.ExecuteMethod("InstallBeta");
        }

        /// <summary>
        /// Switches the running ISXEQ2 install channel to the LIVE build and triggers
        /// a re-patch / reload (only effective when currently on Test or Beta).
        /// Persisted to the main settings file.
        /// </summary>
        /// <returns>call success</returns>
        public bool InstallLive()
        {
            Trace.WriteLine(String.Format("ISXEQ2:InstallLive()"));
            return this.ExecuteMethod("InstallLive");
        }

        /// <summary>
        /// Switches the running ISXEQ2 install channel to the TEST build and triggers
        /// a re-patch / reload. Persisted to the main settings file.
        /// </summary>
        /// <returns>call success</returns>
        public bool InstallTest()
        {
            Trace.WriteLine(String.Format("ISXEQ2:InstallTest()"));
            return this.ExecuteMethod("InstallTest");
        }

        /// <summary>
        /// Used to Enable or Disable No Fog
        /// </summary>
        /// <param name="benefits">Enable or Disable</param>
        public bool NoFog(BenefitToggle benefits)
        {
            Trace.WriteLine(String.Format("ISXEQ2:NoFog({0})", benefits.ToString()));
            return this.ExecuteMethod("NoFog", benefits.ToString());
        }

        /// <summary>
        /// Creates an ISXEQ2 popup window (LGUI window). Title and Status are optional.
        /// </summary>
        /// <param name="args">Title and/or Status</param>
        public bool Popup(params string[] args)
        {
            Trace.WriteLine("ISXEQ2:Popup({0})", String.Join(" ", args));
            return this.ExecuteMethod("Popup", args);
        }

        /// <summary>
        /// Reloads the ISXEQ2 extension after the supplied delay (in seconds; default 10).
        /// </summary>
        /// <param name="delay">delay in seconds before reload</param>
        /// <returns>call success</returns>
        public bool Reload(int delay = 10)
        {
            Trace.WriteLine(String.Format("ISXEQ2:Reload({0})", delay.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("Reload", delay.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// This should be called in your script before doing any calls to the vendingcontainer datatype
        /// that would be occurring after any user manipulation of the system within the game.
        /// </summary>
        public bool ResetInternalVendingSystem()
        {
            Trace.WriteLine(String.Format("ISXEQ2:ResetInternalVendingSystem()"));
            return this.ExecuteMethod("ResetInternalVendingSystem");
        }

        /// <summary>
        /// Sets the range for Actor events
        /// </summary>
        /// <param name="range">range</param>
        public bool SetActorEventsRange(float range)
        {
            Trace.WriteLine(String.Format("ISXEQ2:SetActorEventsRange({0})", 
                range.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("SetActorEventsRange", range.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Sets the time interval used to check for Actor events
        /// </summary>
        /// <param name="time">time in ms</param>
        public bool SetActorEventsTimeInterval(float time)
        {
            Trace.WriteLine(String.Format("ISXEQ2:SetActorEventsTimeInterval({0})", 
                time.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("SetActorEventsTimeInterval", time.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Sets the time period used to check for Affliction events
        /// </summary>
        /// <param name="time">time in ms</param>
        public bool SetAfflictionEventsTimeInterval(int time)
        {
            Trace.WriteLine(String.Format("ISXEQ2:SetAfflictionEventsTimeInterval({0})",
                time.ToString(CultureInfo.InvariantCulture)));
            return ExecuteMethod("SetAfflictionEventsTimeInterval", time.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Stores an ISXEQ2 custom variable. Subsequent reads via GetCustomVariable
        /// will return the stored value. Existing variables of the same name are
        /// overwritten.
        /// </summary>
        /// <param name="name">variable name</param>
        /// <param name="value">variable value (string-form)</param>
        /// <returns>call success</returns>
        public bool SetCustomVariable(string name, string value)
        {
            Trace.WriteLine(String.Format("ISXEQ2:SetCustomVariable({0}, {1})", name, value));
            return this.ExecuteMethod("SetCustomVariable", name, value);
        }

        /// <summary>
        /// Toggles the "Enable Welcome Info Window" persisted setting. Accepts a
        /// boolean argument (any value triggers the toggle in the source impl;
        /// argc==1 is required).
        /// </summary>
        /// <param name="enable">argument value (toggle trigger; any value)</param>
        /// <returns>call success</returns>
        public bool ShowWelcomeInfoWindow(bool enable)
        {
            Trace.WriteLine(String.Format("ISXEQ2:ShowWelcomeInfoWindow({0})", enable));
            return this.ExecuteMethod("ShowWelcomeInfoWindow", enable ? "1" : "0");
        }

        /// <summary>
        /// Toggles the "Optional Auto Reloads Enabled" persisted setting. The source
        /// implementation body is currently commented out (always returns true) but
        /// the method remains registered; included for forward compatibility.
        /// </summary>
        /// <returns>call success</returns>
        public bool ToggleOptionalAutoReloads()
        {
            Trace.WriteLine(String.Format("ISXEQ2:ToggleOptionalAutoReloads()"));
            return this.ExecuteMethod("ToggleOptionalAutoReloads");
        }

        /// <summary>
        /// Unloads the ISXEQ2 extension (queued via 'timedcommand 1 ext -unload isxeq2').
        /// </summary>
        /// <returns>call success</returns>
        public bool Unload()
        {
            Trace.WriteLine(String.Format("ISXEQ2:Unload()"));
            return this.ExecuteMethod("Unload");
        }

        #endregion

        #region Enums

        /// <summary>
        /// Enum used as argument to toggle certain client based effects on or off
        /// </summary>
        public enum BenefitToggle
        {
            /// <summary>
            /// Enable
            /// </summary>
            Enable,
            /// <summary>
            /// Disable
            /// </summary>
            Disable
        }

        #endregion

    }
}
