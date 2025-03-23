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
    private Button Salir;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        Jugar= root.Q<Button>("Jugar");
        Ayuda = root.Q<Button>("Ayuda");
        Creditos = root.Q<Button>("Creditos");
        Salir = root.Q<Button>("Salir");



        // Callbacks
        Jugar.RegisterCallback<ClickEvent, String>(IniciarJuego, "SampleScene" );
        Ayuda.RegisterCallback<ClickEvent, String>(IniciarJuego, "EscenaAyuda" );
        Creditos.RegisterCallback<ClickEvent, String>(IniciarJuego, "EscenaCreditos" );
        Salir.RegisterCallback<ClickEvent>(QuitGame );

    }

    private void IniciarJuego(ClickEvent evt, String escena)
    {
        SceneManager.LoadScene(escena);
    }

    private void QuitGame(ClickEvent evt)
    {
        Application.Quit();
    }
    
}
