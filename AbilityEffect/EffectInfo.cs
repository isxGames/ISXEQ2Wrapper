using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.AbilityEffect
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to detailed
    /// information about an effect (the 'examine' data). Reached via Effect.ToEffectInfo or
    /// ActorEffect.ToEffectInfo. Use IsEffectInfoAvailable on the parent to confirm the data
    /// has been loaded before reading members.
    /// </summary>
    public class EffectInfo : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EffectInfo(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of Description
        /// </summary>
        private string _description;

        /// <summary>
        /// Effect description
        /// </summary>
        public string Description
        {
            get
            {
                Trace.WriteLine(String.Format("EffectInfo:Description"));
                return _description ?? (_description = this.GetStringFromLSO("Description"));
            }
        }

        /// <summary>
        /// Returns the EffectString at the specified 1-based index.
        /// Valid range is 1..NumEffectStrings.
        /// </summary>
        /// <param name="index">1-based index</param>
        /// <returns>EffectString</returns>
        public EffectString EffectString(int index)
        {
            Trace.WriteLine(String.Format("EffectInfo:EffectString({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new EffectString(this.GetMember("EffectString", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Effect name
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("EffectInfo:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// Cache of NumEffectStrings
        /// </summary>
        private int? _numEffectStrings;

        /// <summary>
        /// The number of EffectString entries describing this effect
        /// </summary>
        public int NumEffectStrings
        {
            get
            {
                Trace.WriteLine(String.Format("EffectInfo:NumEffectStrings"));
                if(!_numEffectStrings.HasValue)
                    _numEffectStrings = this.GetIntFromLSO("NumEffectStrings");
                return _numEffectStrings.Value;
            }
        }

        /// <summary>
        /// Cache of Type
        /// </summary>
        private string _type;

        /// <summary>
        /// The effect type (e.g. spell category string)
        /// </summary>
        public string Type
        {
            get
            {
                Trace.WriteLine(String.Format("EffectInfo:Type"));
                return _type ?? (_type = this.GetStringFromLSO("Type"));
            }
        }

        /// <summary>
        /// Cache of UsesRemaining
        /// </summary>
        private int? _usesRemaining;

        /// <summary>
        /// Number of remaining uses, where applicable
        /// </summary>
        public int UsesRemaining
        {
            get
            {
                Trace.WriteLine(String.Format("EffectInfo:UsesRemaining"));
                if(!_usesRemaining.HasValue)
                    _usesRemaining = this.GetIntFromLSO("UsesRemaining");
                return _usesRemaining.Value;
            }
        }

        #endregion

    }
}
