using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManager : MonoBehaviour
{
    public GameObject[] treeModels;

    private int treeModelIndex = 0;

    private void OnEnable()
    {
        GameManager.TreeGrowCallback += ChangeTreeModel;
    }

    private void OnDisable()
    {
        GameManager.TreeGrowCallback -= ChangeTreeModel;
    }

    private void ChangeTreeModel()
    {
        treeModelIndex++;

        HideAllTreeModels();

        treeModels[treeModelIndex].SetActive(true);
    }

    private void HideAllTreeModels()
    {
        for (int i = 0; i < treeModels.Length; i++)
        {
            treeModels[i].SetActive(false);
        }
    }
}
