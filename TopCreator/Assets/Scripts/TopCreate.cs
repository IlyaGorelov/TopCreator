using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TopCreate : MonoBehaviour
{
    public List<string> comparisonTextList;
    [SerializeField] public TextMeshProUGUI compText;
    public int activeFirstPosition = 0;
    public int activeSecondPosition = 1;
    
    private void Start()
    {
        
    }
    private void Update()
    {
        compText.text= comparisonTextList[activeFirstPosition] + "\n���\n"+ comparisonTextList[activeSecondPosition];
    }
}
