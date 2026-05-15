using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2uipage' datatype. Inherits from EQ2Widget. Exposes
    /// NumChildren, ChildType, Child as members and SpewChildren as a method.
    /// </summary>
    public class EQ2UIPage : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2UIPage(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Number of direct children of the page.
        /// </summary>
        public new int NumChildren
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2UIPage:NumChildren"));
                return this.GetIntFromLSO("NumChildren");
            }
        }

        /// <summary>
        /// Returns the registered LavishScript datatype name of the child at the
        /// given 1-based index (1..NumChildren).
        /// </summary>
        /// <param name="index">1-based child index</param>
        /// <returns>type name string</returns>
        public new string ChildType(int index)
        {
            Trace.WriteLine(String.Format("EQ2UIPage:ChildType({0})", index.ToString(CultureInfo.InvariantCulture)));
            return this.GetStringFromLSO("ChildType", index.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Returns the child at the given 1-based index (1..NumChildren). The runtime
        /// types the returned value as the child's actual LS type; the wrapper return
        /// type is the polymorphic EQ2BaseObject so callers can downcast as needed.
        /// </summary>
        /// <param name="index">1-based child index</param>
        /// <returns>child object</returns>
        public EQ2BaseObject Child(int index)
        {
            Trace.WriteLine(String.Format("EQ2UIPage:Child({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new EQ2BaseObject(this.GetMember("Child", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns the first child whose name matches.
        /// </summary>
        /// <param name="name">child name</param>
        /// <returns>child object</returns>
        public EQ2BaseObject Child(string name)
        {
            Trace.WriteLine(String.Format("EQ2UIPage:Child({0})", name));
            return new EQ2BaseObject(this.GetMember("Child", name));
        }

        /// <summary>
        /// Returns the Nth instance of the named child (instance is 1-based). NOTE:
        /// the FIRST argument is the instance number and the SECOND is the name.
        /// </summary>
        /// <param name="instance">1-based instance number</param>
        /// <param name="name">child name</param>
        /// <returns>child object</returns>
        public EQ2BaseObject Child(int instance, string name)
        {
            Trace.WriteLine(String.Format("EQ2UIPage:Child({0},{1})", instance.ToString(CultureInfo.InvariantCulture), name));
            return new EQ2BaseObject(this.GetMember("Child", instance.ToString(CultureInfo.InvariantCulture), name));
        }

        #endregion

        #region Methods

        /// <summary>
        /// Spews the page's children to the ISXEQ2 console. Debug-only convenience.
        /// </summary>
        /// <returns>call success</returns>
        public bool SpewChildren()
        {
            Trace.WriteLine(String.Format("EQ2UIPage:SpewChildren()"));
            return this.ExecuteMethod("SpewChildren");
        }

        #endregion

    }
}
