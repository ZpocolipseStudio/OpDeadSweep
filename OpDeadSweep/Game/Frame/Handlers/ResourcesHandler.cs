using System;
using ODS.Core.Data;

//TASK: Update when resources are added to the game

namespace ODS.Core.Handlers
{
    /// <summary>
    /// Used to handle all the managing of the resources
    /// </summary>
    public class ResourcesHandler
    {
        #region Fields
        /// <summary>
        /// The res.
        /// </summary>
        private static Resources _res; 
        #endregion
        #region Constuctor
        public static void Initalize()
        {
            _res = PlayerHandler.GetPlayer().Resources;
        }
        #endregion
        #region Logic
        public bool HasEnough(Resources res)
        {
            if( _res.Metal >= res.Metal && _res.Powder >= res.Powder && _res.Power >= res.Power )
                return true;
            else
                return false;
        }
        public static void Use(Resources res)
        {
            _res.Metal -= res.Metal;
            _res.Powder -= res.Powder;
            _res.Power -= res.Power;
        }
        public static void Add(Resources res)
        {
            _res.Metal += res.Metal;
            _res.Powder += res.Powder;
            _res.Power += res.Power;
        }
        #endregion
    }
}

