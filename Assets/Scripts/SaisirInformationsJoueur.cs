using UnityEngine;
using TMPro;

public class SaisirInformationsJoueur : MonoBehaviour
{
    [SerializeField] private JoueurInfo joueurInfo;

    public TMP_InputField inputNomJoueur;
    public TMP_InputField inputNomVille;

    private void Start()
    {
        // Assurez-vous que les InputField sont référencés dans l'Inspector
        if (inputNomJoueur == null || inputNomVille == null)
        {
            Debug.LogWarning("Les InputField ne sont pas référencés.");
            return;
        }

        // Ajoutez des écouteurs d'événements aux InputField
        inputNomJoueur.onValueChanged.AddListener(OnNomJoueurChange);
        inputNomVille.onValueChanged.AddListener(OnNomVilleChange);
    }

    private void OnNomJoueurChange(string newValue)
    {
        joueurInfo.nomJoueur = newValue;
    }

    private void OnNomVilleChange(string newValue)
    {
        joueurInfo.nomVille = newValue;
    }
}
