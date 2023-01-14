using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    private int counter = 0;
    private string text = "Score: ";
    public TextMeshProUGUI ScoreText;

    public void ChangeScore(int add = 1)
    {
        counter += add;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.SetText(text + counter);
    }
}
