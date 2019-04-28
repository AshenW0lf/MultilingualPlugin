using System;
using System.Globalization;

namespace Plugin.Multilingual.Abstractions
{
    /// <summary>
    /// Event arguments for Culture changes
    /// </summary>
    public class CultureChangeArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Culture that is being moved from
        /// </summary>
        public CultureInfo FromCulture { get; }
        
        /// <summary>
        /// Culture that is being moved to
        /// </summary>
        public CultureInfo ToCulture { get; }
        #endregion Properties

        #region Constructor
        public CultureChangeArgs(CultureInfo fromCulture, CultureInfo toCulture)
        {
            FromCulture = fromCulture;
            ToCulture = toCulture;
        }
        #endregion Constructor
    }
}
