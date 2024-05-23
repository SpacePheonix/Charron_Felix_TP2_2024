using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GestionnaireScore : MonoBehaviour
{
    public int score;
    public int scoreMax = 10; // Score nécessaire pour changer de scène
    public TMP_Text scoreText;

    private void Start()
    {
        score = 0;
        MettreAJourUI();
    }

    public void AjouterPoints(int points)
    {
        score += points;
        MettreAJourUI();

        if (score >= scoreMax)
        {
            SceneManager.LoadScene("Fin");
        }
    }

    private void MettreAJourUI()
    {
        scoreText.text = "Score: " + score;
    }
}

