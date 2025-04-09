using System.Collections;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{
    public GameObject[] hazards; // Assign spikes/pistons here

    /* I comment this out as it is showing an error - Kapaw
    public IEnumerator ActivateHazards()
    {
        foreach (var hazard in hazards)
        {
            hazard.GetComponent<Hazard>().Trigger();
            yield return new WaitForSeconds(0.2f);
        }
        
    }
    */
}
