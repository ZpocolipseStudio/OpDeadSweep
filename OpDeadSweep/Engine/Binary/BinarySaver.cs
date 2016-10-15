using System;
using System.IO;
using System.Collections.Generic;

namespace BloodLust.Engine.Binary
{
    /// <summary>
    /// Used to Save the Data to the file
    /// </summary>
    public class BinarySaver
    {
        #region Fields
        /// <summary>
        /// The base Writer 
        /// </summary>
        private BinaryWriter _wr;
        #endregion
        #region Constuctor
        /// <summary>
        /// Initializes a new instance of the <see cref="BloodLust.Engine.Binary.BinarySaver"/> class.
        /// </summary>
        /// <param name="path">Path.</param>
        public BinarySaver(string path)
        {
            _wr = new BinaryWriter( File.OpenWrite( path ) );
        }
        #endregion
        #region Logic
        /// <summary>
        /// Save the specified i.
        /// </summary>
        /// <param name="i">The index.</param>
        public void Save(int i)
        {
            _wr.Write( i );
        }
        /// <summary>
        /// Save the specified s.
        /// </summary>
        /// <param name="s">S.</param>
        public void Save(short s)
        {
            _wr.Write( s );
        }
        /// <summary>
        /// Save the specified l.
        /// </summary>
        /// <param name="l">L.</param>
        public void Save(long l)
        {
            _wr.Write( l );
        }
        /// <summary>
        /// Save the specified b.
        /// </summary>
        /// <param name="b">The blue component.</param>
        public void Save(byte b)
        {
            _wr.Write( b );
        }
        /// <summary>
        /// Save the specified b.
        /// </summary>
        /// <param name="b">The blue component.</param>
        public void Save(byte[] b)
        {
            _wr.Write( b );
        }
        /// <summary>
        /// Save the specified s.
        /// </summary>
        /// <param name="s">S.</param>
        public void Save(string s)
        {
            _wr.Write( s );
        }
        /// <summary>
        /// Save the specified b.
        /// </summary>
        /// <param name="b">If set to <c>true</c> b.</param>
        public void Save(bool b)
        {
            _wr.Write( b );
        }
        /// <summary>
        /// Save the specified d.
        /// </summary>
        /// <param name="d">D.</param>
        public void Save(Dictionary<string,string> d)
        {
            Save( d.Count );
            foreach( string x in d.Keys )
            {
                Save( x );
                Save( d[ x ] );
            }
        }
        /// <summary>
        /// Save the specified l.
        /// </summary>
        /// <param name="l">L.</param>
        public void Save(List<string> l)
        {
            Save( l.Count );
            l.ForEach( x => Save( x ) );
        }
        #endregion
        #region Base
        /// <summary>
        /// Releases all resource used by the <see cref="BloodLust.Engine.Binary.BinarySaver"/> object.
        /// </summary>
        /// <remarks>Call <see cref="Dispose"/> when you are finished using the
        /// <see cref="BloodLust.Engine.Binary.BinarySaver"/>. The <see cref="Dispose"/> method leaves the
        /// <see cref="BloodLust.Engine.Binary.BinarySaver"/> in an unusable state. After calling <see cref="Dispose"/>,
        /// you must release all references to the <see cref="BloodLust.Engine.Binary.BinarySaver"/> so the garbage
        /// collector can reclaim the memory that the <see cref="BloodLust.Engine.Binary.BinarySaver"/> was occupying.</remarks>
        public void Dispose()
        {
            _wr.Dispose();
        }
        #endregion
    }
}

