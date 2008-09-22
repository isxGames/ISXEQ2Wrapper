using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class Vendor : LavishScriptObject
    {
         public Vendor(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public int NumItemsForSale
        {
            get
            {
                return GetMember<int>("NumItemsForSale");
            }
        }

        public float Commission
        {
            get
            {
                return GetMember<float>("Commission");
            }
        }

        public int CurrentSearchPage
        {
            get
            {
                return GetMember<int>("CurrentSearchPage");
            }
        }

        public int TotalSearchPages
        {
            get
            {
                return GetMember<int>("TotalSearchPages");
            }
        }

        public Merchandise Merchant(int Index)
        {
            LavishScriptObject Obj = GetMember("Merchant", Index.ToString());
            return new Merchandise(Obj);
        }

        public Merchandise Merchant(string Name)
        {
            LavishScriptObject Obj = GetMember("Merchant", Name);
            return new Merchandise(Obj);
        }

        public Consignment Broker(int Index)
        {
            LavishScriptObject Obj = GetMember("Broker", Index.ToString());
            return new Consignment(Obj);
        }

        public Consignment Broker(string Name)
        {
            LavishScriptObject Obj = GetMember("Broker", Name);
            return new Consignment(Obj);
        }

        public bool IsBroker
        {
            get
            {
                return GetMember<bool>("IsBroker");
            }
        }

        public bool IsMerchant
        {
            get
            {
                return GetMember<bool>("IsMerchant");
            }
        }

        public void GoToSearchPage(int Page)
        {
            ExecuteMethod("GoToSearchPage", Page.ToString());
        }

    }
}
