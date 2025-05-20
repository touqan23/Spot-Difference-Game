using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System;
using System.Collections.Generic;

namespace Spot_Difference_Game
{
    internal class SoundManager
    {
        private Dictionary<string, IWavePlayer> players = new Dictionary<string, IWavePlayer>();
        private Dictionary<string, AudioFileReader> readers = new Dictionary<string, AudioFileReader>();

        public void PlaySound(string filePath)
        {
            try
            {
                StopSound(filePath);

                var reader = new AudioFileReader(filePath);
                var player = new WaveOutEvent();

                player.Init(reader);
                player.Play();

                // Store for cleanup
                players[filePath] = player;
                readers[filePath] = reader;

                // Cleanup after playback
                player.PlaybackStopped += (s, a) =>
                {
                    player.Dispose();
                    reader.Dispose();
                    players.Remove(filePath);
                    readers.Remove(filePath);
                };
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error playing sound: " + ex.Message);
            }
        }

        public void StopSound(string filePath)
        {
            if (players.ContainsKey(filePath))
            {
                players[filePath].Stop();
                players[filePath].Dispose();
                readers[filePath].Dispose();
                players.Remove(filePath);
                readers.Remove(filePath);
            }
        }

        public void StopAll()
        {
            foreach (var player in players.Values)
                player.Stop();
            foreach (var reader in readers.Values)
                reader.Dispose();
            players.Clear();
            readers.Clear();
        }
    }
}

