using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    private UIDocument menu;
    private Button Jugar;
    private Button Ayuda;
    private Button Creditos;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        Jugar= root.Q<Button>("Jugar");
        Ayuda = root.Q<Button>("Ayuda");
        Creditos = root.Q<Button>("Creditos");


        // Callbacks
        Jugar.RegisterCallback<ClickEvent, String>(IniciarJuego, "SampleScene" );
        Ayuda.RegisterCallback<ClickEvent, String>(IniciarJuego, "EscenaAyuda" );
    }

    private void IniciarJuego(ClickEvent evt, String escena)
    {
        SceneManager.LoadScene(escena);
    }
    
}
