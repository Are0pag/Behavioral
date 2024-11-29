using Cysharp.Threading.Tasks;
using Scripts.Tools;
using UnityEngine;

namespace Scripts.Behavioral
{
    public class MovementComponent : MonoBehaviour, IMovable
    {
        [field: SerializeField] public GameObject MovingObject { get; protected set; }

        public virtual async UniTask MoveAsync(Vector3 targetPosition, float byTime) {
            await MovingObject.MoveAsync(targetPosition, byTime);
        }
    }
}