using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region VARIABLES

    public static GameManager Instance;

    public bool gameStart;

    public enum MeterType
    {
        Love,
        Water,
        Mineral,
        Sun
    }

    public float loveMeter { get; private set; }
    public float waterMeter { get; private set; }
    public float mineralMeter { get; private set; }
    public float sunMeter { get; private set; }

    public int growthPhase { get; private set; }

    private float loveDepletion;
    private float waterDepletion;
    private float mineralDepletion;
    private float sunDepletion;

    #endregion

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {

    }

    private void Update()
    {
        loveMeter -= Time.deltaTime * loveDepletion;
        waterMeter -= Time.deltaTime * waterDepletion;
        mineralMeter -= Time.deltaTime * mineralDepletion;
        sunMeter -= Time.deltaTime * sunDepletion;
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
        loveDepletion = _loveDepletion;
        waterDepletion = _waterDepletion;
        mineralDepletion = _mineralDepletion;
        sunDepletion = _sunDepletion;      
    }
    
    #region CHANGE LEVEL METHODS

    public void ChangeLoveLevel(float _num)
    {
        loveMeter += _num;
    }

    public void ChangeWaterLevel(float _num)
    {
        loveMeter += _num;
    }

    public void ChangeMineralLevel(float _num)
    {
        loveMeter += _num;
    }

    public void ChangeSunLevel(float _num)
    {
        loveMeter += _num;
    }

    #endregion
}
