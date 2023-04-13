using UnityEngine;
using System;

namespace Project
{
    /// <summary>
    /// This script displays a list of text pairs, each pair contains a First Text and a Second Text
    /// </summary>
    public class imagePairs : MonoBehaviour
    {
        public Sprite[] pairsImage;

        void Awake()
        {
            // If we have a game controller, assign the list of text pairs to it
            if (GetComponent<gameController>()) GetComponent<gameController>().pairsImage = pairsImage;
        }
	}
}