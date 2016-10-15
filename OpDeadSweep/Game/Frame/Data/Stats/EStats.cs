using System;
using BloodLust.Engine.Binary;

namespace ODS.Core.Data.Stats
{
    public class EStats:RWItem
    {
        #region Fields
        public int Attack;
        public int Armor;
        public int Flak;
        public byte WalkSpeed;
        public byte AttackRange;
        #endregion
        #region Constuctor
        public EStats()
        {
        }
        #endregion
        #region Logic
        #endregion
        #region Binary
        //TODO: Finish
        public override void Load(BinaryLoader lo)
        {
            base.Load(lo);
            Attack = lo.LoadInt();
            Armor = lo.LoadInt();
            Flak = lo.LoadInt();
            WalkSpeed = lo.LoadByte();
            AttackRange = lo.LoadByte();
        }
        public override void Save(BinarySaver sa)
        {
            base.Save(sa);
        }
        #endregion
    }
}

