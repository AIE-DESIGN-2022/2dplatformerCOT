using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndZone : MonoBehaviour
{
    private GemDisplay gemDisplay;

    private void Start()
    {
        gemDisplay = FindObjectOfType<GemDisplay>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gemDisplay.DisplayFinalGems();
        }
    }
}
