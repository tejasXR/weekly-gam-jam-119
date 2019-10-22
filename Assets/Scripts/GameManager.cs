using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region VARIABLES

    public bool gameStart;

    public float loveLevel { get; private set; }
    public float waterLevel { get; private set; }
    public float mineralLevel { get; private set; }
    public float sunLevel { get; private set; }

    public int growthPhase { get; private set; }

    private float loveLevelDepletion;
    private float waterLevelDepletion;
    private float mineralLevelDepletion;
    private float sunLevelDepletion;

    private void Start()
    {
        
    }

    #endregion

    private void Update()
    {
        loveLevel -= Time.deltaTime * loveLevelDepletion;
        waterLevel -= Time.deltaTime * waterLevelDepletion;
        mineralLevel -= Time.deltaTime * mineralLevelDepletion;
        sunLevel -= Time.deltaTime * sunLevelDepletion;
    }

    private void GrowTree()
    {
        growthPhase++;

        switch (growthPhase)
        {
            // Seed
            case 0:
                ChangeDepletionVariables(.1F, .1F, .1F, .1F);
                break;

            // Sprout
            case 1:
                break;

            // Sampling
            case 2:
                break;

            // Tree
            case 3:
                break;
        }
    }

    private void ChangeDepletionVariables(float _loveDepletion, float _waterDepletion, float _mineralDepletion, float _sunDepletion)
    {
        loveLevelDepletion = _loveDepletion;
        waterLevelDepletion = _waterDepletion;
        mineralLevelDepletion = _mineralDepletion;
        sunLevelDepletion = _sunDepletion;      
    }

    

    #region CHANGE LEVEL METHODS

    public void ChangeLoveLevel(float _num)
    {
        loveLevel += _num;
    }

    public void ChangeWaterLevel(float _num)
    {
        loveLevel += _num;
    }

    public void ChangeMineralLevel(float _num)
    {
        loveLevel += _num;
    }

    public void ChangeSunLevel(float _num)
    {
        loveLevel += _num;
    }

    #endregion
}
