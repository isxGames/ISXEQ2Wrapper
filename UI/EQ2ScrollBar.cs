using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2scrollbar' datatype. Inherits from EQ2Widget. Exposes
    /// AttachedControl, ThumbPosition, ThumbSize, CanScrollUp, CanScrollDown plus the
    /// ScrollUp / ScrollDown methods.
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
        /// The widget the scrollbar is attached to. The runtime types the returned
        /// value as the attached control's actual LS type, so the result may be any
        /// eq2widget derivative. The wrapper return type is the polymorphic
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
        /// Current thumb size in pixels.
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
        /// True when the scrollbar can scroll up.
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
        /// True when the scrollbar can scroll down.
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
        /// Scrolls the bar up by one tick.
        /// </summary>
        /// <returns>call success</returns>
        public bool ScrollUp()
        {
            Trace.WriteLine(String.Format("EQ2ScrollBar:ScrollUp()"));
            return this.ExecuteMethod("ScrollUp");
        }

        /// <summary>
        /// Scrolls the bar down by one tick.
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
