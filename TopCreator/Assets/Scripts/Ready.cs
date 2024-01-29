
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class Ready : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TopCreate topCreate;
   

    private void Start()
    {

        inputField.text = PlayerPrefs.GetString("OldList");
    }
    public void INputToText()
    {
        topCreate.comparisonTextList=(inputField.text.Split('\n')).ToList();
    }

   
}
