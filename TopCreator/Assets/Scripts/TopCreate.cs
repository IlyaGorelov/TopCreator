using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TopCreate : MonoBehaviour
{
    public List<string> comparisonTextList;
    [SerializeField] public TextMeshProUGUI compText;
    public int activeFirstPosition = 0;
    public int activeSecondPosition = 1;
    private void Update()
    {
        try { compText.text = comparisonTextList[activeFirstPosition] + 
                "\nor\n" + comparisonTextList[activeSecondPosition] + 
                $"\n{activeSecondPosition}/{comparisonTextList.Count - 1}"; }
        catch { }
    }
}
