using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Resource—oncentratorBD", menuName = "SO/New Resource —oncentrator Data")]
public class Resource—oncentratorBD : ScriptableObject
{
    [SerializeField] List<Resource—oncentrator> resource—oncentrators;

    public List<Resource—oncentrator> Resource—oncentrators => resource—oncentrators;
}

[Serializable]
public class Resource—oncentrator 
{
    [SerializeField] private ResourceTypes resourceType;
    [SerializeField] private Sprite enrichmentSprite;
    [SerializeField] private Sprite readyToBreakSprite;

    public ResourceTypes ResourceType => resourceType;
    public Sprite EnrichmentSprite => enrichmentSprite;
    public Sprite ReadyToBreakSprite => readyToBreakSprite;
}
