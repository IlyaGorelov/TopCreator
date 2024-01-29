
using TMPro;
using UnityEngine;

public class ShowNewList : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    private void Start()
    {
        text.text = PlayerPrefs.GetString("NewList");
    }
    public void Show()
    {
        
        foreach(var a in Properties.textNew)
        {
            if (!text.text.Contains(a))
            {
            text.text += a + "\n";

            }
        }
        PlayerPrefs.SetString("NewList", text.text);
    }
}
