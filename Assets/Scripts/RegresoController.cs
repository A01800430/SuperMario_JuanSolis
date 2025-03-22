using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class RegresoController : MonoBehaviour
{
    private UIDocument Regreso;

    private Button BotonRegreso;

    void OnEnable()
    {
        Regreso = GetComponent<UIDocument>();
        var root = Regreso.rootVisualElement;
        BotonRegreso = root.Q<Button>("BotonRegreso");

        BotonRegreso.RegisterCallback<ClickEvent>(Regresar);
    }

    private void Regresar(ClickEvent evt)
    {
        SceneManager.LoadScene("EscenaMenu");
    }
}
