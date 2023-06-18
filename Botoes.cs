using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botoes : MonoBehaviour
{

    public GameObject tomateIngrediente;
    public GameObject alfaceIngrediente;
    public GameObject ovoIngrediente;
    public GameObject queijoIngrediente;
    public GameObject presuntoIngrediente;

    private GameObject tomateClone;
    private GameObject alfaceClone;
    private GameObject ovoClone;
    private GameObject queijoClone;
    private GameObject presuntoClone;

    public Transform spawnPoint;

    public Text recipeText;

    public Button[] recipeButtons;

    public string storedRecipe = "";

    public List<int> recipeIngredients = new List<int>();

    public ComparadorReceitas compare;

    public void Start()
    {

        foreach (Button button in recipeButtons)
        {
            button.onClick.AddListener(() => StoreRecipe(button.GetComponentInChildren<Text>().text));
        }
    }


    public void ActivateAlface()
    {
        alfaceClone = Instantiate(alfaceIngrediente, spawnPoint.position, Quaternion.identity);
        AddIngredient(1);
    }

    public void ActivateTomate()
    {
        tomateClone = Instantiate(tomateIngrediente, spawnPoint.position, Quaternion.identity);
        AddIngredient(2);
    }

    public void ActivateOvo()
    {
        ovoClone = Instantiate(ovoIngrediente, spawnPoint.position, Quaternion.identity);
        AddIngredient(3);
    }

    public void ActivateQueijo()
    {
        queijoClone = Instantiate(queijoIngrediente, spawnPoint.position, Quaternion.identity);
        AddIngredient(4);
    }

    public void Activatepresunto()
    {
        presuntoClone = Instantiate(presuntoIngrediente, spawnPoint.position, Quaternion.identity);
        AddIngredient(5);
    }

    public void StoreRecipe(string recipe)
    {
        storedRecipe = recipe;
        //Debug.Log("Receita armazenada: " + storedRecipe);
    }

    public void AddIngredient(int ingredient)
    {
        if (recipeIngredients.Count < 3)
        {
            recipeIngredients.Add(ingredient);
        }

        if (recipeIngredients.Count <= 3)
        {
            DisplayRecipe();
        }

        if (recipeIngredients.Count >= 3)
        {
            DestroyClones();
            compare.CompareRecipes();
        }

    }

    public void DestroyClones()
    {
        if (tomateClone != null)
        {
            DestroyImmediate(tomateClone,true);
        }

        if (alfaceClone != null)
        {
            DestroyImmediate(alfaceClone,true);
        }

        if (ovoClone != null)
        {
            DestroyImmediate(ovoClone,true);
        }

        if (queijoClone != null)
        {
            DestroyImmediate(queijoClone, true);
        }

        if (presuntoClone != null)
        {
            DestroyImmediate(presuntoClone, true);
        }

    }

    public void ClearRecipe()
    {
        recipeIngredients.Clear();
        DisplayRecipe();
    }

    public void DisplayRecipe()
    {
        string recipe = "Ingredientes:\n";

        foreach (int ingredient in recipeIngredients)
        {
            string ingredientName = GetIngredientName(ingredient);
            recipe += "- " + ingredientName + "\n";
        }

        recipeText.text = recipe;
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

