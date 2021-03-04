using UnityEngine;
using Sirenix.OdinInspector;

namespace Sunny
{
    [CreateAssetMenu(menuName = "Data/Item")]
    public class ItemData : ScriptableObject
    {
        [BoxGroup("ItemData")] public string Name;
        [BoxGroup("ItemData")] public Sprite Sprite;
    }
}
