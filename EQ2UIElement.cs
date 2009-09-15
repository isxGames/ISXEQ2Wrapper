// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class EQ2UIElement : LavishScriptObject
    {
        public EQ2UIElement(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public string Type
        {
            get
            {
                return GetMember<string>("Type");
            }
        }

        public string Text
        {
            get
            {
                return GetMember<string>("Text");
            }
        }

        public string Label
        {
            get
            {
                return GetMember<string>("Text");
            }
        }

        public EQ2UIElement Parent
        {
            get
            {
                LavishScriptObject Obj = GetMember("Parent");
                return new EQ2UIElement(Obj);
            }
        }

        public bool IsChecked
        {
            get
            {
                return GetMember<bool>("IsChecked");
            }
        }

        public int NumChildren
        {
            get
            {
                return GetMember<int>("NumChildren");
            }
        }

        public bool IsEnabled
        {
            get
            {
                return GetMember<bool>("IsEnabled");
            }
        }

        public string ChildType(int Index)
        {
            return GetMember<string>("ChildType", Index.ToString());
        }

        public EQ2UIElement Child(string ElementType, int Index)
        {
            LavishScriptObject Obj = GetMember("ChildType", ElementType, Index.ToString());
            return new EQ2UIElement(Obj);
        }

        public EQ2UIElement GetDynamicData(string DataFQN)
        {
            LavishScriptObject Obj = GetMember("GetDynamicData", DataFQN);
            return new EQ2UIElement(Obj);
        }

        public string ShortLabel
        {
            get
            {
                return GetMember<string>("ShortLabel");
            }
        }

        public bool IsSet
        {
            get
            {
                return GetMember<bool>("IsSet");
            }
        }

        public Ability ToAbility
        {
            get
            {
                LavishScriptObject Obj = GetMember("ToAbility");
                return new Ability(Obj);
            }
        }

        public int RowHighlighted
        {
            get
            {
                return GetMember<int>("RowHighlighted");
            }
        }

        public float Pecent
        {
            get
            {
                return GetMember<float>("Percent");
            }
        }

        public void ClickButton()
        {
            ExecuteMethod("ClickButton");
        }

        public void RightClick()
        {
            ExecuteMethod("RightClick");
        }

        public void LeftClick()
        {
            ExecuteMethod("LeftClick");
        }

        public void DoubleLeftClick()
        {
            ExecuteMethod("DoubleLeftClick");
        }

        public void AddToTextBox(string Text)
        {
            ExecuteMethod("AddToTextBox", Text);
        }

        public void HighlightRow(int Row)
        {
            ExecuteMethod("HighlightRow", Row.ToString());
        }

    }
}
