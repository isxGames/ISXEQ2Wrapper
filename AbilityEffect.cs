using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Extensions;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to ability effects. 
    /// This is used to get information about Effects on Abilities.
    /// </summary>
    public class AbilityEffect : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public AbilityEffect(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Cache of PercentSuccess
        /// </summary>
        private int? _percentSuccess;

        /// <summary>
        /// Success chance of effect
        /// </summary>
        public int PercentSuccess
        {
            get
            {
                Trace.WriteLine(String.Format("AbilityEffect:PercentSuccess"));
                if(!_percentSuccess.HasValue)
                    _percentSuccess = this.GetIntFromLSO("PercentSuccess");
                return _percentSuccess.Value;
            }
        }

        /// <summary>
        /// Cache of indentation
        /// </summary>
        private int? _indentation;

        /// <summary>
        /// Visually, what 'bulleted' layer is it in the listing 
        /// </summary>
        public int Indentation
        {
            get
            {
                Trace.WriteLine(String.Format("AbilityEffect:Indentation"));
                if(!_indentation.HasValue)
                    _indentation = this.GetIntFromLSO("Indentation");
                return _indentation.Value;
            }
        }

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
                Trace.WriteLine(String.Format("AbilityEffect:Description"));
                return _description ?? (_description = this.GetStringFromLSO("Description"));
            }
        }

        #endregion

    }
}
