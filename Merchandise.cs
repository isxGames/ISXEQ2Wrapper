using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class Merchandise : LavishScriptObject
    {
        public Merchandise(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Merchandise()
            : base(LavishScript.Objects.GetObject("Merchandise"))
        {
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public int Level
        {
            get
            {
                return GetMember<int>("Level");
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

        public int StatusCost
        {
            get
            {
                return GetMember<int>("StatusCost");
            }
        }

        public int Quantity
        {
            get
            {
                return GetMember<int>("Quantity");
            }
        }

        public int MaxQuantity
        {
            get
            {
                return GetMember<int>("MaxQuantity");
            }
        }

        public bool IsForSale
        {
            get
            {
                return GetMember<bool>("IsForSale");
            }
        }

        public bool Buy()
        {
            return ExecuteMethod("Buy");
        }

        public bool Buy(int Quantity)
        {
            return ExecuteMethod("Buy", Quantity.ToString());
        }

        public bool Sell()
        {
            return ExecuteMethod("Sell");
        }

        public bool Sell(int Quantity)
        {
            return ExecuteMethod("Sell", Quantity.ToString());
        }

        public bool Examine()
        {
            return ExecuteMethod("Examine");
        }

        public bool SetPrice(float Platinum, float Gold, float Silver, float Copper)
        {
            return ExecuteMethod("SetPrice", Platinum.ToString(), Gold.ToString(), Silver.ToString(), Copper.ToString());
        }

        public bool ListForSale()
        {
            return ExecuteMethod("ListForSale");
        }

        public bool UnListForSale()
        {
            return ExecuteMethod("UnListForSale");
        }
    }
}
