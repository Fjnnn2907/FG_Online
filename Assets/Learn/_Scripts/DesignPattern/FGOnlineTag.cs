using UnityEngine;

namespace FG.Online
{
    public static class FGOnlineTag
    {
        // Animator Parameter Hashes
        public static readonly int AnimX = Animator.StringToHash("X");
        public static readonly int AnimY = Animator.StringToHash("Y");
        public static readonly int AnimDead = Animator.StringToHash("isDead");
        // Animator Layer Names
        public const string RunLayer = "Run";
        public const string IdleLayer = "Idle";

        // Input Axes
        public const string HorizontalAxis = "Horizontal";
        public const string VerticalAxis = "Vertical";

    }
}
