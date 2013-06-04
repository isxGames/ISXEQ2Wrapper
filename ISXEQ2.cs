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

        public ISXEQ2(LavishScriptObject copy)
            : base(copy)
        {
        }

        public ISXEQ2()
            : base(LavishScript.Objects.GetObject("ISXEQ2"))
        {
        }

        #endregion

        #region ISXEQ2 Information

        /// <summary>
        /// The ISXEQ2 version
        /// </summary>
        public string Version
        {
            get
            {
                return this.GetStringFromLSO("Version");
            }
        }

        /// <summary>
        /// Returns TRUE when the authentication and patching routines are complete and ISXEQ2 is truly ready.FTN_40_eaos
        /// 
        /// </summary>
        public bool IsReady
        {
            get
            {
                return this.GetBoolFromLSO("IsReady");
            }
        }

        #endregion

        #region Eq2Location Members and Methods

        /// <summary>
        /// Returns the total amount of EQ2Locations in the current zone
        /// </summary>
        public int EQ2LocsCount
        {
            get
            {
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
                return this.GetIntFromLSO("EQ2LocsCount", "AllZones");
            }
        }

        /// <summary>
        /// Used to add an Eq2Location
        /// </summary>
        /// <param name="label">Eq2Location label</param>
        public void AddLoc(string label)
        {
            ExecuteMethod("AddLoc", label);
        }

        /// <summary>
        /// Used to add an Eq2Location
        /// </summary>
        /// <param name="label">Eq2location label</param>
        /// <param name="notes">Eq2Location notes</param>
        public void AddLoc(string label, string notes)
        {
            ExecuteMethod("AddLoc", label, notes);
        }

        #endregion

        #region Actor and Affliction Event Handling Settings

        /// <summary>
        /// 
        /// </summary>
        /// <param name="range"></param>
        public void SetActorEventsRange(float range)
        {
            ExecuteMethod("SetActorEventsRange",range.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Sets the time interval used to check for Actor events
        /// </summary>
        /// <param name="time">the desired time interval</param>
        public void SetActorEventsTimeInterval(float time)
        {
            ExecuteMethod("SetActorEventsTimeInterval", time.ToString(CultureInfo.InvariantCulture));
        }

         /// <summary>
        /// Enables Affliction Events
        /// </summary>
        public void EnableAfflictionEvents()
        {
            ExecuteMethod("EnableAfflictionEvents");
        }

        /// <summary>
        /// Disables Affliction Events
        /// </summary>
        public void DisableAfflictionEvents()
        {
            ExecuteMethod("DisableAfflictionEvents");
        }

        /// <summary>
        /// Sets the time period used to check for Affliction Events
        /// </summary>
        /// <param name="milliseconds">time in ms</param>
        public void SetAfflictionEventsTimeInterval(int milliseconds)
        {
            ExecuteMethod("SetAfflictionEventsTimeInterval", milliseconds.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Enables Actor Events
        /// </summary>
        public void EnableActorEvents()
        {
            ExecuteMethod("EnableActorEvents");
        }

        /// <summary>
        /// Disables Actor Events
        /// </summary>
        public void DisableActorEvents()
        {
            ExecuteMethod("DisableActorEvents");
        }

        /// <summary>
        /// 
        /// </summary>
        public bool InitializingActorEffects
        {
            get
            {
                return this.GetBoolFromLSO("InitializingActorEffects");
            }
        }

        /// <summary>
        /// Indicates whether or not Affliction Events are on or off
        /// </summary>
        public bool AfflictionEventsOn
        {
            get
            {
                return this.GetBoolFromLSO("AfflictionEventsOn");
            }
        }

        #endregion

        #region Client Based Benefits

        /// <summary>
        /// Enum used as argument to toggle certain client based effects on or off
        /// </summary>
        public enum BenefitToggle
        {
            Enable,
            Disable
        }

        /// <summary>
        /// Used to enable or disable Enduring Breath
        /// </summary>
        /// <param name="benefits">Enable or Disable</param>
        public void EnduringBreath(BenefitToggle benefits)
        {
            ExecuteMethod("EnduringBreath", benefits.ToString());
        }

        /// <summary>
        /// Used to enable or disable Safe Fall
        /// </summary>
        /// <param name="benefits">Enable or Disable</param>
        public void SafeFall(BenefitToggle benefits)
        {
            ExecuteMethod("EnduringBreath", benefits.ToString());
        }

        /// <summary>
        /// Used to Enable or Disable No Fog
        /// </summary>
        /// <param name="benefits">Enable or Disable</param>
        public void NoFog(BenefitToggle benefits)
        {
            ExecuteMethod("NoFog", benefits.ToString());
        }

        #endregion

        #region Miscellaneous

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
        /// This should be called in your script before doing any calls to the vendingcontainer datatype 
        /// that would be occurring after any user manipulation of the system within the game.
        /// </summary>
        public void ResetInternalVendingSystem()
        {
            ExecuteMethod("ResetInternalVendingSystem");
        }

        /// <summary>
        /// Creates an ISXEQ2 popup window (LGUI window). Title and Status are optional.
        /// </summary>
        /// <param name="args">Title and/or Status</param>
        public void Popup(params string[] args)
        {
            ExecuteMethod("Popup", args);
        }

        /// <summary>
        /// Clears the abilities cache which means it will be rebuilt automatically when abilities are next used
        /// </summary>
        public void ClearAbilitiesCache()
        {
            ExecuteMethod("ClearAbilitiesCache");
        }

        #endregion

    }
}
