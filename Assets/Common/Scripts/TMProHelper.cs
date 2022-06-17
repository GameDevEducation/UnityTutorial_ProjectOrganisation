using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Common
{
    public class TMProHelper
    {
        public static void SetTextSizeAndColour(TMP_Text textToUpdate, float size, Color colour)
        {
            textToUpdate.fontSize = size;
            textToUpdate.color = colour;
        }
    }
}

