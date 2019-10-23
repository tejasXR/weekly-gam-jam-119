using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class ClickableObject : MonoBehaviour
{
    #region EVENTS

    public event Action ClickedCallback;

    protected void OnClicked()
    {
        ClickedCallback?.Invoke();
    }

    #endregion

    public void Clicked()
    {
        ClickedEvent.Invoke();
        OnClicked();
    }

    public UnityEvent ClickedEvent;
}
