using UnityEngine;

public class ProgrammingManager : MonoBehaviour
{
    [SerializeField] GameObject ProgrammingPanel;

    public void OpenProgrammingPanel()
    {
        ProgrammingPanel.SetActive(true);
        Debug.Log("Programming Panel Opened");
    }

    public void CloseProgrammingPanel()
    {
        ProgrammingPanel.SetActive(false);
        Debug.Log("Programming Panel Closed");
    }
}
