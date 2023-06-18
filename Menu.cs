using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject bototes;
    public GameObject telaMenu;
    public GameObject TelaComoJogar;
    public GameObject TelaFinal;


    public void Awake()
    {

        Time.timeScale = 0f;
        telaMenu.SetActive(true);
        TelaComoJogar.SetActive(false);
        TelaFinal.SetActive(false);
    }

    public void Start()
    {
        bototes.SetActive(false);
    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        telaMenu.SetActive(false);
        TelaFinal.SetActive(false);
        bototes.SetActive(true);
    }

    public void ComoJogar()
    {
        telaMenu.SetActive(false);
        TelaComoJogar.SetActive(true);
    }

    public void Voltar()
    {
        telaMenu.SetActive(true);
        TelaComoJogar.SetActive(false);
    }

    public void VoltaMenu()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        telaMenu.SetActive(false);
        TelaFinal.SetActive(true);
        bototes.SetActive(true);
    }

    public void QuitGame()
    {
        //Editor unity
        //UnityEditor.EditorApplication.isPlaying = false;

        //Jogo Compilado
        Application.Quit();
    }
}
