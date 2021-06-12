using System.Collections.Generic;

namespace LapsRuntime {
    [LapsAddMenuOptions("Logic/Value/Layer")]
    public class LayerValue : LapsComponent {
        [Layer] public int value;
        public bool triggerOnAwake = false;
        public bool triggerOnChange = true;
        private void Awake() {
            if (triggerOnAwake) {
                Trigger();
            }
        }
        public override object HandleInput(int index, object argument, LapsComponent eventSource) {
            switch(index) {
                case 10: value  = (int)(float)argument;  OnValueChanged(); break;
                case 11: return value;
                case 12: Trigger(); break;
            }
            return null;
        }
        public void OnValueChanged() {
            if (triggerOnChange) {
                Trigger();
            }
        }
        public void Trigger() {
            FireOutput(0, value);
        }
        public override void GetInputSlots(List<LogicSlot> slots) {
            slots.Add(new LogicSlot("set value", 10, typeof(float)));
            slots.Add(new LogicSlot("get value", 11, null, typeof(float)));
            slots.Add(new LogicSlot("trigger", 12));
        }
        public override void GetOutputSlots(List<LogicSlot> slots) {
            slots.Add(new LogicSlot("on value change", 0, typeof(float), null));
        }
    }
}
