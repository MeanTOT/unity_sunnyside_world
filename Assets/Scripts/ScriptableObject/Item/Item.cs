using UnityEngine;
using Sirenix.OdinInspector;

namespace Sunny.Data
{
    [CreateAssetMenu(menuName = "Data/Item")]
    public class Item : ScriptableObject
    {
        [BoxGroup("ItemData")] public string Name;
        [BoxGroup("ItemData")] public Sprite Sprite;
    }
}
