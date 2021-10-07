using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityAtoms.BaseAtoms;
using TMPro;
using Shapes2D;

public class UIController : MonoBehaviour
{
    [Header("Atoms")]
    [SerializeField] IntVariable score;
    [SerializeField] IntVariable scoreIncrement;
    [SerializeField] IntVariable scoreDecrement;
    [SerializeField] IntConstant scoreTreshold;

    [Header("UI Reference")]
    [SerializeField] Button decreaseBtn;
    [SerializeField] TextMeshProUGUI scoreTxt;
    [SerializeField] TextMeshProUGUI incrementValueTxt;
    [SerializeField] TextMeshProUGUI decrementValueTxt;
    [SerializeField] GameObject settingsPanel;
    [SerializeField] Shape scorePanel;

    void Start()
    {
        scoreTxt.text = $"Score: {score.Value}";
        incrementValueTxt.text = scoreIncrement.Value.ToString();
        decrementValueTxt.text = scoreDecrement.Value.ToString();

        decreaseBtn.enabled = score.Value <= 0 ? false : true;
        scorePanel.settings.fillColor2 = score.Value < 10 ? Color.red : Color.blue;
    }

    public void SetScoreUI(int value)
    {
        scoreTxt.text = $"Score: {value}";
    }   

    public void SetIncrementValueUI(int value)
    {
        incrementValueTxt.text = value.ToString();
    }

    public void SetDecrementValueUI(int value)
    {
        decrementValueTxt.text = value.ToString();
    }

    public void UpdateDecreaseButton(int value)
    {
        decreaseBtn.enabled = value <= 0 ? false : true; 
    }

    public void OpenSettingsPanel(bool open)
    {
        settingsPanel.SetActive(open);
    }

    public void UpdateScorePanelColor(int value)
    {
        scorePanel.settings.fillColor2 = value < scoreTreshold.Value ? Color.red : Color.blue;
    }
}
