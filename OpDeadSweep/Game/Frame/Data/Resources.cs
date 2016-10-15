using System;
using BloodLust.Engine.Binary;

namespace ODS.Core.Data
{
    /// <summary>
    /// Holds the games main resources
    /// </summary>
    public class Resources:RWItem
    {
        #region Fields

        public int Metal = 0;
        public int Powder = 0;
        public int Power = 0;

        #endregion

        #region Constructor

        public Resources()
        {
        }

        #endregion

        #region Logic

        #endregion

        #region Binary

        /// <summary>
        /// Load the Data From the File
        /// </summary>
        /// <param name="lo">Lo.</param>
        public override void Load(BinaryLoader lo)
        {
            base.Load( lo );
            byte v = lo.LoadByte();
            if( v >= 1 )
            {
                Metal = lo.LoadInt();
                Powder = lo.LoadInt();
                Power = lo.LoadInt();
            }
        }
        /// <summary>
        /// Save the Data to the File
        /// </summary>
        /// <param name="sa">Sa.</param>
        public override void Save(BinarySaver sa)
        {
            base.Save( sa );
            sa.Save( (byte)1 );
            sa.Save( Metal );
            sa.Save( Powder );
            sa.Save( Power );
        }

        #endregion
    }
}

