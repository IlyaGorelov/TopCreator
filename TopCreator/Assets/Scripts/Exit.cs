using UnityEngine;

public class Exit : MonoBehaviour
{
    public void bExit()
    {
        Application.Quit();
    }
    public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }
}
