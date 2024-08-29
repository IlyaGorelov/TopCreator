using UnityEngine;

public class DeleteNewList : MonoBehaviour
{
    public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }
}
