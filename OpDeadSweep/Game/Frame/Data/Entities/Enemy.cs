using System;
using BloodLust.Engine.Binary;

namespace ODS.Core.Data.Entities
{
    /// <summary>
    /// Used as the base class for all enemy type monsters
    /// </summary>
    public class Enemy:RWItem
    {
        #region Fields
        public bool IsBoss
        {
            get;
            set;
        }
        public string EntityName
        {
            get;
            set;
        }

        #endregion
        #region Constuctor
        public Enemy()
        {
        }
        #endregion
        #region Logic
        #endregion
        #region Binary
        #endregion
    }
}

