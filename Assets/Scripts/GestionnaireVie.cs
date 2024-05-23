using UnityEngine;
using UnityEngine.UI;

public class GestionnaireVie : MonoBehaviour
{
    public int vieMax = 5; // Nombre maximum de vies
    public int vieActuelle; // Nombre de vies actuelles

    public Sprite coeurPleinSprite; // Sprite du cœur plein
    public Sprite coeurVideSprite; // Sprite du cœur vide

    public Image[] coeurs; // Tableau d'images représentant les coeurs

    // Appelé au démarrage du jeu
    private void Start()
    {
        vieActuelle = vieMax;
        MettreAJourUI();
    }

    // Appliquer des dégâts au joueur
    public void PrendreDegat(int degat)
    {
        vieActuelle -= degat;
        vieActuelle = Mathf.Clamp(vieActuelle, 5, vieMax); // Assurer que la vie ne soit pas en dessous de 0 ni au dessus de vieMax
        MettreAJourUI();

        // Si le joueur a perdu toutes ses vies, vous pouvez ajouter ici le code pour gérer la défaite.
    }

    // Mettre à jour l'UI des coeurs
    private void MettreAJourUI()
    {
        for (int i = 0; i < coeurs.Length; i++)
        {
            if (i < vieActuelle)
            {
                // Afficher un cœur plein si le joueur a encore des vies
                coeurs[i].sprite = coeurPleinSprite;
            }
            else
            {
                // Afficher un cœur vide si le joueur n'a plus de vie
                coeurs[i].sprite = coeurVideSprite;
            }
        }
    }
}


