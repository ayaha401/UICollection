using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GraphicsDeviceNameDisplay : MonoBehaviour
{
    private TextMeshProUGUI uGUI = null;

    void Start()
    {
        uGUI = GetComponent<TextMeshProUGUI>();
        uGUI.text = SystemInfo.graphicsDeviceName;
    }
}
