using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the source 'eq2baseobject' datatype. EQ2BaseObjectType is the root of
    /// the widget/UI type hierarchy in source: EQ2WidgetType inherits from it
    /// (INHERITDIRECT(pEQ2BaseObjectType)), and the data-side EQ2DataSourceContainerType
    /// and EQ2DynamicDataType inherit directly from it as well. Exposes the cross-cutting
    /// GetProperty / Type / Parent surface plus the SetProperty / GetProperties /
    /// SpewProperties methods that every widget and data object understands.
    /// </summary>
    public class EQ2BaseObject : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2BaseObject(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Reads a named property from the underlying object. Source GetProperty
        /// (DT-Widgets.cpp:36-92) returns a string by default; if the string equals
        /// "true" or "false" it is returned as a bool by the LS engine. Use the
        /// two-arg overload to coerce to int / float / int64 directly.
        /// </summary>
        /// <param name="name">property name</param>
        /// <returns>property value as string ("TRUE" / "FALSE" for bool-typed values)</returns>
        public string GetProperty(string name)
        {
            Trace.WriteLine(String.Format("EQ2BaseObject:GetProperty({0})", name));
            return this.GetStringFromLSO("GetProperty", name);
        }

        /// <summary>
        /// Reads a named property and coerces it to the requested numeric type.
        /// Valid type strings (per DT-Widgets.cpp:58-75): "int", "float", "int64".
        /// The wrapper returns the value as a string; the caller parses if needed.
        /// </summary>
        /// <param name="name">property name</param>
        /// <param name="type">"int" / "float" / "int64"</param>
        /// <returns>property value as string</returns>
        public string GetProperty(string name, string type)
        {
            Trace.WriteLine(String.Format("EQ2BaseObject:GetProperty({0},{1})", name, type));
            return this.GetStringFromLSO("GetProperty", name, type);
        }

        /// <summary>
        /// Returns the registered LavishScript datatype name of the underlying object,
        /// with the CRC string-hash prefix stripped. Source: DT-Widgets.cpp:93-98.
        /// </summary>
        public string Type
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2BaseObject:Type"));
                return this.GetStringFromLSO("Type");
            }
        }

        /// <summary>
        /// Returns the parent object. Source (DT-Widgets.cpp:99-107) sets
        /// Dest.Type to the parent's actual LS type via GetLSType(), so the parent
        /// may be any datatype that derives from eq2baseobject (eq2widget,
        /// eq2uipage, eq2window, etc.). The wrapper return type is the polymorphic
        /// base; callers downcast as needed.
        /// </summary>
        public EQ2BaseObject Parent
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2BaseObject:Parent"));
                return new EQ2BaseObject(this.GetMember("Parent"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Sets the named property to the supplied string value.
        /// Source: DT-Widgets.cpp:127-137.
        /// </summary>
        /// <param name="name">property name</param>
        /// <param name="value">value to set</param>
        /// <returns>call success</returns>
        public bool SetProperty(string name, string value)
        {
            Trace.WriteLine(String.Format("EQ2BaseObject:SetProperty({0},{1})", name, value));
            return this.ExecuteMethod("SetProperty", name, value);
        }

        /// <summary>
        /// Populates the LavishScript map variable identified by 'mapVarName' with
        /// every (property name -&gt; property value) pair on the underlying object.
        /// Source (DT-Widgets.cpp:138-167) requires the caller to pre-declare a
        /// 'collection:string,string' (a.k.a. map[string,string]) LS variable and
        /// pass its name; the method clears and refills it. This wrapper exposes
        /// the LS-native signature so scripts that already manage an LS-side map
        /// can use it directly. For .NET-side materialization, iterate the LS map
        /// after the call returns.
        /// </summary>
        /// <param name="mapVarName">name of a pre-declared LS collection:string,string variable</param>
        /// <returns>call success</returns>
        public bool GetProperties(string mapVarName)
        {
            Trace.WriteLine(String.Format("EQ2BaseObject:GetProperties({0})", mapVarName));
            return this.ExecuteMethod("GetProperties", mapVarName);
        }

        /// <summary>
        /// Spews every property on the underlying object to the ISXEQ2 console.
        /// Debug-only convenience method. Source: DT-Widgets.cpp:168-171.
        /// </summary>
        /// <returns>call success</returns>
        public bool SpewProperties()
        {
            Trace.WriteLine(String.Format("EQ2BaseObject:SpewProperties()"));
            return this.ExecuteMethod("SpewProperties");
        }

        #endregion

    }
}
