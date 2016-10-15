using System;
namespace BloodLust.Engine.Binary
{
    public class RWItem
    {
        #region Fields
        #endregion
        #region Constuctor
        public RWItem()
        {
        }
        #endregion
        #region Logic
        /// <summary>
        /// Load the Data From the File
        /// </summary>
        /// <param name="lo">Lo.</param>
        public virtual void Load(BinaryLoader lo)
        {
        }
        /// <summary>
        /// Save the Data to the File
        /// </summary>
        /// <param name="sa">Sa.</param>
        public virtual void Save(BinarySaver sa)
        {
        }
        #endregion
    }
}

