using UnityEngine;

namespace kjtMiddle
{
    public class ThrowAbility : MonoBehaviour, IAbility
    {
        [SerializeField]
        [Range(0.1f, 8)]
        public float throwDelay;

        private float throwTime = float.MinValue;

        [SerializeField]
        private new Rigidbody rigidbody;

        [SerializeField]
        [Range(0.1f, 100)]
        private float throwForce;

        public void Execute()
        {
            if (Time.time > throwTime + throwDelay)
            {
                throwTime = Time.time;
                rigidbody.AddForce(new Vector3(0.0f, 0.0f, 1.0f).normalized * throwForce, ForceMode.Impulse);
            }
        }
    }
}