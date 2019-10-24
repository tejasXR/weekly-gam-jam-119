using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        GameManager.TreeGrowCallback += AddMusicLayer;
    }

    private void OnDisable()
    {
        GameManager.TreeGrowCallback -= AddMusicLayer;
    }

    private void AddMusicLayer()
    {
        anim.SetTrigger("next");
    }
}
