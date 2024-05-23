using UnityEngine;
using TMPro;

public class AfficherInformationsJoueur : MonoBehaviour
{
    [SerializeField] private JoueurInfo joueurInfo;

    public TextMeshProUGUI nomJoueurText;
    public TextMeshProUGUI nomVilleText;

    private void Update()
    {
        // Assurez-vous que les TextMeshPro sont référencés dans l'Inspector
        if (nomJoueurText == null || nomVilleText == null)
        {
            Debug.LogWarning("Les TextMeshPro ne sont pas référencés.");
            return;
        }

        // Mettez à jour les TextMeshPro avec les informations du joueur
        nomJoueurText.text = "Nom du Joueur : " + joueurInfo.nomJoueur;
        nomVilleText.text = "Nom de la Ville : " + joueurInfo.nomVille;
    }
}

