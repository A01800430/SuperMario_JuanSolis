using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class VolverController : MonoBehaviour
{
    private UIDocument Ayuda;

    private Button VolverMenu;

    void OnEnable()
    {
        Ayuda = GetComponent<UIDocument>();
        var root = Ayuda.rootVisualElement;
        VolverMenu = root.Q<Button>("VolverMenu");

        VolverMenu.RegisterCallback<ClickEvent>(Regresar);
    }

    private void Regresar(ClickEvent evt)
    {
        SceneManager.LoadScene("EscenaMenu");
    }
}
