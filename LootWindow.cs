// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class LootWindow : LavishScriptObject
    {
        public LootWindow(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public int NumItems
        {
            get
            {
                return GetMember<int>("NumItems");
            }
        }

        public Item Item
        {
            get
            {
                LavishScriptObject Obj = GetMember("Item");
                return new Item(Obj);
            }
        }

        public EQ2UIPage ToEQ2UIPage
        {
            get
            {
                LavishScriptObject Obj = GetMember("ToEQ2UIPage");
                return new EQ2UIPage(Obj);
            }
        }

        public bool IsLotto
        {
            get
            {
                return GetMember<bool>("IsLotto");
            }
        }

        public string Type
        {
            get
            {
                return GetMember<string>("Type");
            }
        }

        public bool LootAll()
        {
            return ExecuteMethod("LootAll");
        }

        public bool RequestAll()
        {
            return ExecuteMethod("RequestAll");
        }

        public bool DeclineLotto()
        {
            return ExecuteMethod("DeclineLotto");
        }

        public bool LootItem()
        {
            return ExecuteMethod("LootItem");
        }

        public bool LootItem(int ID, bool LootNoTrade)
        {
            if (LootNoTrade)
                return ExecuteMethod("LootItem", ID.ToString());
            return ExecuteMethod("LootItem", ID.ToString(), "0");
        }

        public bool SelectNeed()
        {
            return ExecuteMethod("SelectNeed");
        }

        public bool SelectGreed()
        {
            return ExecuteMethod("SelectGreed");
        }

        public bool DeclineNBG()
        {
            return ExecuteMethod("DeclineNBG");
        }

    }
}
