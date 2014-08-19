using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.Extensions;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType includes all of the data available to ISXEQ2 that is related to tradeskill recipes.
    /// </summary>
    public class Recipe : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Recipe(LavishScriptObject copy) : base(copy) { }

        #endregion
        
        #region Members

        /// <summary>
        /// A recipe component
        /// </summary>
        public Component BuildComponent1
        {
            get
            {
                Trace.WriteLine(String.Format("Recipe:BuildComponent1"));
                return new Component(this.GetMember("BuildComponent1"));
            }
        }

        /// <summary>
        /// A recipe component
        /// </summary>
        public Component BuildComponent2
        {
            get
            {
                Trace.WriteLine(String.Format("Recipe:BuildComponent2"));
                return new Component(this.GetMember("BuildComponent2"));
            }
        }

        /// <summary>
        /// A recipe component
        /// </summary>
        public Component BuildComponent3
        {
            get
            {
                Trace.WriteLine(String.Format("Recipe:BuildComponent3"));
                return new Component(this.GetMember("BuildComponent3"));
            }
        }

        /// <summary>
        /// A recipe component
        /// </summary>
        public Component BuildComponent4
        {
            get
            {
                Trace.WriteLine(String.Format("Recipe:BuildComponent4"));
                return new Component(this.GetMember("BuildComponent4"));
            }
        }

        /// <summary>
        /// Returns the class at the specified index
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>Class</returns>
        public Class Class(int index)
        {
            Trace.WriteLine(String.Format("Recipe:Class({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new Class(this.GetMember("Class", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Cache of description
        /// </summary>
        private string _description;

        /// <summary>
        /// Recipe Description
        /// </summary>
        public string Description
        {
            get
            {
                Trace.WriteLine(String.Format("Recipe:Description"));
                return _description ?? (_description = this.GetStringFromLSO("Description"));
            }
        }

        /// <summary>
        /// Cache of Device
        /// </summary>
        private string _device;

        /// <summary>
        /// Tradeskill device to craft
        /// </summary>
        public string Device
        {
            get
            {
                Trace.WriteLine(String.Format("Recipe:Device"));
                return _device ?? (_device = this.GetStringFromLSO("Device"));
            }
        }

        /// <summary>
        /// Fuel Component
        /// </summary>
        public Component Fuel
        {
            get
            {
                Trace.WriteLine(String.Format("Recipe:Fuel"));
                return new Component(this.GetMember("Fuel"));
            }
        }

        /// <summary>
        /// Cache of ID
        /// </summary>
        private uint? _iD;

        /// <summary>
        /// Recipe ID
        /// </summary>
        public uint ID
        {
            get
            {
                Trace.WriteLine(String.Format("Recipe:ID"));
                if (!_iD.HasValue)
                    _iD = this.GetUIntFromLSO("ID");
                return _iD.Value;
            }
        }

        /// <summary>
        /// Cache of Knowledge
        /// </summary>
        private string _knowledge;

        /// <summary>
        /// Recipe knowledge
        /// </summary>
        public string Knowledge
        {
            get
            {
                Trace.WriteLine(String.Format("Recipe:Knowledge"));
                return _knowledge ?? (_knowledge = this.GetStringFromLSO("Knowledge"));
            }
        }

        /// <summary>
        /// Cache of level
        /// </summary>
        private int? _level;

        /// <summary>
        /// Recipe level
        /// </summary>
        public int Level
        {
            get
            {
                Trace.WriteLine(String.Format("Recipe:Level"));
                if(!_level.HasValue)
                    _level = this.GetIntFromLSO("Level");
                return _level.Value;
            }
        }

        /// <summary>
        /// Cache of Name
        /// </summary>
        private string _name;

        /// <summary>
        /// Recipe name
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("Recipe:Name"));
                return _name ?? (_name = this.GetStringFromLSO("Name"));
            }
        }

        /// <summary>
        /// Cache of NumClasses
        /// </summary>
        private int? _numClasses;

        /// <summary>
        /// The number of classes that can use (used in Class(int index))
        /// </summary>
        public int NumClasses
        {
            get
            {
                Trace.WriteLine(String.Format("Recipe:NumClasses"));
                if(!_numClasses.HasValue)
                    _numClasses = this.GetIntFromLSO("NumClasses");
                return _numClasses.Value;
            }
        }

        /// <summary>
        /// Cache of PrimaryComponent
        /// </summary>
        private string _primaryComponent;

        /// <summary>
        /// The name of the primary component of the recipe
        /// </summary>
        public string PrimaryComponent
        {
            get
            {
                Trace.WriteLine(String.Format("Recipe:PrimaryComponent"));
                return _primaryComponent ?? (_primaryComponent = this.GetStringFromLSO("PrimaryComponent"));
            }
        }

        /// <summary>
        /// Then quantity of primary component on hand
        /// </summary>
        public int PrimaryComponentQuantityOnHand
        {
            get
            {
                Trace.WriteLine(String.Format("Recipe:PrimaryComponentOnHand"));
                return this.GetIntFromLSO("PrimaryComponentQuantityOnHand");
            }
        }

        /// <summary>
        /// Cache of RecipeBook
        /// </summary>
        private string _recipeBook;

        /// <summary>
        /// The name of the recipe book for the recipe
        /// </summary>
        public string RecipeBook
        {
            get
            {
                Trace.WriteLine(String.Format("Recipe:RecipeBook"));
                return _recipeBook ?? (_recipeBook = this.GetStringFromLSO("RecipeBook"));
            }
        }

        /// <summary>
        /// Cache of Technique
        /// </summary>
        private string _technique;

        /// <summary>
        /// Tradeskill technique needed
        /// </summary>
        public string Technique
        {
            get
            {
                Trace.WriteLine(String.Format("Recipe:Technique"));
                return _technique ?? (_technique = this.GetStringFromLSO("Technique"));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Begins creation of the recipe
        /// </summary>
        /// <returns>call success</returns>
        public bool Create()
        {
            Trace.WriteLine(String.Format("Recipe:Create()"));
            return this.ExecuteMethod("Create");
        }

        /// <summary>
        /// Examines the recipe
        /// </summary>
        /// <returns>call success</returns>
        public bool Examine()
        {
            Trace.WriteLine(String.Format("Recipe:Examine()"));
            return this.ExecuteMethod("Examine");
        }

        #endregion
        
    }
}
