// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class ContainerWindow : LavishScriptObject
    {

        /// <summary>
        /// *** Notes: 
        /// *** 1.  A "ContainerWindow" is any window that says 'Container' on it's name tab.  As of right now, it refers most often to the
        /// ***     'Harvest Supply Depot'.
        /// *** 2.  You may only have one "ContainerWindow" open at a time.
        /// *** 3.  The "ContainerWindow" TLO and related datatypes are only available when the container window is OPEN.  (However, it does 
        /// ***     not matter how far away you are from said container.)
        /// </summary>
        public ContainerWindow()
            : base(LavishScript.Objects.GetObject("ContainerWindow"))
        {
        }

        public ContainerWindow(LavishScriptObject Copy)
            : base(Copy)
        {
        }

        public int NumItems
        {
            get
            {
                return GetMember<int>("NumItems");
            }
        }

        /// <summary>
        /// The 'Item' MEMBER accepts either an index between 1 and ${ContainerWindow.NumItems}
        /// </summary>
        /// <param name="index"></param>
        /// <returns>a ContainerWindowItem object</returns>
        public ContainerWindowItem Item(int index)
        {
            LavishScriptObject Obj = GetMember("Item", index.ToString());
            return new ContainerWindowItem(Obj);
        }

        public ContainerWindowItem Item(string Name)
        {
            LavishScriptObject Obj = GetMember("Item", Name.ToString());
            return new ContainerWindowItem(Obj);
        }


        /// <summary>
        /// Lavishscript Example: "ContainerWindow:RemoveItem[${ContainerWindow.Item[artichoke].ID},5]"
        /// </summary>
        /// <param name="containeritemID"></param>
        /// <param name="Quantity"></param>
        /// <returns>true or false</returns>
        public bool RemoveItem(int containeritemID, int Quantity)
        {
            return ExecuteMethod("RemoveItem",containeritemID.ToString(), Quantity.ToString());
        }
    }
}
