using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowName : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text nameText;

    void Start()
    {
        nameText.text = "Player: " + GameData.playerName;
    }
}
