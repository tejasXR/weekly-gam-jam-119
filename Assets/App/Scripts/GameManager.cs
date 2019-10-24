using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region EVENTS

    public static event Action TreeGrowCallback;

    public void OnTreeGrow()
    {
        TreeGrowCallback?.Invoke();
    }

    #endregion

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
        ChangeDepletionVariables(2F, 2F, 2F, 2F);
    }

    private void Update()
    {       
        if (loveMeter > 250)
        {
            loveMeter = 250;
        }            
        else if (loveMeter > 0)
        {
            loveMeter -= Time.deltaTime * loveDepletion;
        }

        if (waterMeter > 250)
        {
            waterMeter = 250;
        }
        else if (waterMeter > 0)
        {
            waterMeter -= Time.deltaTime * waterDepletion;
        }

        if (mineralMeter > 250)
        {
            mineralMeter = 250;
        }
        else if (mineralMeter > 0)
        {
            mineralMeter -= Time.deltaTime * mineralDepletion;
        }
    }

    public void ResetMeter(MeterType _meterType)
    {
        switch (_meterType)
        {
            case MeterType.Love:
                loveMeter = 0;
                break;

            case MeterType.Water:
                waterMeter = 0;
                break;

            case MeterType.Mineral:
                mineralMeter = 0;
                break;

            case MeterType.Sun:
                sunMeter = 0;
                break;
        }
    }

    public void ResetMeters()
    {
       
                loveMeter = 0;
              
                waterMeter = 0;
              
                mineralMeter = 0;
               
                sunMeter = 0;
               
        
    }

    public void GrowTree()
    {
        if (growthPhase < 3)
        {
            growthPhase++;

            if (growthPhase != 3)
                ResetMeters();

            switch (growthPhase)
            {
                // Sprout
                case 1:
                    ChangeDepletionVariables(5F, 3F, 3F, 3F);
                    break;

                // Sampling
                case 2:
                    ChangeDepletionVariables(4F, 3.5F, 3.5F, 2F);
                    break;

                // Tree
                case 3:
                    ChangeDepletionVariables(0F, 0F, 0F, 0F);
                    break;
            }

            OnTreeGrow();
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
        waterMeter += _num;
    }

    public void ChangeMineralLevel(float _num)
    {
        mineralMeter += _num;
    }

    public void ChangeSunLevel(float _num)
    {
        sunMeter += _num;
    }

    #endregion
}
