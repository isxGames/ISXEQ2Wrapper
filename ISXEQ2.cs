// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System.Globalization;
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
            get { return this.GetBoolFromLSO("AfflictionEventsOn"); }
        }

        /// <summary>
        /// Returns the total amount of EQ2Locations in the current zone
        /// </summary>
        public int EQ2LocsCount
        {
            get { return this.GetIntFromLSO("EQ2LocsCount"); }
        }

        /// <summary>
        /// Returns the total amount of EQ2Locations across all zones
        /// </summary>
        public int EQ2LocsCountAllZones
        {
            get { return this.GetIntFromLSO("EQ2LocsCount", "AllZones"); }
        }

        /// <summary>
        /// Indicates whether or not Actor Effects are initializing
        /// </summary>
        public bool InitializingActorEffects
        {
            get { return this.GetBoolFromLSO("InitializingActorEffects"); }
        }

        /// <summary>
        /// Returns TRUE when the authentication and patching routines are complete and ISXEQ2 is truly ready.
        /// </summary>
        public bool IsReady
        {
            get { return this.GetBoolFromLSO("IsReady"); }
        }

        /// <summary>
        /// Returns a boolean indicating whether or not a key board key is a valid eq2press key
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns>boolean indicating whether or not the key is valid</returns>
        public bool IsValidEQ2PressKey(string keyName)
        {
            return this.GetBoolFromLSO("IsValidEQ2PressKey", keyName);
        }

        /// <summary>
        /// The ISXEQ2 version
        /// </summary>
        public string Version
        {
            get { return this.GetStringFromLSO("Version"); }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Used to add an EQ2Location
        /// </summary>
        /// <param name="label">EQ2Location label</param>
        public bool AddLoc(string label)
        {
            return ExecuteMethod("AddLoc", label);
        }

        /// <summary>
        /// Used to add an EQ2Location
        /// </summary>
        /// <param name="label">EQ2location label</param>
        /// <param name="notes">EQ2Location notes</param>
        public bool AddLoc(string label, string notes)
        {
            return ExecuteMethod("AddLoc", label, notes);
        }

        /// <summary>
        /// Clears the abilities cache which means it will be rebuilt automatically when abilities are next used
        /// </summary>
        public bool ClearAbilitiesCache()
        {
            return ExecuteMethod("ClearAbilitiesCache");
        }

        /// <summary>
        /// Disables Actor Events
        /// </summary>
        public bool DisableActorEvents()
        {
            return ExecuteMethod("DisableActorEvents");
        }

        /// <summary>
        /// Disables Affliction Events
        /// </summary>
        public bool DisableAfflictionEvents()
        {
            return ExecuteMethod("DisableAfflictionEvents");
        }

        /// <summary>
        /// Enables Actor Events
        /// </summary>
        public bool EnableActorEvents()
        {
            return ExecuteMethod("EnableActorEvents");
        }

        /// <summary>
        /// Enables Affliction Events
        /// </summary>
        public bool EnableAfflictionEvents()
        {
            return ExecuteMethod("EnableAfflictionEvents");
        }

        /// <summary>
        /// Used to enable or disable Enduring Breath
        /// </summary>
        /// <param name="benefits">Enable or Disable</param>
        public bool EnduringBreath(BenefitToggle benefits)
        {
            return ExecuteMethod("EnduringBreath", benefits.ToString());
        }

        /// <summary>
        /// Used to Enable or Disable No Fog
        /// </summary>
        /// <param name="benefits">Enable or Disable</param>
        public bool NoFog(BenefitToggle benefits)
        {
            return ExecuteMethod("NoFog", benefits.ToString());
        }

        /// <summary>
        /// Creates an ISXEQ2 popup window (LGUI window). Title and Status are optional.
        /// </summary>
        /// <param name="args">Title and/or Status</param>
        public bool Popup(params string[] args)
        {
            return ExecuteMethod("Popup", args);
        }

        /// <summary>
        /// This should be called in your script before doing any calls to the vendingcontainer datatype 
        /// that would be occurring after any user manipulation of the system within the game.
        /// </summary>
        public bool ResetInternalVendingSystem()
        {
            return ExecuteMethod("ResetInternalVendingSystem");
        }

        /// <summary>
        /// Used to enable or disable Safe Fall
        /// </summary>
        /// <param name="benefits">Enable or Disable</param>
        public bool SafeFall(BenefitToggle benefits)
        {
            return ExecuteMethod("SafeFall", benefits.ToString());
        }

        /// <summary>
        /// Sets the range for Actor events
        /// </summary>
        /// <param name="range">range</param>
        public bool SetActorEventsRange(float range)
        {
            return ExecuteMethod("SetActorEventsRange", range.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Sets the time interval used to check for Actor events
        /// </summary>
        /// <param name="time">the desired time interval</param>
        public bool SetActorEventsTimeInterval(float time)
        {
            return ExecuteMethod("SetActorEventsTimeInterval", time.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Sets the time period used to check for Affliction Events
        /// </summary>
        /// <param name="milliseconds">time in ms</param>
        public bool SetAfflictionEventsTimeInterval(int milliseconds)
        {
            return ExecuteMethod("SetAfflictionEventsTimeInterval", milliseconds.ToString(CultureInfo.InvariantCulture));
        }

        #endregion

        #region Enums

        /// <summary>
        /// Enum used as argument to toggle certain client based effects on or off
        /// </summary>
        public enum BenefitToggle
        {
            Enable,
            Disable
        }

        #endregion
    }
}
