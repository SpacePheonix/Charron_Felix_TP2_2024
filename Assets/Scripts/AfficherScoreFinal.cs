using UnityEngine;
using TMPro;

public class AfficherScoreFinal : MonoBehaviour
{
    [SerializeField] private ScoreData scoreData;
    [SerializeField] private TextMeshProUGUI scoreFinalText;

    void Start()
    {
        scoreFinalText.text = "Score Final: " + scoreData.score;
    }
}

