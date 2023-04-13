using UnityEngine;
using System;

namespace TwoOfAKindGame
{
    /// <summary>
    /// This script displays a list of images ( Sprite )
    /// </summary>
    public class TOKPairsText : MonoBehaviour
    {
        public string[] pairsText;

        void Awake()
        {
            // If we have a game controller, assign the list of images to it
            if (GetComponent<TOKGameController>()) GetComponent<TOKGameController>().pairsText = pairsText;
        }
	}
}