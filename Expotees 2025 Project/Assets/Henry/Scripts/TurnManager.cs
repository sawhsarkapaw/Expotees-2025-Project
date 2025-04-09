using System.Collections;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private enum TurnState
    {
        PlayerTurn,
        EnvironmentTurn,
        EndCheck
    }

    public static TurnManager Instance;

    private TurnState currentState;
    public CharacterMover characterMover;  // Reference to your character movement script
    public EnvironmentController environmentController; // Handles pistons, spikes, etc.

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            // DontDestroyOnLoad(this.gameObject); // Uncomment if you want it to persist across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        currentState = TurnState.PlayerTurn;
        StartCoroutine(TurnLoop());
    }

    private IEnumerator TurnLoop()
    {
        while (true)
        {
            switch (currentState)
            {
                case TurnState.PlayerTurn:
                    yield return characterMover.ExecuteNextMove();
                    currentState = TurnState.EnvironmentTurn;
                    break;

                case TurnState.EnvironmentTurn:
                    //I comment this out as it is showing an error - Kapaw
                    //yield return environmentController.ActivateHazards();
                    currentState = TurnState.EndCheck;
                    break;

                case TurnState.EndCheck:
                    if (characterMover.HasReachedGoal())
                    {
                        Debug.Log("Level Complete!");
                        yield break;
                    }
                    currentState = TurnState.PlayerTurn;
                    break;
            }
            yield return new WaitForSeconds(0.5f); // Small delay for better pacing
        }
    }
}
