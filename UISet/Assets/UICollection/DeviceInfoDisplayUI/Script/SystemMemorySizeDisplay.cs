using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SystemMemorySizeDisplay : MonoBehaviour
{
    private TextMeshProUGUI uGUI = null;

    void Start()
    {
        uGUI = GetComponent<TextMeshProUGUI>();
        uGUI.text = "MemorySize : " + SystemInfo.systemMemorySize.ToString() + "MB";
    }
}
