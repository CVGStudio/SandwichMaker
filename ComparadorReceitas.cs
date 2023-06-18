using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComparadorReceitas : MonoBehaviour
{
    public RNGreceita rngReceita;
    public Botoes botoes;
    public int valorPontuação;
    public int perdePontos;
    public int sanduiches;

    public void CompareRecipes()
    {
        List<int> receitaGerada = rngReceita.receita;
        List<int> receitaArmazenada = botoes.recipeIngredients;

        if (ListsAreEqual(receitaGerada, receitaArmazenada))
        {
            GameManager.instance.Pontuar(valorPontuação);
            GameManager.instance.ContarAcertos(sanduiches);
            Debug.Log("As receitas são iguais!");
            ClearAndGenerateRecipe();


        }
        else
        {
            Debug.Log("As receitas são diferentes!");
            GameManager.instance.Pontuar(perdePontos);
            GameManager.instance.ContarErros(sanduiches);
            ClearAndGenerateRecipe();
        }

    }


    private void ClearAndGenerateRecipe()
    {
        botoes.ClearRecipe();
        rngReceita.ClearRecipe();
    }

    private bool ListsAreEqual(List<int> list1, List<int> list2)
    {
        if (list1 == null || list2 == null)
        {
            return list1 == list2;
        }

        if (list1.Count != list2.Count)
        {
            return false;
        }

        for (int i = 0; i < list1.Count; i++)
        {
            if (list1[i] != list2[i])
            {
                return false;
            }
        }

        return true;
    }
}
