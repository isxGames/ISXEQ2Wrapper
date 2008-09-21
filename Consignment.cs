using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class Consignment : LavishScriptObject
    {
        public Consignment(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Consignment()
            : base(LavishScript.Objects.GetObject("Consignment"))
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public float Price
        {
            get
            {
                return GetMember<float>("Price");
            }
        }

        public int Quantity
        {
            get
            {
                return GetMember<int>("Quantity");
            }
        }

        public float BasePrice
        {
            get
            {
                return GetMember<float>("BasePrice");
            }
        }

        public string BasePriceString
        {
            get
            {
                return GetMember<string>("BasePriceString");
            }
        }

        public int LinkID
        {
            get
            {
                return GetMember<int>("LinkID");
            }
        }

        public string ToLink
        {
            get
            {
                return GetMember<string>("ToLink");
            }
        }

        public int Level
        {
            get
            {
                return GetMember<int>("Level");
            }
        }

        public bool IsListed
        {
            get
            {
                return GetMember<bool>("IsListed");
            }
        }

        public string Market
        {
            get
            {
                return GetMember<string>("Market");
            }
        }

        public float Value
        {
            get
            {
                return GetMember<float>("Value");
            }
        }

        public ulong SerialNumber
        {
            get
            {
                return GetMember<ulong>("SerialNumber");
            }
        }

        public bool Buy()
        {
            return ExecuteMethod("Buy");
        }

        public bool Buy(int BuyPrice)
        {
            return ExecuteMethod("Buy", BuyPrice.ToString());
        }

        public bool Examine()
        {
            return ExecuteMethod("Examine");
        }

        public bool SetPrice(float SetPrice)
        {
            return ExecuteMethod("SetPrice", SetPrice.ToString());
        }

        public bool List()
        {
            return ExecuteMethod("List");
        }

        public bool Unlist()
        {
            return ExecuteMethod("Unlist");
        }

        public bool Remove()
        {
            return ExecuteMethod("Remove");
        }

        public bool Remove(int Quantity)
        {
            return ExecuteMethod("Remove", Quantity.ToString());
        }
    }
}
