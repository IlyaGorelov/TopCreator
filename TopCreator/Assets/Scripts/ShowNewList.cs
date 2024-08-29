using System.Linq;
using TMPro;
using UnityEngine;

public class ShowNewList : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    public static string newList;

    private void Start()
    {
        Properties.textNew = PlayerPrefs.GetString("NewList").Split("\n").ToList();
        newList = PlayerPrefs.GetString("New List");
    }
    public void Show()
    {
        text.text = newList;
    }
}
