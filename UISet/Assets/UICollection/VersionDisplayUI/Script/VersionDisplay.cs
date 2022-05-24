using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VersionDisplay : MonoBehaviour
{
    private TextMeshProUGUI uGUI = null;

    void Start()
    {
        uGUI = GetComponent<TextMeshProUGUI>();
        uGUI.text = Application.version;
    }
}
