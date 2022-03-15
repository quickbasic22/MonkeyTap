using System;
using System.Collections.Generic;
using System.Text;

namespace MonkeyTap
{
    public interface IPlatformSoundPlayer
    {
        void PlaySound(int samplingRate, byte[] pcmData);
    }
}
