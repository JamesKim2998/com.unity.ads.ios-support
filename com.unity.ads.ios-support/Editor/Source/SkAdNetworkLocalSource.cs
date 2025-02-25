using System.IO;

namespace Unity.Advertisement.IosSupport.Editor
{
    internal class SkAdNetworkLocalSource : ISkAdNetworkSource
    {
        public string Path { get; }

        public SkAdNetworkLocalSource(string path)
        {
            Path = path;
        }

        public Stream Open()
        {
            return new FileStream(Path, FileMode.Open);
        }
    }
}
