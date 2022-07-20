using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IL2CPU.API.Attribs;

namespace Centauri.Assets
{
    public class Assets
    {
        [ManifestResourceStream(ResourceName = "Centauri.Assets.Font1.bf")]
        public readonly static byte[] Font1B;
        [ManifestResourceStream(ResourceName = "Centauri.Assets.bg.bmp")]
        public readonly static byte[] Background;
    }
}
