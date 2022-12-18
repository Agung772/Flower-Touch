using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;

public class SettingParticle : MonoBehaviour
{
    public ParticleSystem particle;
    public float StartLifetime, StartSpeed, StartSize, RateOverTime;
    float startLifetime, startSpeed, startSize, rateOverTime;
    public InputField startLifetimeIF, startSpeedIF, startSizeIF, rateOverTimeIF;

    private void Start()
    {
        DefaultSetting();
    }

    [System.Obsolete]
    private void Update()
    {
        particle.startLifetime = startLifetime;

        particle.startSpeed = startSpeed;

        particle.startSize = startSize;

        var emission = particle.emission;
        emission.rateOverTime = rateOverTime;
    }

    public void DefaultSetting()
    {
        startLifetime = StartLifetime;
        startSpeed = StartSpeed;
        startSize = StartSize;
        rateOverTime = RateOverTime;

        startLifetimeIF.text = "" + startLifetime;
        startSpeedIF.text = "" + startSpeed;
        startSizeIF.text = "" + startSize;
        rateOverTimeIF.text = "" + rateOverTime;
    }

    public void InputStartLifetime(string stringValue)
    {
        if (stringValue != "")
        {
            float floatValue = float.Parse(stringValue, CultureInfo.InvariantCulture.NumberFormat);
            startLifetime = floatValue;
            print(floatValue);
        }

    }
    public void InputStartSpeed(string stringValue)
    {
        if (stringValue != "")
        {
            float floatValue = float.Parse(stringValue, CultureInfo.InvariantCulture.NumberFormat);
            startSpeed = floatValue;
            print(floatValue);
        }

    }
    public void InputStartSize(string stringValue)
    {
        if (stringValue != "")
        {
            float floatValue = float.Parse(stringValue, CultureInfo.InvariantCulture.NumberFormat);
            startSize = floatValue;
            print(floatValue);
        }

    }
    public void InputRateOverTime(string stringValue)
    {
        if (stringValue != "")
        {
            float floatValue = float.Parse(stringValue, CultureInfo.InvariantCulture.NumberFormat);
            rateOverTime = floatValue;
            print(floatValue);
        }

    }


}
