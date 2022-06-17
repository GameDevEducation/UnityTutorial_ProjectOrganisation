using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Common;

public class UpdateUIText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TMProHelper.SetTextSizeAndColour(GetComponent<TMP_Text>(), 72, Color.green);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
