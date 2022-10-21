using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    [CreateAssetMenu(fileName = "ResourceConcentratorBD", menuName = "SO/New Resource Concentrator Data")]
    public class ResourceConcentratorBD : ScriptableObject
    {
        [SerializeField] List<ResourceConcentrator> resourceConcentrators;

        public List<ResourceConcentrator> ResourceConcentrators => resourceConcentrators;
    }

