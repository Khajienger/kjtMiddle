using UnityEngine;

namespace kjtMiddle
{
    public class ShotAbility : MonoBehaviour, IAbility
    {
        [SerializeField]
        public GameObject bullet;

        [SerializeField]
        [Range(0.1f, 8)]
        public float shotDelay;

        private float shotTime = float.MinValue;

        public void Execute()
        {
            if (Time.time > shotTime + shotDelay)
            {
                shotTime = Time.time;

                if (bullet != null)
                {
                    GameObject _bullet = Instantiate(bullet, transform.position, transform.rotation);
                }
                else
                {
                    Debug.LogError("bullet is null");
                }
            }
        }
    }
}