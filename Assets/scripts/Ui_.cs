using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Ui_ : MonoBehaviour
{
    public TextMeshProUGUI score_text;

    public void Set_score_text(int score)
    {
        score_text.text = score.ToString();
    }
}
