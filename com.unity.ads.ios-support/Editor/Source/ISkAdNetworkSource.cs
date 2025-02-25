using System.IO;

namespace Unity.Advertisement.IosSupport.Editor
{
    internal interface ISkAdNetworkSource
    {
        string Path { get; }
        Stream Open();
    }
}
