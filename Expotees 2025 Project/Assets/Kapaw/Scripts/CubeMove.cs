using UnityEngine;

public class CubeMove : MonoBehaviour
{
   [SerializeField] GameObject character;

   public void DoAction()
   {
        character.transform.position += new Vector3(0, 0, 1);
   }
}
