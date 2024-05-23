using UnityEngine;
using TMPro;

public class AfficherScore : MonoBehaviour
{
    [SerializeField] private ScoreData scoreData;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Update()
    {
        // Mettre à jour le texte de l'UI avec le score actuel
        scoreText.text = "Score: " + scoreData.score;
    }
}
