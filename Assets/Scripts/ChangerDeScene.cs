using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonChargementScene : MonoBehaviour
{
    // Nom de la scène à charger
    public string nomDeLaSceneACharger;

    // Méthode appelée lors du clic sur le bouton
    public void ChargerScene()
    {
        // Charge la scène spécifiée
        SceneManager.LoadScene(nomDeLaSceneACharger);
    }
}