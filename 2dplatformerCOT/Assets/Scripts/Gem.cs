using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
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
            gemDisplay.UpdateGems();
            Destroy(gameObject);
        }
    }
}
