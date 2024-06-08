using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeSceneOnKeyPress : MonoBehaviour
{
    public string targetScene; // Nom de la scène à charger
    public bool playerIsClose;
    public GameObject transitionCanvas; // Référence au Canvas contenant l'animation de transition
    public float transitionTime = 1f; // Durée de l'animation de transition
    public float postTransitionDelay = 0.5f; // Délai après la transition avant de désactiver le Canvas de transition

    private bool isTransitioning = false; // Variable pour vérifier si la transition est en cours

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose && !isTransitioning)
        {
            StartCoroutine(LoadSceneWithTransition());
        }
    }

    IEnumerator LoadSceneWithTransition()
    {
        isTransitioning = true;

        // Activer le Canvas de transition
        transitionCanvas.SetActive(true);

        // Attendre la durée de l'animation de transition
        yield return new WaitForSeconds(transitionTime);

        // Charger la nouvelle scène
        SceneManager.LoadScene(targetScene);

        // Attendre un peu après le chargement de la scène
        yield return new WaitForSeconds(postTransitionDelay);

        // Désactiver le Canvas de transition
        transitionCanvas.SetActive(false);

        isTransitioning = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
        }
    }
}
