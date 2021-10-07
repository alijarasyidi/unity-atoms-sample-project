using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityAtoms.BaseAtoms;

public class ScoreController : MonoBehaviour
{
    [Header("Atoms")]
    [SerializeField] IntVariable score;
    [SerializeField] IntVariable scoreIncrement;
    [SerializeField] IntVariable scoreDecrement;

    public void IncreaseScore()
    {
        score.Value += scoreIncrement.Value;
    }

    public void DecreaseScore()
    {
        if (score.Value - scoreDecrement.Value >= 0)
        {
            score.Value -= scoreDecrement.Value;
        }
    }

    public void AddIncrementValue(int amount)
    {
        if (scoreIncrement.Value + amount >= 0)
        {
            scoreIncrement.Value += amount;
        }
    }

    public void AddDecrementValue(int amount)
    {
        if (scoreDecrement.Value + amount >= 0)
        {
            scoreDecrement.Value += amount;
        }
    }
}
