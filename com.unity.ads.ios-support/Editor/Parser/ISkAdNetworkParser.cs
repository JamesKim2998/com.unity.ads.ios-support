using System.Collections.Generic;

namespace Unity.Advertisement.IosSupport.Editor
{
    internal interface ISkAdNetworkParser
    {
        string GetExtension();
        HashSet<string> ParseSource(ISkAdNetworkSource source);
    }
}
