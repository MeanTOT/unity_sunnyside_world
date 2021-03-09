using UnityEngine;
using Sirenix.OdinInspector;

namespace Sunny
{
    [RequireComponent(typeof(Animator))]
    public class NaturalObject : MonoBehaviour, IInteraction
    {
        [BoxGroup("Natural")] public Data.Natural Data;
        [BoxGroup("Natural")] [SerializeField] private EInteractionType mInteractionType;
        public EInteractionType Type { get => mInteractionType; }

        protected float CurrentHp;
        protected Animator Animator = null;
        protected readonly string ANIM_BREAK = "Break";

        private void Awake()
        {
            Animator = this.GetComponent<Animator>();
        }

        private void Start()
        {
            CurrentHp = Data.Hp;
        }
        
        public virtual void Interaction()
        {
         
        }
    }
}
