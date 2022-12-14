using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "ResourceÑoncentratorBD", menuName = "SO/New Resource Ñoncentrator Data")]
public class ResourceÑoncentratorBD : ScriptableObject
{
    [SerializeField] List<ResourceÑoncentrator> resourceÑoncentrators;

    public List<ResourceÑoncentrator> ResourceÑoncentrators => resourceÑoncentrators;
}

[Serializable]
public class ResourceÑoncentrator 
{
    [SerializeField] private ResourceTypes resourceType;
    [SerializeField] private Sprite enrichmentSprite;
    [SerializeField] private Sprite readyToBreakSprite;

    public ResourceTypes ResourceType => resourceType;
    public Sprite EnrichmentSprite => enrichmentSprite;
    public Sprite ReadyToBreakSprite => readyToBreakSprite;
}
