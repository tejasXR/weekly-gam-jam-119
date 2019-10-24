using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeManager : MonoBehaviour
{
    public GameObject[] treeModels;
    public Image[] levelImages;

    private int treeModelIndex = 0;

    private void OnEnable()
    {
        GameManager.TreeGrowCallback += ChangeTreeModel;
    }

    private void OnDisable()
    {
        GameManager.TreeGrowCallback -= ChangeTreeModel;
    }

    private void Start()
    {
        HideAllTreeModels();

        HideAllTreeImages();

        treeModels[treeModelIndex].SetActive(true);

        levelImages[treeModelIndex].enabled = true;
    }

    private void ChangeTreeModel()
    {
        treeModelIndex++;

        HideAllTreeModels();

        HideAllTreeImages();

        treeModels[treeModelIndex].SetActive(true);

        levelImages[treeModelIndex].enabled = true;
    }

    private void HideAllTreeModels()
    {
        for (int i = 0; i < treeModels.Length; i++)
        {
            treeModels[i].SetActive(false);
        }
    }

    private void HideAllTreeImages()
    {
        for (int i = 0; i < levelImages.Length; i++)
        {
            levelImages[i].enabled = false;
        }
    }
}
