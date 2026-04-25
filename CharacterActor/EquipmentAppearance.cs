using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.CharacterActor
{
    /// <summary>
    /// Represents the appearance of a single equipped item (or mount), exposed via Actor.EquipmentAppearance[#] and Actor.MountAppearance.
    /// </summary>
    public class EquipmentAppearance : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EquipmentAppearance(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// EquipmentAppearance ID
        /// </summary>
        public uint ID
        {
            get
            {
                Trace.WriteLine(String.Format("EquipmentAppearance:ID"));
                return this.GetUIntFromLSO("ID");
            }
        }

        /// <summary>
        /// Texture 1 name
        /// </summary>
        public string Texture1
        {
            get
            {
                Trace.WriteLine(String.Format("EquipmentAppearance:Texture1"));
                return this.GetStringFromLSO("Texture1");
            }
        }

        /// <summary>
        /// Texture 2 name
        /// </summary>
        public string Texture2
        {
            get
            {
                Trace.WriteLine(String.Format("EquipmentAppearance:Texture2"));
                return this.GetStringFromLSO("Texture2");
            }
        }

        /// <summary>
        /// Texture 3 name
        /// </summary>
        public string Texture3
        {
            get
            {
                Trace.WriteLine(String.Format("EquipmentAppearance:Texture3"));
                return this.GetStringFromLSO("Texture3");
            }
        }

        #endregion

    }
}
