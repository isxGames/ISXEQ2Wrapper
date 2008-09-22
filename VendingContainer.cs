using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class VendingContainer : LavishScriptObject
    {
         public VendingContainer(LavishScriptObject Obj)
            : base(Obj)
        {
        }
/*
        public VendingContainer()
            : base(LavishScript.Objects.GetObject("VendingContainer"))
        {
        }
*/
        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public int UsedCapacity
        {
            get
            {
                return GetMember<int>("UsedCapacity");
            }
        }

        public int TotalCapacity
        {
            get
            {
                return GetMember<int>("TotalCapacity");
            }
        }

        public float CurrentCoin
        {
            get
            {
                return GetMember<float>("CurrentCoin");
            }
        }

        public float TotalCoin
        {
            get
            {
                return GetMember<float>("TotalCoin");
            }
        }

        public Consignment Consignment(int Index)
        {
            LavishScriptObject Obj = GetMember("Consignment", Index.ToString());
            return new Consignment(Obj);
        }

        public Consignment Consignment(string Name)
        {
            LavishScriptObject Obj = GetMember("Consignment", Name);
            return new Consignment(Obj);
        }

        public int NumItems
        {
            get
            {
                return GetMember<int>("NumItems");
            }
        }

        public string Market
        {
            get
            {
                return GetMember<string>("Market");
            }
        }

        public long SerialNumber
        {
            get
            {
                return GetMember<long>("SerialNumber");
            }
        }

        public bool TakeCoin()
        {
            return ExecuteMethod("TakeCoin");
        }

        public bool TakeCoin(float CoinQuantity)
        {
            return ExecuteMethod("TakeCoin", CoinQuantity.ToString());
        }

        public bool Remove()
        {
            return ExecuteMethod("Remove");
        }

        public bool ChangeTo()
        {
            return ExecuteMethod("ChangeTo");
        }

    }
}
