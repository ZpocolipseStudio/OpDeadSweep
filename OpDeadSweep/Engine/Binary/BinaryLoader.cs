using System;
using System.IO;
using System.Collections.Generic;

namespace BloodLust.Engine.Binary
{
    /// <summary>
    /// Used for loading Data from the File
    /// </summary>
    public class BinaryLoader:IDisposable
    {
        #region Fields
        /// <summary>
        /// The base Binary Reader 
        /// </summary>
        private BinaryReader _re;
        #endregion
        #region Constuctor
        /// <summary>
        /// Initializes a new instance of the <see cref="BloodLust.Engine.Binary.BinaryLoader"/> class.
        /// </summary>
        /// <param name="path">Path.</param>
        public BinaryLoader(string path)
        {
            _re = new BinaryReader( File.OpenRead( path ) );
        }
        #endregion
        #region Logic
        /// <summary>
        /// Loads the byte.
        /// </summary>
        /// <returns>The byte.</returns>
        public byte LoadByte()
        {
            return _re.ReadByte();
        }
        /// <summary>
        /// Loads the bytes.
        /// </summary>
        /// <returns>The bytes.</returns>
        /// <param name="count">Count.</param>
        public byte[] LoadBytes(int count)
        {
            return _re.ReadBytes( count );
        }
        /// <summary>
        /// Loads the short.
        /// </summary>
        /// <returns>The short.</returns>
        public short LoadShort()
        {
            return _re.ReadInt16();
        }
        /// <summary>
        /// Loads the int.
        /// </summary>
        /// <returns>The int.</returns>
        public Int32 LoadInt()
        {
            return _re.ReadInt32();
        }
        /// <summary>
        /// Loads the long.
        /// </summary>
        /// <returns>The long.</returns>
        public long LoadLong()
        {
            return _re.ReadInt64();
        }
        /// <summary>
        /// Loads the bool.
        /// </summary>
        /// <returns><c>true</c>, if bool was loaded, <c>false</c> otherwise.</returns>
        public bool LoadBool()
        {
            return _re.ReadBoolean();
        }
        /// <summary>
        /// Loads the string.
        /// </summary>
        /// <returns>The string.</returns>
        public string LoadString()
        {
            return _re.ReadString();
        }
        /// <summary>
        /// Loads the string dictionary
        /// </summary>
        /// <returns>The string dict.</returns>
        public Dictionary<string,string> LoadStringDict()
        {
            int c = LoadInt();
            Dictionary<string,string> di = new Dictionary<string, string>();
            for( int x = 0; x < c; x++ )
            {
                string k = LoadString();
                string i = LoadString();
                di.Add( k, i );
            }
            return di;
        }
        /// <summary>
        /// Loads the string list.
        /// </summary>
        /// <returns>The string list.</returns>
        public List<string> LoadStringList()
        {
            int c = LoadInt();
            List<string> di = new List<string>();
            for( int x = 0; x < c; x++ )
            {
                string k = LoadString();
                di.Add( k );
            }
            return di;
        }
        #endregion
        #region Base
        /// <summary>
        /// Releases all resource used by the <see cref="BloodLust.Engine.Binary.BinaryLoader"/> object.
        /// </summary>
        /// <remarks>Call <see cref="Dispose"/> when you are finished using the
        /// <see cref="BloodLust.Engine.Binary.BinaryLoader"/>. The <see cref="Dispose"/> method leaves the
        /// <see cref="BloodLust.Engine.Binary.BinaryLoader"/> in an unusable state. After calling
        /// <see cref="Dispose"/>, you must release all references to the
        /// <see cref="BloodLust.Engine.Binary.BinaryLoader"/> so the garbage collector can reclaim the memory that the
        /// <see cref="BloodLust.Engine.Binary.BinaryLoader"/> was occupying.</remarks>
        public void Dispose()
        {
            _re.Dispose();
        }
        #endregion
    }
}

