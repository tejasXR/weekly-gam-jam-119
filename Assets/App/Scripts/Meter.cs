using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meter : MonoBehaviour
{
    public GameManager.MeterType meterType;
    public bool filled;
    public Image meterFill;

    private void Update()
    {
        switch (meterType)
        {
            case GameManager.MeterType.Love:
                UpdateMeter(GameManager.Instance.loveMeter);
                break;

            case GameManager.MeterType.Water:
                UpdateMeter(GameManager.Instance.waterMeter);
                break;

            case GameManager.MeterType.Mineral:
                UpdateMeter(GameManager.Instance.mineralMeter);
                break;

            case GameManager.MeterType.Sun:
                UpdateMeter(GameManager.Instance.sunMeter);
                break;
        }
    }

    private void UpdateMeter(float _meterVariable)
    {
        RectTransform rT = meterFill.rectTransform;

        rT.offsetMax = new Vector2(_meterVariable - 250, rT.offsetMax.y);

        meterFill.rectTransform.offsetMax = rT.offsetMax;

        CheckMeterFull(_meterVariable);
    }

    private void CheckMeterFull(float _meterVariable)
    {
        if (_meterVariable > 245)
            filled = true;
        else
            filled = false;               
    }    
}
