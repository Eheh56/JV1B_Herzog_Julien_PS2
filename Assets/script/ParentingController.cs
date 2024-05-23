using UnityEngine;

public class ParentingController : MonoBehaviour
{
    // La méthode pour parenté sans changer l'échelle
    public void SetParentWithoutScaling(GameObject child, GameObject parent)
    {
        // Sauvegarder l'échelle d'origine de l'enfant
        Vector3 originalScale = child.transform.localScale;

        // Parenter l'enfant au parent
        child.transform.SetParent(parent.transform);

        // Restaurer l'échelle d'origine de l'enfant
        child.transform.localScale = originalScale;
    }
}