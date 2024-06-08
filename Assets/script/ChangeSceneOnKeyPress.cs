using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeSceneOnKeyPress : MonoBehaviour
{
    public string targetScene; // Nom de la sc�ne � charger
    public bool playerIsClose;
    public GameObject transitionCanvas; // R�f�rence au Canvas contenant l'animation de transition
    public float transitionTime = 1f; // Dur�e de l'animation de transition
    public float postTransitionDelay = 0.5f; // D�lai apr�s la transition avant de d�sactiver le Canvas de transition

    private bool isTransitioning = false; // Variable pour v�rifier si la transition est en cours

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

        // Attendre la dur�e de l'animation de transition
        yield return new WaitForSeconds(transitionTime);

        // Charger la nouvelle sc�ne
        SceneManager.LoadScene(targetScene);

        // Attendre un peu apr�s le chargement de la sc�ne
        yield return new WaitForSeconds(postTransitionDelay);

        // D�sactiver le Canvas de transition
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
