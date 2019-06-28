using System;

namespace UI
{
    internal class elapsedeventhandler
    {
        private Action<object, EventArgs> lblNegro_Click;

        public elapsedeventhandler(Action<object, EventArgs> lblNegro_Click)
        {
            this.lblNegro_Click = lblNegro_Click;
        }
    }
}