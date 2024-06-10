using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class DictionaryTest : MonoBehaviour
    {
        public Dictionary<string, Color> colors = new Dictionary<string, Color>();
        private void Start()
        {
            FillDictionaryWithColors();
            
            foreach (var v in colors)
            {
                print($"{v}, {v.Key}, {v.Value}");
            }
        }

        private void FillDictionaryWithColors()
        {
            colors.Add("red", Color.red);
            colors.Add("green", Color.green);
            colors.Add("blue", Color.blue);
        }
    }
}