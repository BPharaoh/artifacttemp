using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Project
{

	public class sound : MonoBehaviour
	{
		//The tag of the sound object
		public string soundObjectTag = "Sound";
		
		// The source of the sound
		public Transform soundObject;
		
		// The PlayerPrefs name of the sound
		public string playerPref = "SoundVolume";
		
		// The index of the current value of the sound
		internal float currentState = 1;

		[Tooltip("The volume when this sound button is toggled on")]
		public float volumeOn = 1;

		[Tooltip("The volume when this sound button is toggled off")]
		public float volumeOff = 0;
		

		void Awake()
		{
			if ( !soundObject && soundObjectTag != string.Empty )    soundObject = GameObject.FindGameObjectWithTag(soundObjectTag).transform;
			
			// Get the current state of the sound from PlayerPrefs
			if( soundObject )
				currentState = PlayerPrefs.GetFloat(playerPref, soundObject.GetComponent<AudioSource>().volume);
			else   
				currentState = PlayerPrefs.GetFloat(playerPref, currentState);
			
			// Set the sound in the sound source
			SetSound();
		}

        /// <summary>
        /// Sets the sound volume
        /// </summary>
        public void SetSound()
		{
			if ( !soundObject && soundObjectTag != string.Empty )    soundObject = GameObject.FindGameObjectWithTag(soundObjectTag).transform;
			
			// Set the sound in the PlayerPrefs
			PlayerPrefs.SetFloat(playerPref, currentState);
			
			Color newColor = GetComponent<Image>().material.color;
			
			// Update the graphics of the button image to fit the sound state
			if( currentState == volumeOn )
				newColor.a = 1;
			else
				newColor.a = 0.5f;
			
			GetComponent<Image>().color = newColor;
			
			// Set the value of the sound state to the source object
			if( soundObject ) 
				soundObject.GetComponent<AudioSource>().volume = currentState;
		}
		
		/// <summary>
		/// Toggle the sound.
		/// </summary>
		public void ToggleSound()
		{
			if( currentState == volumeOn )    currentState = volumeOff;
			else    currentState = volumeOn;
			
			SetSound();
		}

        /// <summary>
        /// Starts the sound source.
        /// </summary>
        public void StartSound()
		{
			if( soundObject )
				soundObject.GetComponent<AudioSource>().Play();
		}
	}
}