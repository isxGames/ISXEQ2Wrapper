using System;
using System.Diagnostics;
using EQ2.ISXEQ2.Helpers;
using EQ2.ISXEQ2.InventoryConsignment;
using EQ2.ISXEQ2.Recipe;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.UI
{
    /// <summary>
    /// Wraps the ISXEQ2 'eq2icon' datatype. Inherits from EQ2Widget. Exposes IconID,
    /// ID (renamed from NodeID), IsReady, PercentUndimmed, IsItem,
    /// IsItemInfoAvailable, ToItemInfo, IsRecipe, IsRecipeInfoAvailable,
    /// ToRecipeInfo, and IsAbility. NodeID continues to work as a deprecated alias
    /// for ID and emits a deprecation warning when used.
    /// </summary>
    public class EQ2Icon : EQ2Widget
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2Icon(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// The icon's IconID.
        /// </summary>
        public int IconID
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Icon:IconID"));
                return this.GetIntFromLSO("IconID");
            }
        }

        /// <summary>
        /// The icon's ID (formerly NodeID).
        /// </summary>
        public uint ID
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Icon:ID"));
                return this.GetUIntFromLSO("ID");
            }
        }

        /// <summary>
        /// The icon's NodeID (uint). Renamed to ID; the alias still works but emits a
        /// deprecation warning when used. Prefer ID.
        /// </summary>
        [Obsolete("Renamed to ID. NodeID still works but emits a deprecation warning at runtime.")]
        public uint NodeID
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Icon:NodeID"));
                return this.GetUIntFromLSO("NodeID");
            }
        }

        /// <summary>
        /// True when the icon is "ready" (PercentUndimmed greater than 0).
        /// </summary>
        public bool IsReady
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Icon:IsReady"));
                return this.GetBoolFromLSO("IsReady");
            }
        }

        /// <summary>
        /// The fraction of the icon that is currently un-dimmed (0.0 - 1.0).
        /// </summary>
        public float PercentUndimmed
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Icon:PercentUndimmed"));
                return this.GetFloatFromLSO("PercentUndimmed");
            }
        }

        /// <summary>
        /// Returns TRUE if the icon represents an item.
        /// </summary>
        public bool IsItem
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Icon:IsItem"));
                return this.GetBoolFromLSO("IsItem");
            }
        }

        /// <summary>
        /// Returns TRUE if iteminfo data is available for this icon's item. Returns NULL
        /// if the icon is not an item.
        /// </summary>
        public bool IsItemInfoAvailable
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Icon:IsItemInfoAvailable"));
                return this.GetBoolFromLSO("IsItemInfoAvailable");
            }
        }

        /// <summary>
        /// Returns the iteminfo for the item this icon represents. Returns NULL if the
        /// icon is not an item or the iteminfo is not valid.
        /// </summary>
        public ItemInfo ToItemInfo
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Icon:ToItemInfo"));
                return new ItemInfo(this.GetMember("ToItemInfo"));
            }
        }

        /// <summary>
        /// Returns TRUE if the icon represents an ability.
        /// </summary>
        public bool IsAbility
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Icon:IsAbility"));
                return this.GetBoolFromLSO("IsAbility");
            }
        }

        /// <summary>
        /// Returns TRUE if the icon represents a recipe.
        /// </summary>
        public bool IsRecipe
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Icon:IsRecipe"));
                return this.GetBoolFromLSO("IsRecipe");
            }
        }

        /// <summary>
        /// Returns TRUE if recipeinfo data is available for this icon's recipe. Returns
        /// NULL if the icon is not a recipe.
        /// </summary>
        public bool IsRecipeInfoAvailable
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Icon:IsRecipeInfoAvailable"));
                return this.GetBoolFromLSO("IsRecipeInfoAvailable");
            }
        }

        /// <summary>
        /// Returns the recipeinfo for the recipe this icon represents. Returns NULL if
        /// the icon is not a recipe or the recipeinfo is not valid. The wrapper's
        /// Recipe class doubles as both 'recipe' and 'recipeinfo'.
        /// </summary>
        public Recipe.Recipe ToRecipeInfo
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2Icon:ToRecipeInfo"));
                return new Recipe.Recipe(this.GetMember("ToRecipeInfo"));
            }
        }

        #endregion

    }
}
