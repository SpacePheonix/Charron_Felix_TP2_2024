using UnityEngine;

[CreateAssetMenu(menuName = "SO/EtatJeu")]
public class EtatJeu : ScriptableObject
{
    public bool informationsJoueurRemplies;

    public void RemplirInformationsJoueur(bool etat)
    {
        informationsJoueurRemplies = etat;
    }
}

