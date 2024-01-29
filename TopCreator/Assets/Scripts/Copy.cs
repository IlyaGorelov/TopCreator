using TMPro;
using UnityEngine;

public class Copy : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    public void bCopy()
    {
        TextEditor textEditor = new();
        textEditor.text = text.text;
        textEditor.SelectAll();
        textEditor.Copy();
    }
}
