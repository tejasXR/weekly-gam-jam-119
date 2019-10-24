using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeterManager : MonoBehaviour
{
    public Meter loveMeter;
    public Meter waterMeter;
    public Meter mineralMeter;
    public Meter sunMeter;

    private void Update()
    {
        switch (GameManager.Instance.growthPhase)
        {
            case 0:
                if (loveMeter.filled)
                {
                    GameManager.Instance.GrowTree();
                }
                break;

            case 1:
                if (loveMeter.filled && waterMeter.filled && mineralMeter.filled)// && sunMeter.filled)
                {
                    GameManager.Instance.GrowTree();
                }
                break;

            case 2:
                if (loveMeter.filled && waterMeter.filled && mineralMeter.filled)// && sunMeter.filled)
                {
                    GameManager.Instance.GrowTree();
                }
                break;           
        }
        
        
    }
}
