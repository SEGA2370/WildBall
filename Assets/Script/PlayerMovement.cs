using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 2f;
        [SerializeField] private float jumpForce = 5f;

        private Rigidbody playerRigidbody;
        private bool floorCollider = true;

        void Awake()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }

        /// <summary>
        /// Applies planar force. No more internal jump check here.
        /// </summary>
        public void MoveCharacter(Vector3 movement)
        {
            playerRigidbody.AddForce(movement * speed);
        }

        /// <summary>
        /// Called by PlayerController when jump is requested.
        /// </summary>
        public void Jump()
        {
            if (!floorCollider) return;
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            floorCollider = false;
        }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("FloorCollider"))
                floorCollider = true;
        }

#if UNITY_EDITOR
        [ContextMenu("Reset Values")]
        public void ResetValues()
        {
            speed = 2f;
        }
#endif
    }
}
