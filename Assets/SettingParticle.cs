using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingParticle : MonoBehaviour
{
    public ParticleSystem particle;
    public float startLifetime, startSpeed, startSize, rateOverTime;

    [System.Obsolete]
    private void Update()
    {
        particle.startLifetime = startLifetime;

        particle.startSpeed = startSpeed;

        particle.startSize = startSize;

        var emission = particle.emission;
        emission.rateOverTime = rateOverTime;
    }
}
