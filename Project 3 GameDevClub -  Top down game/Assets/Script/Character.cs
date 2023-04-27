using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBeheviour{
    [Header("Visualization")]
    [SerializeField] protected Animation _anim;
    [SerializeField] protected AudioSource _attackSoundEffect;
    [SerializeField] protected AudioSource _skill1SoundEffect;
    [SerializeField] protected AudioSource _skill2SoundEffect;


    [Header("INFO")]
    [SerializeField] protected float _maxMoveSpeed;
    [SerializeField] protected float _maxWeight;
    [SerializeField] protected float _maxMana;


    [Header("debug")]
    [SerializeField] protected float _curMoveSpeed;
}
