using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staturs : MonoBehaviour
{
    [Header("Walk, Run Speed")]
    [SerializeField]
    private float   walkSpeed;
    [SerializeField]
    private float   runSpeed;

    public float    WalkSpeed => walkSpeed;
    public float    RunSpeed => runSpeed;
}
