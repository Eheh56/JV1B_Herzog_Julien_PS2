using UnityEngine;

public class ParentingController : MonoBehaviour
{
    // La m�thode pour parent� sans changer l'�chelle
    public void SetParentWithoutScaling(GameObject child, GameObject parent)
    {
        // Sauvegarder l'�chelle d'origine de l'enfant
        Vector3 originalScale = child.transform.localScale;

        // Parenter l'enfant au parent
        child.transform.SetParent(parent.transform);

        // Restaurer l'�chelle d'origine de l'enfant
        child.transform.localScale = originalScale;
    }
}