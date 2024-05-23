using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AfficherScore : MonoBehaviour
{
    [SerializeField] private ScoreData scoreData;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private int scoreMax = 10; // Score nécessaire pour changer de scène

    
    private void Update()
    {
        // Mettre à jour le texte de l'UI avec le score actuel
        scoreText.text = "Score: " + scoreData.score;

        // Vérifier si le score atteint le scoreMax
        if (scoreData.score >= scoreMax)
        {
            SceneManager.LoadScene("Fin");
        }
    }
}

