using System.Collections;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{
    public GameObject[] hazards; // Assign spikes/pistons here

    public IEnumerator ActivateHazards()
    {
        foreach (var hazard in hazards)
        {
            hazard.GetComponent<Hazard>().Trigger();
            yield return new WaitForSeconds(0.2f);
        }
    }
}
