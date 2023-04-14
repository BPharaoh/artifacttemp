using UnityEngine;

namespace Project
{
	/// <summary>
	/// Plays a sound from an audio source.
	/// </summary>
	public class playSound : MonoBehaviour
	{
        [Tooltip("The sound to play")]
        public AudioClip sound;

        [Tooltip("The tag of the sound source")]
        public string soundSourceTag = "Sound";

        [Tooltip("Play the sound immediately when the object is activated")]
        public bool playOnStart = true;
   
		void Start()
		{
			if( playOnStart == true )    PlaySound(sound);
		}
	
        /// <summary>
		/// Plays the sound
		/// </summary>
		public void PlaySound(AudioClip sound)
        {
            // If there is a sound source tag and audio to play, play the sound from the audio source based on its tag
            if (soundSourceTag != string.Empty && sound)
            {
                // Play the sound
                GameObject.FindGameObjectWithTag(soundSourceTag).GetComponent<AudioSource>().PlayOneShot(sound);
            }
        }

        /// <summary>
		/// Plays the sound
		/// </summary>
		public void PlaySoundCurrent()
        {
            // If there is a sound source tag and audio to play, play the sound from the audio source based on its tag
            if (soundSourceTag != string.Empty && sound)
            {
                // Play the sound
                GameObject.FindGameObjectWithTag(soundSourceTag).GetComponent<AudioSource>().PlayOneShot(sound);
            }
        }
    }
}