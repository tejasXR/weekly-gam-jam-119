using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static GameManager;

public class IncreaseMeter : MonoBehaviour
{
    public GameManager.MeterType meterType;
    public float increaseAmount;

    public void Increase()
    {
        switch (meterType)
        {
            case GameManager.MeterType.Love:
                GameManager.Instance.ChangeLoveLevel(increaseAmount);
                break;

            case GameManager.MeterType.Water:
                GameManager.Instance.ChangeWaterLevel(increaseAmount);
                break;

            case GameManager.MeterType.Mineral:
                GameManager.Instance.ChangeMineralLevel(increaseAmount);
                break;

            case GameManager.MeterType.Sun:
                GameManager.Instance.ChangeSunLevel(increaseAmount);
                break;
        }
    }    
}
