using UnityEngine;

public class ChangeCompleteTopPos : MonoBehaviour
{
    [SerializeField] GameObject completeTop;

    public void ChangePos(float y)
    {
       completeTop.transform.position = new 
            Vector3(completeTop.transform.position.x,y,
            completeTop.transform.position.z);
    }
}
