using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemDisplay : MonoBehaviour
{
    public Text gemText, finalGemText;
    private int gems;

    public void UpdateGems()
    {
        gems++;
        gemText.text = "Gems: " + gems;
    }

    public void DisplayFinalGems()
    {
        finalGemText.text = gems.ToString();
        finalGemText.gameObject.SetActive(true);
    }
}
