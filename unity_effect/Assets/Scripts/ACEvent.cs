using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACEvent : MonoBehaviour
{
    [SerializeField] private ParticleSystem effect; // 우리가 사용할 이펙트
    [SerializeField] private Transform spawnPos;
    public void PlayVFX()
    {
        Instantiate(effect, spawnPos.position, Quaternion.identity);
        effect.Play();
    }
}
