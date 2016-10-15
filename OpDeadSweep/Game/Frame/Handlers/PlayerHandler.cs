using System;
using ODS.Core.Data.Entities;

namespace ODS.Core.Handlers
{
    public static class PlayerHandler
    {
        #region Fields
        private static Player _player;
        #endregion
        #region Constuctor
        public static void Initalize()
        {
            _player = new Player();
            ResourcesHandler.Initalize();
        }
        #endregion
        #region Logic
        public static Player GetPlayer()
        {
            return _player;
        }
        #endregion
    }
}

