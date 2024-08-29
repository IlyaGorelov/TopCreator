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
        try { bText.text = topCreate.comparisonTextList[topCreate.activeFirstPosition]; }
        catch { }
    }
    public void bWin()
    {
        topCreate.activeSecondPosition += 1;
        if (topCreate.activeSecondPosition > topCreate.comparisonTextList.Count - 1)
        {
            ShowNewList.newList += topCreate.comparisonTextList[topCreate.activeFirstPosition] + "\n";
            PlayerPrefs.SetString("New List", ShowNewList.newList);
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
