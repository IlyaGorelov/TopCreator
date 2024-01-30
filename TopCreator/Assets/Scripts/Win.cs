using TMPro;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] TopCreate topCreate;
    TextMeshProUGUI bText;
    private void Start()
    {
        bText = GetComponentInChildren<TextMeshProUGUI>();
    }
    private void Update()
    {
        bText.text = topCreate.comparisonTextList[topCreate.activeFirstPosition];
    }
    public void bWin()
    {
        topCreate.activeSecondPosition += 1;
        if (topCreate.activeSecondPosition > topCreate.comparisonTextList.Count - 1)
        {
            Properties.textNew.Add(topCreate.comparisonTextList[topCreate.activeFirstPosition]);
            topCreate.comparisonTextList.Remove(topCreate.comparisonTextList[topCreate.activeFirstPosition]);
            topCreate.activeFirstPosition = 0;
            topCreate.activeSecondPosition = 1;
            Properties.text = "";
            foreach (var a in topCreate.comparisonTextList)
            {
                if (a != "")
                    Properties.text += a + "\n";
            }
            PlayerPrefs.SetString("OldList", Properties.text);
        }
    }
}
