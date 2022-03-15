﻿using Android.Media;
using System;

namespace MonkeyTap
{
    public class PlatformSoundPlayer : IPlatformSoundPlayer
    {
        AudioTrack previousAudioTrack;

        [Obsolete]
        public void PlaySound(int samplingRate, byte[] pcmData)
        {
            if (previousAudioTrack != null)
            {
                previousAudioTrack.Stop();
                previousAudioTrack.Release();
            }

            AudioTrack audioTrack = new AudioTrack(Stream.Music,
                                                   samplingRate,
                                                   ChannelOut.Mono,
                                                   Android.Media.Encoding.Pcm16bit,
                                                   pcmData.Length * sizeof(short),
                                                   AudioTrackMode.Static);

            audioTrack.Write(pcmData, 0, pcmData.Length);
            audioTrack.Play();
            previousAudioTrack = audioTrack;

        }
    }
}
