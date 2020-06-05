using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.AbilityEffect;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related 
    /// to UI Elements such as buttons, icons, checkboxes, UI Text, composites and others. 
    /// </summary>
    public class EQ2Widget : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2Widget(LavishScriptObject copy) : base(copy) { }

        /// <summary>
        /// Constructor - Constructs a EQ2Window object based on the LavishScript object EQ2Window
        /// </summary>
        public EQ2Widget() : base(LavishScript.Objects.GetObject("EQ2Widget")) { }

        #endregion

        #region Members

        /// <summary>
        /// If the result of a GetProperty call is a boolean value, then it will return "TRUE" or "FALSE".
        /// Otherwise, it will return a string unless an additional argument is provided as follows
        /// </summary>
        public string GetProperty(string name)
        {
            Trace.WriteLine(String.Format("EQ2UIElement:GetProperty({0})", name));
            return this.GetStringFromLSO("GetProperty", name);
        }

        /// <summary>
        /// Retrieves the specified Child. This data member only works for Composite UI element types.
        /// This data member uses two arguments. The first is the 'type' the element, which can be 
        /// either "Button", "Icon", "Text", "CheckBox", "Page", "DataSourceContainer", or "Composite". 
        /// The second argument is the index location of the child within the composite's children array.
        /// This number will be between 1 and NumChildren.  
        /// </summary>
        /// <param name="type">type</param>
        /// <param name="index">index</param>
        /// <returns>EQ2UIElement</returns>
        public EQ2Widget Child(ElementType type, int index)
        {
            Trace.WriteLine(String.Format("EQ2UIElement:Child({0}, {1})", type.ToString(), index.ToString(CultureInfo.InvariantCulture)));
            return new EQ2Widget(this.GetMember("ChildType", type.ToString(), index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Retrieves the ChildType at the specified index.
        /// This data member only works for Composite UI element types. 
        /// This data member uses one argument. This argument is a 
        /// number between 1 and NumChildren representing the location in the composite's children array. 
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>ElementType</returns>
        public ElementType ChildType(int index)
        {
            Trace.WriteLine(String.Format("EQ2UIElement:ChildType({0})", index.ToString(CultureInfo.InvariantCulture)));
            switch (this.GetStringFromLSO("ChildType", index.ToString(CultureInfo.InvariantCulture)))
            {
                case "Button":
                    return ElementType.Button;
                case "Icon":
                    return ElementType.Icon;
                case "Text":
                    return ElementType.Text;
                case "CheckBox":
                    return ElementType.CheckBox;
                case "Page":
                    return ElementType.Page;
                case "DataSourceContainer":
                    return ElementType.DataSourceContainer;
                case "Composite":
                    return ElementType.Composite;
                case "DynamicData":
                    return ElementType.DynamicData;
                case "TextBox":
                    return ElementType.TextBox;
                case "List":
                    return ElementType.List;
                case "VolumePage":
                    return ElementType.VolumePage;
                case "DataSource":
                    return ElementType.DataSource;
                default:
                    return ElementType.Unknown;
            }
        }

        /// <summary>
        /// Retrieves the dynamic data UI element at the specified path
        /// </summary>
        /// <param name="path">path</param>
        /// <returns>EQ2UIElement</returns>
        public EQ2Widget GetDynamicData(string path)
        {
            Trace.WriteLine(String.Format("EQ2UIElement:GetDynamicData({0})", path));
            return new EQ2Widget(this.GetMember("GetDynamicData", path));
        }

        /// <summary>
        /// Returns true if the element is checked. This data member only works for Checkbox and DynamicData UI element types.
        /// </summary>
        public bool IsChecked
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2UIElement:IsChecked"));
                return this.GetBoolFromLSO("IsChecked");
            }
        }

        /// <summary>
        /// This data member has only been tested to work with 'button' types thus far.
        /// </summary>
        public bool IsEnabled
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2UIElement:IsEnabled"));
                return this.GetBoolFromLSO("IsEnabled");
            }
        }

        /// <summary>
        /// This member is an exact replica of IsChecked. 
        /// This data member only works for Checkbox and DynamicData UI element types.
        /// </summary>
        public bool IsSet
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2UIElement:IsSet"));
                return this.GetBoolFromLSO("IsSet");
            }
        }

        /// <summary>
        /// Cache of Label
        /// </summary>
        private string _label;

        /// <summary>
        /// Label. This data member only works for Checkbox, Text, DynamicData, and Button UI element types.
        /// </summary>
        public string Label
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2UIElement:Label"));
                return _label ?? (_label = this.GetStringFromLSO("Text"));
            }
        }

        /// <summary>
        /// Number of children. This data member only works for Composite UI element types.
        /// </summary>
        public int NumChildren
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2UIElement:NumChildren"));
                return this.GetIntFromLSO("NumChildren");
            }
        }

        /// <summary>
        /// Parent
        /// </summary>
        public EQ2Widget Parent
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2UIElement:Parent"));
                return new EQ2Widget(this.GetMember("Parent"));
            }
        }

        /// <summary>
        /// ProgressBar completion. For ProgressBar types only.
        /// </summary>
        public float Percent
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2UIElement:Percent"));
                return this.GetFloatFromLSO("Percent");
            }
        }

        /// <summary>
        /// Highlighted list row. "List" types only.
        /// </summary>
        public int RowHighlighted
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2UIElement:RowHighlighted"));
                return this.GetIntFromLSO("RowHighlighted");
            }
        }

        /// <summary>
        /// Cache of ShortLabel
        /// </summary>
        private string _shortLabel;

        /// <summary>
        /// Short Label. This data member only works for DynamicData UI element types.
        /// </summary>
        public string ShortLabel
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2UIElement:ShortLabel"));
                return _shortLabel ?? (_shortLabel = this.GetStringFromLSO("ShortLabel"));
            }
        }

        /// <summary>
        /// Cache of Text
        /// </summary>
        private string _text;

        /// <summary>
        /// Text. This data member only works for Checkbox, Text, DynamicData, and Button UI element types.
        /// </summary>
        public string Text
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2UIElement:Text"));
                return _text ?? (_text = this.GetStringFromLSO("Text"));
            }
        }

        /// <summary>
        /// Returns the ability associated with the icon. For Icons only.
        /// </summary>
        public Ability ToAbility
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2UIElement:ToAbility"));
                return new Ability(this.GetMember("ToAbility"));
            }
        }

        /// <summary>
        /// Element Type
        /// </summary>
        public ElementType Type
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2UIElement:Type"));
                switch (this.GetStringFromLSO("Type"))
                {
                    case "Button":
                        return ElementType.Button;
                    case "Icon":
                        return ElementType.Icon;
                    case "Text":
                        return ElementType.Text;
                    case "CheckBox":
                        return ElementType.CheckBox;
                    case "Page":
                        return ElementType.Page;
                    case "DataSourceContainer":
                        return ElementType.DataSourceContainer;
                    case "Composite":
                        return ElementType.Composite;
                    case "DynamicData":
                        return ElementType.DynamicData;
                    case "TextBox":
                        return ElementType.TextBox;
                    case "List":
                        return ElementType.List;
                    case "VolumePage":
                        return ElementType.VolumePage;
                    case "DataSource":
                        return ElementType.DataSource;
                    default:
                        return ElementType.Unknown;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds text to textbox. This should work for pretty much any "text entry" box in the EQ2 UI.
        /// Only works for Textbox type eq2uielements.
        /// </summary>
        /// <param name="text">text</param>
        /// <returns>call success</returns>
        public bool SetProperty(string propertyName, string value)
        {
            Trace.WriteLine(String.Format("EQ2UIElement:SetProperty({0},{1})", propertyName, value));
            return this.ExecuteMethod("SetProperty", propertyName, value);
        }

        /// <summary>
        /// Clicks a button. Only works for Button type eq2uielements.
        /// </summary>
        /// <returns>call success</returns>
        public bool ClickButton()
        {
            Trace.WriteLine(String.Format("EQ2UIElement:ClickButton()"));
            return this.ExecuteMethod("ClickButton");
        }

        /// <summary>
        /// Performs a double left click of the eq2uielement.
        /// </summary>
        /// <returns>call success</returns>
        public bool DoubleLeftClick()
        {
            Trace.WriteLine(String.Format("EQ2UIElement:DoubleLeftClick()"));
            return this.ExecuteMethod("DoubleLeftClick");
        }

        /// <summary>
        /// Highlights the specified row in the list
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>call success</returns>
        public bool HighlightRow(int row)
        {
            Trace.WriteLine(String.Format("EQ2UIElement:HighlightRow({0})", row.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("HighlightRow", row.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// LeftClicks the eq2uielement
        /// </summary>
        /// <returns>call success</returns>
        public bool LeftClick()
        {
            Trace.WriteLine(String.Format("EQ2UIElement:LeftClick()"));
            return this.ExecuteMethod("LeftClick");
        }

        /// <summary>
        /// RightClicks the eq2uielement
        /// </summary>
        /// <returns></returns>
        public bool RightClick()
        {
            Trace.WriteLine(String.Format("EQ2UIElement:RightClick()"));
            return this.ExecuteMethod("RightClick");
        }

        #endregion

        #region Enums

        /// <summary>
        /// UI Element Types
        /// </summary>
        public enum ElementType
        {
            /// <summary>
            /// Element Type Button
            /// </summary>
            Button,
            /// <summary>
            /// Element Type Text
            /// </summary>
            Text,
            /// <summary>
            /// Element Type TextBox
            /// </summary>
            TextBox,
            /// <summary>
            /// Element Type CheckBox
            /// </summary>
            CheckBox,
            /// <summary>
            /// Element Type Page
            /// </summary>
            Page,
            /// <summary>
            /// Element Type Composite
            /// </summary>
            Composite,
            /// <summary>
            /// Element Type Icon
            /// </summary>
            Icon, 
            /// <summary>
            /// Element Type DataSourceContainer
            /// </summary>
            DataSourceContainer,
            /// <summary>
            /// Element Type DynamicData
            /// </summary>
            DynamicData,
            /// <summary>
            /// Element Type Volume Page
            /// </summary>
            VolumePage,
            /// <summary>
            /// Element Type DataSource
            /// </summary>
            DataSource,
            /// <summary>
            /// Element Type Lists
            /// </summary>
            List,
            /// <summary>
            /// Element Type Unknown
            /// </summary>
            Unknown
        }

        #endregion

    }
}
