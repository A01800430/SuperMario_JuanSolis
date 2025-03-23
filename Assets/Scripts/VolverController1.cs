using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class VolverController1 : MonoBehaviour
{
    private UIDocument Creditos;

    private Button VolverMenu;

    void OnEnable()
    {
        Creditos = GetComponent<UIDocument>();
        var root = Creditos.rootVisualElement;
        VolverMenu = root.Q<Button>("VolverMenu");

        VolverMenu.RegisterCallback<ClickEvent>(Regresar);
    }

    private void Regresar(ClickEvent evt)
    {
        SceneManager.LoadScene("EscenaMenu");
    }
}
