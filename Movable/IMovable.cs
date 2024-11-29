using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Scripts.Behavioral
{
    public interface IMovable
    {
        GameObject MovingObject { get; }
        UniTask MoveAsync(Vector3 targetPosition, float byTime);
    }
}