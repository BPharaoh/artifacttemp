using UnityEngine;
using System;

namespace Project
{
    /// <summary>
    /// This script displays a list of images ( Sprite )
    /// </summary>
    public class textPairs : MonoBehaviour
    {
        public string[] pairsText;

        void Awake()
        {
            // If we have a game controller, assign the list of images to it
            if (GetComponent<gameController>()) GetComponent<gameController>().pairsText = pairsText;
        }
	}
}