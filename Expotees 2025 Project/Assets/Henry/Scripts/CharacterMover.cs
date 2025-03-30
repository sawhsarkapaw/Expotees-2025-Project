using System.Collections;
using System.Collections.Generic; // This enables Queue<T>
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public Queue<CardAction> actions = new Queue<CardAction>(); // Stores movement actions

    public IEnumerator ExecuteNextMove()
    {
        if (actions.Count > 0)
        {
            CardAction action = actions.Dequeue();
            yield return action.Execute(this);
        }
    }

    public bool HasReachedGoal()
    {
        // Check if the character is at the goal
        return false; // Replace with actual logic
    }
    public void AddAction(CardAction action)
    {
        actions.Enqueue(action);
    }

}
