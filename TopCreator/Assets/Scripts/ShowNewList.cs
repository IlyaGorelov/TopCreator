using System.Linq;
using TMPro;
using UnityEngine;

public class ShowNewList : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    private void Start()
    {
        // text.text = PlayerPrefs.GetString("NewList");
        Properties.textNew = PlayerPrefs.GetString("NewList").Split("\n").ToList();
    }
    public void Show()
    {
        var textEdit = (from q in Properties.textNew where q != "" select q).ToArray();
        text.text = "";
        foreach (var a in textEdit)
        {
                text.text += a + "\n";
        }
        PlayerPrefs.SetString("NewList", text.text);
    }
}
