using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Scene))]
    public class BattleScene: Entity, IScene, IAwake, IUpdate
    {
        public SceneType SceneType { get; set; } = SceneType.Battle;
        public string Name { get; set; }
        
        private long lsWorldInstanceId;
        
        public LSWorld LSWorld
        {
            get
            {
                return Root.Instance.Get(this.lsWorldInstanceId) as LSWorld;
            }
            set
            {
                this.AddChild(value);
                this.lsWorldInstanceId = value.InstanceId;
            }
        }

        public int Frame;

        public long StartTime { get; set; }

        public FrameBuffer FrameBuffer { get; } = new();
    }
}