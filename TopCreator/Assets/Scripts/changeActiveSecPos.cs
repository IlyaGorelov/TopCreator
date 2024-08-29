using System;
using TMPro;
using UnityEngine;

public class changeActiveSecPos : MonoBehaviour
{
    [SerializeField] TopCreate topCreate;
    [SerializeField] TMP_InputField inputField;
    public void Change()
    {
        topCreate.activeSecondPosition = Int32.Parse(inputField.text);
    }
}

//On bChange