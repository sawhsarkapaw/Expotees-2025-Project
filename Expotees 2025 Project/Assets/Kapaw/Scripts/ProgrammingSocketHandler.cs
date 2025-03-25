using UnityEngine;
using TMPro;

public class ProgrammingSocketHandler : MonoBehaviour
{
    [SerializeField] GameObject[] ProgrammingSockets;
    [SerializeField] TextMeshProUGUI debugText;
    private void OnEnable()
    {
        StartButton.OnStartButtonClicked += HandleStartButtonClicked;
        debugText.text = "Programming Socket Handler Enabled";
    }

    private void OnDisable()
    {
        StartButton.OnStartButtonClicked -= HandleStartButtonClicked;
    }

    private void HandleStartButtonClicked()
    {
        debugText.text = "Start Button Clicked";
    }
}
