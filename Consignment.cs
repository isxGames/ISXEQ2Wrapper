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

        public int Quantity
        {
            get
            {
                return GetMember<int>("Quantity");
            }
        }

        public int LinkID
        {
            get
            {
                return GetMember<int>("LinkID");
            }
        }

        public float Value
        {
            get
            {
                return GetMember<float>("Value");
            }
        }

        public float Price
        {
            get
            {
                return GetMember<float>("Price");
            }
        }

        public string PriceString
        {
            get
            {
                return GetMember<string>("PriceString");
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

        public string SkillType
        {
            get
            {
                return GetMember<string>("SkillType");
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

        public string ToLink(string LinkName)
        {
            return GetMember<string>("ToLink", LinkName);
        }

        public bool SetPrice(float SetPrice)
        {
            return ExecuteMethod("SetPrice", SetPrice.ToString());
        }

        public bool Unlist()
        {
            return ExecuteMethod("Unlist");
        }

        public bool List()
        {
            return ExecuteMethod("List");
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
