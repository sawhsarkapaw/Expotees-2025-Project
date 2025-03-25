using System;
using TMPro;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI DebugText;
    public static event Action OnStartButtonClicked;

    public void OnClick()
    {
        OnStartButtonClicked?.Invoke();
        DebugText.text = "Start Button Clicked";
    }
}
