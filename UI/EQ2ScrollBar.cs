using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2scrollbar' datatype. EQ2ScrollBarType inherits from
    /// EQ2WidgetType (INHERITDIRECT(pEQ2WidgetType)) and registers AttachedControl,
    /// ThumbPosition, ThumbSize, CanScrollUp, CanScrollDown as members and ScrollUp,
    /// ScrollDown as methods. (The 'Test' member is #if MYCOPY-gated and excluded.)
    /// </summary>
    public class EQ2ScrollBar : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2ScrollBar(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The widget the scrollbar is attached to. Source (DT-Widgets.cpp:347-352)
        /// sets Dest.Type via pAttachedControl-&gt;GetLSType(), so the result may be
        /// any eq2widget derivative. The wrapper return type is the polymorphic
        /// EQ2BaseObject; callers downcast as needed.
        /// </summary>
        public EQ2BaseObject AttachedControl
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2ScrollBar:AttachedControl"));
                return new EQ2BaseObject(this.GetMember("AttachedControl"));
            }
        }

        /// <summary>
        /// Current thumb position in pixels along the scrollbar.
        /// Source: DT-Widgets.cpp:353-360.
        /// </summary>
        public int ThumbPosition
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2ScrollBar:ThumbPosition"));
                return this.GetIntFromLSO("ThumbPosition");
            }
        }

        /// <summary>
        /// Current thumb size in pixels. Source: DT-Widgets.cpp:361-368.
        /// </summary>
        public int ThumbSize
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2ScrollBar:ThumbSize"));
                return this.GetIntFromLSO("ThumbSize");
            }
        }

        /// <summary>
        /// True when the scrollbar can scroll up. Source: DT-Widgets.cpp:369-374.
        /// </summary>
        public bool CanScrollUp
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2ScrollBar:CanScrollUp"));
                return this.GetBoolFromLSO("CanScrollUp");
            }
        }

        /// <summary>
        /// True when the scrollbar can scroll down. Source: DT-Widgets.cpp:375-380.
        /// </summary>
        public bool CanScrollDown
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2ScrollBar:CanScrollDown"));
                return this.GetBoolFromLSO("CanScrollDown");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Scrolls the bar up by one tick. Source: DT-Widgets.cpp:419-423.
        /// </summary>
        /// <returns>call success</returns>
        public bool ScrollUp()
        {
            Trace.WriteLine(String.Format("EQ2ScrollBar:ScrollUp()"));
            return this.ExecuteMethod("ScrollUp");
        }

        /// <summary>
        /// Scrolls the bar down by one tick. Source: DT-Widgets.cpp:424-428.
        /// </summary>
        /// <returns>call success</returns>
        public bool ScrollDown()
        {
            Trace.WriteLine(String.Format("EQ2ScrollBar:ScrollDown()"));
            return this.ExecuteMethod("ScrollDown");
        }

        #endregion

    }
}
