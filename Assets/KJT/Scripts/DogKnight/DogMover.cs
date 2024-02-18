using UnityEngine;

namespace kjtMiddle
{
    public class DogMover : MonoBehaviour
    {
        [SerializeField]
        [Range(0.0001f, 0.001f)]
        public float speed = 0.0001f;
    }
}