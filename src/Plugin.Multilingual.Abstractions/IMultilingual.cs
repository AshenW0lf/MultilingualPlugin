using System;
using System.Globalization;

namespace Plugin.Multilingual.Abstractions
{
    /// <summary>
    /// Interface for Multilingual
    /// </summary>
    public interface IMultilingual
    {
        CultureInfo CurrentCultureInfo {get; set;}
        CultureInfo DeviceCultureInfo { get; }
        CultureInfo[] CultureInfoList { get; }
        CultureInfo[] NeutralCultureInfoList { get; }
        CultureInfo GetCultureInfo(string name);

        #region Culture Change Events
        event EventHandler<CultureChangeArgs> OnCultureChanged;
        #endregion Culture Change Events
    }
}
