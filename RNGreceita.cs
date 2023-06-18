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
        "Sanduíche Estrela do Sabor",
        "Sanduíche Delícia Gourmet",
        "Sanduíche Aventureiro",
        "Sanduíche Supremo",
        "Sanduíche Sabor Divino",
        "Sanduíche Clássico Irresistível",
        "Sanduíche Exótico",
        "Sanduíche Celestial",
        "Sanduíche Irresistível",
        "Sanduíche Saboroso",
        "Sanduíche Fantástico",
        "Sanduíche Artesanal",
        "Sanduíche Gigante Apetitoso",
        "Sanduíche Maravilha",
        "Sanduíche Encantador",
        "Sanduíche Delicioso Mistério",
        "Sanduíche Magnífico",
        "Sanduíche Sabor Único",
        "Sanduíche Fascinante",
        "Sanduíche Delícia Suprema",
        "Sanduíche Apetite Feliz",
        "Sanduíche Sabor Surpreendente",
        "Sanduíche Perfeito",
        "Sanduíche Prazer em Cada Mordida",
        "Sanduíche Divino",
        "Sanduíche Sabor Celestial",
        "Sanduíche Incrível",
        "Sanduíche Especial",
        "Sanduíche Sublime",
        "Sanduíche Tentação",
        "Sanduíche Esplêndido",
        "Sanduíche Satisfação Garantida",
        "Sanduíche Surpreendente",
        "Sanduíche Estonteante",
        "Sanduíche Sabores do Mundo",
        "Sanduíche Prazer Supremo",
        "Sanduíche Delícia Absoluta",
        "Sanduíche Irresistível Tentação",
        "Sanduíche Sabor da Alegria",
        "Sanduíche Misterioso",
        "Sanduíche Inesquecível",
        "Sanduíche Fenomenal",
        "Sanduíche Apoteótico",
        "Sanduíche Sabor Sensacional",
        "Sanduíche Puro Prazer",
        "Sanduíche Sabor da Fantasia",
        "Sanduíche Único e Incrível",
        "Sanduíche Divino Pecado",
        "Sanduíche Sabor Inigualável",
        "Sanduíche Maravilhoso"
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

        // Lista para armazenar os números gerados
        List<int> randomNumbers = new List<int>();

        // Gerar três números aleatórios diferentes
        while (randomNumbers.Count < 3)
        {
            int randomNumber = Random.Range(minValue, maxValue + 1);

            // Verificar se o número já existe na lista
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
                ingredient = "Ingrediente inválido";
                break;
        }

        return ingredient;
    }

}
