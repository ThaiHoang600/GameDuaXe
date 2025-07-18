using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Nameinput : MonoBehaviour
    
{
    public TMP_InputField nameInput;

    public void SaveName()
    {
        GameData.playerName = nameInput.text;
    }
}
