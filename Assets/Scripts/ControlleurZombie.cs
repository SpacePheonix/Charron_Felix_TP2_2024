using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
 
   
    public class ControlleurZombie : MonoBehaviour
{
    private NavMeshAgent Monstre;
    [SerializeField] private GameObject _joueur;
    private Animator animator;
    private bool canTakeDamage = true;
    private float damageDelay = 2f;
   private AudioSource audiocollision;
    // Start is called before the first frame update
    void Start()
    {
        Monstre = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }
 
    // Update is called once per frame
    void Update()
    {
        if (Monstre.enabled)
        {
            Vector3 positionJoueur = _joueur.transform.position;
            Monstre.SetDestination(positionJoueur);
            //calcule la distance entre l'agent et la destination
            float distance = Vector3.Distance(Monstre.transform.position, positionJoueur);
            if (distance <= Monstre.stoppingDistance)
            {
                //si la distance est inferieur a la distance modifie sur le inspecteur, l'agent
                Monstre.isStopped = true;
                // Active le parametre attaque sur l'animateur
                animator.SetTrigger("Attack2");
               
 
            }
            else
            {
                Monstre.isStopped = false;
            }
        }
    }
    private IEnumerator DecreaseLivesWithDelay()
    {
        canTakeDamage = false;
 
       
        yield return new WaitForSeconds(damageDelay);
 
 
        canTakeDamage = true;
    }
 
}