using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.Recipe
{
    /// <summary>
    /// This DataType wraps the ISXEQ2 'crafting' datatype, which exposes the live
    /// state of the in-progress crafting reaction (Quality, Progress, Durability,
    /// the most recent reaction Message, and the icon IDs displayed for the
    /// current crafting event) plus a small key-value store ("crafting variables")
    /// that scripts can use to share state with each other safely.
    ///
    /// The underlying 'crafting' datatype registers short aliases (M / R / Q / P /
    /// PM / D / DM / MII / BDII) that fall through to the long-form members; this
    /// wrapper exposes the long-form names only.
    /// </summary>
    public class Crafting : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Crafting(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The icon ID currently displayed in the crafting reaction's backdrop slot
        /// </summary>
        public int BackdropIconID
        {
            get
            {
                Trace.WriteLine(String.Format("Crafting:BackdropIconID"));
                return this.GetIntFromLSO("BackdropIconID");
            }
        }

        /// <summary>
        /// The current durability of the in-progress recipe
        /// </summary>
        public int Durability
        {
            get
            {
                Trace.WriteLine(String.Format("Crafting:Durability"));
                return this.GetIntFromLSO("Durability");
            }
        }

        /// <summary>
        /// The per-tick durability modifier produced by the most recent reaction
        /// </summary>
        public int DurabilityMod
        {
            get
            {
                Trace.WriteLine(String.Format("Crafting:DurabilityMod"));
                return this.GetIntFromLSO("DurabilityMod");
            }
        }

        /// <summary>
        /// Reads a previously-stored crafting variable as a string. Returns the empty
        /// string when no variable with the given name has been stored.
        /// </summary>
        /// <param name="name">variable name</param>
        /// <returns>variable value as a string</returns>
        public string GV(string name)
        {
            Trace.WriteLine(String.Format("Crafting:GV({0})", name));
            return this.GetStringFromLSO("GV", name);
        }

        /// <summary>
        /// Reads a previously-stored crafting variable, parsed as the requested
        /// type. Valid 'type' values: "str", "int", "bool", "float". Returns the
        /// raw string form if no type is supplied (use the single-arg overload).
        /// </summary>
        /// <param name="name">variable name</param>
        /// <param name="type">"str" / "int" / "bool" / "float"</param>
        /// <returns>variable value as a string (caller parses if needed)</returns>
        public string GV(string name, string type)
        {
            Trace.WriteLine(String.Format("Crafting:GV({0},{1})", name, type));
            return this.GetStringFromLSO("GV", name, type);
        }

        /// <summary>
        /// The icon ID currently displayed in the crafting reaction's main slot
        /// </summary>
        public int MainIconID
        {
            get
            {
                Trace.WriteLine(String.Format("Crafting:MainIconID"));
                return this.GetIntFromLSO("MainIconID");
            }
        }

        /// <summary>
        /// The most recent crafting-reaction message text
        /// </summary>
        public string Message
        {
            get
            {
                Trace.WriteLine(String.Format("Crafting:Message"));
                return this.GetStringFromLSO("Message");
            }
        }

        /// <summary>
        /// The current progress on the in-progress recipe
        /// </summary>
        public int Progress
        {
            get
            {
                Trace.WriteLine(String.Format("Crafting:Progress"));
                return this.GetIntFromLSO("Progress");
            }
        }

        /// <summary>
        /// The per-tick progress modifier produced by the most recent reaction
        /// </summary>
        public int ProgressMod
        {
            get
            {
                Trace.WriteLine(String.Format("Crafting:ProgressMod"));
                return this.GetIntFromLSO("ProgressMod");
            }
        }

        /// <summary>
        /// The current quality of the in-progress recipe
        /// </summary>
        public int Quality
        {
            get
            {
                Trace.WriteLine(String.Format("Crafting:Quality"));
                return this.GetIntFromLSO("Quality");
            }
        }

        /// <summary>
        /// The result code of the most recent crafting reaction
        /// </summary>
        public int Result
        {
            get
            {
                Trace.WriteLine(String.Format("Crafting:Result"));
                return this.GetIntFromLSO("Result");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Clears all stored crafting variables and any associated keys produced by GK.
        /// </summary>
        /// <returns>call success</returns>
        public bool CA()
        {
            Trace.WriteLine(String.Format("Crafting:CA()"));
            return this.ExecuteMethod("CA");
        }

        /// <summary>
        /// Generates a key associated with the named crafting variable. The key is
        /// returned via an internally-managed index and is required by the next call
        /// to SV for the same variable name. A key is single-use: it is consumed by
        /// SV and a new GK call is required for each subsequent SV. Returns the
        /// generated key, or 0 on failure.
        /// </summary>
        /// <param name="name">variable name</param>
        /// <returns>generated key (0 on failure)</returns>
        public int GK(string name)
        {
            Trace.WriteLine(String.Format("Crafting:GK({0})", name));

            using (var index = LavishScript.Objects.NewObject("index:int"))
            {
                if (!this.ExecuteMethod("GK", name, index.LSReference))
                    return 0;

                using (var used = index.GetMember("Used"))
                {
                    if (LavishScriptObject.IsNullOrInvalid(used) || used.GetValue<int>() < 1)
                        return 0;
                }

                return index.GetIndex<int>("1");
            }
        }

        /// <summary>
        /// Stores or updates the named crafting variable. The 'key' must be the
        /// most recent value returned by GK for the same variable name; SV consumes
        /// the key and a fresh GK call is required for each subsequent SV.
        /// </summary>
        /// <param name="name">variable name</param>
        /// <param name="key">key produced by GK</param>
        /// <param name="value">new value (string-encoded)</param>
        /// <returns>call success</returns>
        public bool SV(string name, int key, string value)
        {
            Trace.WriteLine(String.Format("Crafting:SV({0},{1},{2})", name, key.ToString(CultureInfo.InvariantCulture), value));
            return this.ExecuteMethod("SV", name, key.ToString(CultureInfo.InvariantCulture), value);
        }

        #endregion

    }
}
