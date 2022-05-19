using FairyGUI;
using UnityEngine;

namespace ET
{
    public class GlobalComponent: Entity, IAwake
    {
        public static GlobalComponent Instance;

        public Transform Global { get; set; }
        public Transform Unit{ get; set; }
        public Transform UI{ get; set; }
        public Transform NormalRoot{ get; set; }
        public Transform PopUpRoot{ get; set; }
        public Transform FixedRoot{ get; set; }
        public Transform PoolRoot{ get; set; }
        public Transform OtherRoot{ get; set; }
        
        public GComponent GRoot{ get; set; }
        public GComponent NormalGRoot{ get; set; }
        public GComponent PopUpGRoot{ get; set; }
        public GComponent FixedGRoot{ get; set; }
        public GComponent OtherGRoot{ get; set; }
    }
}