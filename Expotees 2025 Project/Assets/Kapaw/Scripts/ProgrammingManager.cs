using UnityEngine;

public class ProgrammingManager : MonoBehaviour
{
    [SerializeField] GameObject ProgrammingPanel;

    public void OpenProgrammingPanel()
    {
        ProgrammingPanel.SetActive(true);
    }

    public void CloseProgrammingPanel()
    {
        ProgrammingPanel.SetActive(false);
    }
}
