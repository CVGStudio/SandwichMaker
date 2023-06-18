using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RNGreceita : MonoBehaviour
{
    public static RNGreceita instance1;
    public Text recipeText1;
    public List<int> receita;

    public string nomeSanduiche;
    public Text nomeSanduichesText;

    private List<string> nomeSanduiches = new List<string>()
    {
        "Sandu�che Estrela do Sabor",
        "Sandu�che Del�cia Gourmet",
        "Sandu�che Aventureiro",
        "Sandu�che Supremo",
        "Sandu�che Sabor Divino",
        "Sandu�che Cl�ssico Irresist�vel",
        "Sandu�che Ex�tico",
        "Sandu�che Celestial",
        "Sandu�che Irresist�vel",
        "Sandu�che Saboroso",
        "Sandu�che Fant�stico",
        "Sandu�che Artesanal",
        "Sandu�che Gigante Apetitoso",
        "Sandu�che Maravilha",
        "Sandu�che Encantador",
        "Sandu�che Delicioso Mist�rio",
        "Sandu�che Magn�fico",
        "Sandu�che Sabor �nico",
        "Sandu�che Fascinante",
        "Sandu�che Del�cia Suprema",
        "Sandu�che Apetite Feliz",
        "Sandu�che Sabor Surpreendente",
        "Sandu�che Perfeito",
        "Sandu�che Prazer em Cada Mordida",
        "Sandu�che Divino",
        "Sandu�che Sabor Celestial",
        "Sandu�che Incr�vel",
        "Sandu�che Especial",
        "Sandu�che Sublime",
        "Sandu�che Tenta��o",
        "Sandu�che Espl�ndido",
        "Sandu�che Satisfa��o Garantida",
        "Sandu�che Surpreendente",
        "Sandu�che Estonteante",
        "Sandu�che Sabores do Mundo",
        "Sandu�che Prazer Supremo",
        "Sandu�che Del�cia Absoluta",
        "Sandu�che Irresist�vel Tenta��o",
        "Sandu�che Sabor da Alegria",
        "Sandu�che Misterioso",
        "Sandu�che Inesquec�vel",
        "Sandu�che Fenomenal",
        "Sandu�che Apote�tico",
        "Sandu�che Sabor Sensacional",
        "Sandu�che Puro Prazer",
        "Sandu�che Sabor da Fantasia",
        "Sandu�che �nico e Incr�vel",
        "Sandu�che Divino Pecado",
        "Sandu�che Sabor Inigual�vel",
        "Sandu�che Maravilhoso"
    };

    private void Awake()
    {
        instance1 = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        receita = GenerateRandomRecipe();
        DisplayRecipe();
    }
    public List<int> GenerateRandomRecipe()
    {
        GenerateRandomRecipeName();

        int minValue = 1;
        int maxValue = 5;

        // Lista para armazenar os n�meros gerados
        List<int> randomNumbers = new List<int>();

        // Gerar tr�s n�meros aleat�rios diferentes
        while (randomNumbers.Count < 3)
        {
            int randomNumber = Random.Range(minValue, maxValue + 1);

            // Verificar se o n�mero j� existe na lista
            if (!randomNumbers.Contains(randomNumber))
            {
                randomNumbers.Add(randomNumber);
            }
        }

        return randomNumbers;
    }

    public void GenerateRandomRecipeName()
    {
        int randomIndex = Random.Range(0, nomeSanduiches.Count);
        nomeSanduiche = nomeSanduiches[randomIndex];
        nomeSanduichesText.text = nomeSanduiche;
    }

    public void ClearRecipe()
    {
        receita.Clear();
        receita = GenerateRandomRecipe();
        DisplayRecipe();
    }

    public void DisplayRecipe()
    {
        string recipe = "Ingredientes:\n";

        foreach (int number in receita)
        {
            string ingredient = GetIngredientName(number);
            recipe += "- " + ingredient + "\n";
        }

        // Exibir a receita na tela
        recipeText1.text = recipe;
    }

    public string GetIngredientName(int number)
    {
        string ingredient = "";

        switch (number)
        {
            case 1:
                ingredient = "Alface";
                break;
            case 2:
                ingredient = "Tomate";
                break;
            case 3:
                ingredient = "Ovo";
                break;
            case 4:
                ingredient = "Queijo";
                break;
            case 5:
                ingredient = "Presunto";
                break;
            default:
                ingredient = "Ingrediente inv�lido";
                break;
        }

        return ingredient;
    }

}
