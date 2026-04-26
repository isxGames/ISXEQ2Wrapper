using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2text' datatype. Source EQ2TextType registers no members
    /// or methods of its own and inherits everything from EQ2WidgetType
    /// (INHERITDIRECT(pEQ2WidgetType)). All useful surface comes from EQ2Widget;
    /// this class exists as a precise return-type marker for accessors that source
    /// declares as pEQ2TextType (e.g. CurrentQuest's nine fields).
    /// </summary>
    public class EQ2Text : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2Text(LavishScriptObject copy) : base(copy) { }

        #endregion

    }
}
