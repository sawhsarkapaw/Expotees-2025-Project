using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class VRDebugManager : MonoBehaviour
{
    public TextMeshProUGUI debugText;
    private List<string> logs = new List<string>();
    public int maxLines = 50;

    void OnEnable()
    {
        Application.logMessageReceived += HandleLog;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= HandleLog;
    }

    void HandleLog(string logString, string stackTrace, LogType type)
    {
        logs.Add(logString);
        if (logs.Count > maxLines) logs.RemoveAt(0);

        debugText.text = string.Join("\n", logs);
    }
}