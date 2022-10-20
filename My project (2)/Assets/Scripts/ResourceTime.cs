using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "ResourceTimeData", menuName = "SO/New Resource Time Data")]
public class ResourceTimeData : ScriptableObject
{
    [SerializeField] private ResourceTime resourceTime;

    public ResourceTime ResourceTime => resourceTime;
}

[Serializable]
public class ResourceTime
{
    [SerializeField] private ResourceTypes resourceTypes;
    [SerializeField] private float enrichmentTime;
    [SerializeField] private float decayTime;

    public ResourceTypes ResourceType => resourceTypes;
    public float EnrichmentTime => enrichmentTime;
    public float DecayTime => decayTime;
}
