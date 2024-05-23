using UnityEngine;

public class ZoneDeRecyclage : MonoBehaviour
{
    [SerializeField] private ScoreData scoreData;
    [SerializeField] private int pointsParObjet = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Recyclage"))
        {
            // Détruire l'objet entrant
            Destroy(other.gameObject);

            // Ajouter des points au score
            scoreData.score += pointsParObjet;
        }
    }
}



