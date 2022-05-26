using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GraphicsMemorySizeDisplay : MonoBehaviour
{
    private TextMeshProUGUI uGUI = null;

    void Start()
    {
        uGUI = GetComponent<TextMeshProUGUI>();
        uGUI.text = "GraphicsMemorySize : " + SystemInfo.graphicsMemorySize.ToString() + "MB";
    }
}
