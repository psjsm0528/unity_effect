using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACEvent : MonoBehaviour
{
    [SerializeField] private ParticleSystem effect; // �츮�� ����� ����Ʈ
    [SerializeField] private Transform spawnPos;
    public void PlayVFX()
    {
        Instantiate(effect, spawnPos.position, Quaternion.identity);
        effect.Play();
    }
}
