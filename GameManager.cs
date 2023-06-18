using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject botoes;
    public GameObject telaMenu;
    public GameObject TelaFinal;

    public static GameManager instance;

    public Text textPontuacaoAtual;
    public int pontuacaoAtual;

    public Text textAcertos;
    public int acertos;

    public Text textErros;
    public int erros;

    public Text textPontuacaoFinal;


    public float timeToFinishLevel;
    public float TimeAtualLevel;
    public Text textoTempoParaTerminar;

    public float timeToFinishCountdown;
    public float TimeAtualCountdouwn;
    public Text textoTempoCountdown;

    public GameObject textoCountdown;

    public Botoes botoesClone;


    public List<GameObject> gameButtons;


    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        TimeAtualLevel = timeToFinishLevel;
        TimeAtualCountdouwn = timeToFinishCountdown;
    }


    // Update is called once per frame
    void Update()
    {
        TimeAtualCountdouwn -= Time.deltaTime;
        if (TimeAtualCountdouwn <= 0)
        {
            botoes.SetActive(true);
            textoCountdown.SetActive(false);
            TimeAtualLevel -= Time.deltaTime;

            if (TimeAtualLevel <= 0)
            {
                botoesClone.DestroyClones();
                textPontuacaoFinal.text = "Pontuação final: " + pontuacaoAtual;
                botoes.SetActive(false);
                TelaFinal.SetActive(true);

            }
            textoTempoParaTerminar.text = "Tempo: " + TimeAtualLevel.ToString("0.00");
        }
        textoTempoCountdown.text = TimeAtualCountdouwn.ToString("0.00");

    }

    public void Pontuar(int pontuacao)
    {
        pontuacaoAtual += pontuacao;
        textPontuacaoAtual.text = "Pontos: " + pontuacaoAtual;
    }

    public void ContarAcertos(int contagem)
    {
        acertos += contagem;
        textAcertos.text = "Sanduiches Certos: " + acertos;
    }

    public void ContarErros(int contagem)
    {
        erros += contagem;
        textErros.text = "Sanduiches Errados: " + erros;
    }
}
