using System;
using System.Collections;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float moveDistance = 0.1f;
    [SerializeField] private float moveSpeed = 1f;
    bool isMoving = false;
    void OnEnable()
    {
        TurnManager.OnCharacterAction += HandleCharacterAction;
    }

    void OnDisable()
    {
        TurnManager.OnCharacterAction -= HandleCharacterAction;
    }

    void HandleCharacterAction(string action)
    {
        switch (action)
        {
            case "MoveForward":
            if (!isMoving)
                {
                    StartCoroutine(MoveForward());
                }
                break;
            default:
                Debug.Log("Unknown action: " + action);
                break;
        }
    }

    private IEnumerator MoveForward()
    {
        isMoving = true;

        Vector3 startPosition = transform.position;
        Vector3 targetPosition = startPosition + transform.forward * moveDistance;

        float elaspedTime = 0f;
        float duration = moveDistance / moveSpeed;

        while (elaspedTime < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, elaspedTime / duration);
            elaspedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPosition;
        isMoving = false;
    }
}
