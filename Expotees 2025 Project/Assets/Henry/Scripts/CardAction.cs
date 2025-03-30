using System.Collections;
using UnityEngine;

public abstract class CardAction
{
    public abstract IEnumerator Execute(CharacterMover character);
}
public class MoveForwardAction : CardAction
{
    public override IEnumerator Execute(CharacterMover character)
    {
        Vector3 targetPosition = character.transform.position + character.transform.forward;
        float duration = 0.5f;
        float elapsedTime = 0f;

        Vector3 startPosition = character.transform.position;

        while (elapsedTime < duration)
        {
            character.transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        character.transform.position = targetPosition;
    }
}
public class TurnLeftAction : CardAction
{
    public override IEnumerator Execute(CharacterMover character)
    {
        Quaternion startRotation = character.transform.rotation;
        Quaternion targetRotation = startRotation * Quaternion.Euler(0, -90, 0);
        float duration = 0.3f;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            character.transform.rotation = Quaternion.Slerp(startRotation, targetRotation, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        character.transform.rotation = targetRotation;
    }
}
public class TurnRightAction : CardAction
{
    public override IEnumerator Execute(CharacterMover character)
    {
        Quaternion startRotation = character.transform.rotation;
        Quaternion targetRotation = startRotation * Quaternion.Euler(0, 90, 0);
        float duration = 0.3f;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            character.transform.rotation = Quaternion.Slerp(startRotation, targetRotation, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        character.transform.rotation = targetRotation;
    }
}
