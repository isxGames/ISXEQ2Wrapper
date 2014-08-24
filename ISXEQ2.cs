using System;
using System.Globalization;
using System.Diagnostics;
using System.Linq;
using EQ2.ISXEQ2.Extensions;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
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
        /// Returns the total amount of EQ2Locations in the current zone
        /// </summary>
        public int EQ2LocsCount
        {
            get
            {
                Trace.WriteLine(String.Format("ISXEQ2:EQ2LocsCount"));
                return this.GetIntFromLSO("EQ2LocsCount");
            }
        }

        /// <summary>
        /// Returns the total amount of EQ2Locations across all zones
        /// </summary>
        public int EQ2LocsCountAllZones
        {
            get
            {
                Trace.WriteLine(String.Format("ISXEQ2:EQ2LocsCount"));
                return this.GetIntFromLSO("EQ2LocsCount", "AllZones");
            }
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
        /// Used to enable or disable Enduring Breath
        /// </summary>
        /// <param name="benefits">Enable or Disable</param>
        public bool EnduringBreath(BenefitToggle benefits)
        {
            Trace.WriteLine(String.Format("ISXEQ2:EnduringBreath({0})", benefits.ToString()));
            return this.ExecuteMethod("EnduringBreath", benefits.ToString());
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
