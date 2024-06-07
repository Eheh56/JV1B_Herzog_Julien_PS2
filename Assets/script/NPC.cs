using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public List<GameObject> dialoguePanels; // Liste des panels de dialogue
    public Text dialogueText;
    public string[] dialogue;
    private int index;

    public GameObject cont_Button;
    public float wordSpeed;
    public bool playerIsClose;

    public Animator animator; // Ajout de la référence à l'Animator
    public string animationName = "dialogue monte"; // Nom de l'animation à jouer

    private int currentPanelIndex; // Index du panel de dialogue actuellement actif

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            if (dialoguePanels[currentPanelIndex].activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                dialoguePanels[currentPanelIndex].SetActive(true);
                StartCoroutine(Typing());
                PlayAnimation();
            }
        }

        if (dialogueText.text == dialogue[index])
        {
            cont_Button.SetActive(true);
        }
    }

    public void zeroText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanels[currentPanelIndex].SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        cont_Button.SetActive(false);
        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
        }
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
            zeroText();
        }
    }

    private void PlayAnimation()
    {
        if (animator != null)
        {
            animator.Play(animationName);
        }
    }

    // Nouvelle méthode pour changer le panel de dialogue actif
    public void SetDialoguePanel(int panelIndex)
    {
        if (panelIndex >= 0 && panelIndex < dialoguePanels.Count)
        {
            dialoguePanels[currentPanelIndex].SetActive(false); // Désactiver le panel actuel
            currentPanelIndex = panelIndex; // Changer l'index
            dialogueText = dialoguePanels[currentPanelIndex].GetComponentInChildren<Text>(); // Mettre à jour le texte de dialogue
        }
    }
}
