using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Extensions;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to 
    /// containers/vending machines/actors that are held within the consignment system. 
    /// </summary>
    public class VendingContainer : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
         public VendingContainer(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Retrieves the consignment matching the supplied name
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>Consignment</returns>
            public Consignment Consignment(string name)
            {
                Trace.WriteLine(String.Format("VendingContainer:Consignment({0})", name));
                return new Consignment(this.GetMember("Consignment", name));
            }

        /// <summary>
        /// Retrieves the consignment at the specified index (1 to NumItems)
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>Consignment</returns>
            public Consignment Consignment(int index)
            {
                Trace.WriteLine(String.Format("VendingContainer:Consignment({0})", index.ToString(CultureInfo.InvariantCulture)));
                return new Consignment(this.GetMember("Consignment", index.ToString(CultureInfo.InvariantCulture)));
            }

        /// <summary>
            /// Current value in silver pieces on container
        /// </summary>
            public float CurrentCoin
            {
                get
                {
                    Trace.WriteLine(String.Format("VendingContainer:CurrentCoin"));
                    return this.GetFloatFromLSO("CurrentCoin");
                }
            }

        /// <summary>
            /// Possible values: "Qeynos" "Freeport" "Kelethin" "Haven" "Neriak" (or "Unknown" which should not be possible)
        /// </summary>
            public string Market
            {
                get
                {
                    Trace.WriteLine(String.Format("VendingContainer:Market"));
                    return this.GetStringFromLSO("Market");
                }
            }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Container Name
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("VendingContainer:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// Number of Consignments in container
        /// </summary>
        public int NumItems
        {
            get
            {
                Trace.WriteLine(String.Format("VendingContainer:NumItems"));
                return this.GetIntFromLSO("NumItems");
            }
        }

        /// <summary>
        /// Cache of SerialNumber
        /// </summary>
        private long? _serialNumber;

        /// <summary>
        /// Container Serial Number
        /// </summary>
        public long SerialNumber
        {
            get
            {
                Trace.WriteLine(String.Format("VendingContainer:SerialNumber"));
                if(!_serialNumber.HasValue)
                    _serialNumber = this.GetInt64FromLSO("SerialNumber");
                return _serialNumber.Value;
            }
        }

        /// <summary>
        /// Cache of TotalCapacity
        /// </summary>
        private int? _totalCapacity;

        /// <summary>
        /// Total Capacity of the container
        /// </summary>
        public int TotalCapacity
        {
            get
            {
                Trace.WriteLine(String.Format("VendingContainer:TotalCapacity"));
                if(!_totalCapacity.HasValue)
                    _totalCapacity = this.GetIntFromLSO("TotalCapacity");
                return _totalCapacity.Value;
            }
        }

        /// <summary>
        /// All time value in silver pieces
        /// </summary>
        public float TotalCoin
        {
            get
            {
                Trace.WriteLine(String.Format("VendingContainer:TotalCoin"));
                return this.GetFloatFromLSO("TotalCoin");
            }
        }

        /// <summary>
        /// Used Capacity (Free slots = Total - Used)
        /// </summary>
        public int UsedCapacity
        {
            get
            {
                Trace.WriteLine(String.Format("VendingContainer:UsedCapacity"));
                return this.GetIntFromLSO("UsedCapacity");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Selects this vending container
        /// </summary>
        /// <returns>call success</returns>
        public bool ChangeTo()
        {
            Trace.WriteLine(String.Format("VendingContainer:ChangeTo()"));
            return this.ExecuteMethod("ChangeTo");
        }

        /// <summary>
        /// Removes this vending container from the consignment system. 
        /// </summary>
        /// <returns>call success</returns>
        public bool Remove()
        {
            Trace.WriteLine(String.Format("VendingContainer:Remove()"));
            return this.ExecuteMethod("Remove");
        }

        /// <summary>
        /// Retrieves all of the money currently housed in that vendor.
        /// </summary>
        /// <returns>call success</returns>
        public bool TakeCoin()
        {
            Trace.WriteLine(String.Format("VendingContainer:TakeCoin()"));
            return this.ExecuteMethod("TakeCoin");
        }

        /// <summary>
        /// Retrieves the amount of coin specified (in silver pieces) from the vending container. 
        /// </summary>
        /// <param name="quantity">quantity</param>
        /// <returns>call success</returns>
        public bool TakeCoin(int quantity)
        {
            Trace.WriteLine(String.Format("VendingContainer:TakeCoin({0})", quantity.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("TakeCoin", quantity.ToString(CultureInfo.InvariantCulture));
        }

        #endregion

    }
}
