using Snake1125.Game.Objects;
using System.Drawing;

namespace Snake1125.Game.Drawing.DrawObjects
{
    internal class GameFieldDraw : IDraw
    {

        public void Draw(GameObject gameObject, Graphics graphics)
        {
            graphics.Clear(Color.Black);
            Pen YellowPen = new Pen(Color.LightPink, 3);
            graphics.DrawLine(YellowPen, 1 , 1 , 1, 1080);
            graphics.DrawLine(YellowPen, 1, 1, 1920, 1);
            graphics.DrawLine(YellowPen, 1920, 1, 1920, 1920);
            graphics.DrawLine(YellowPen, 1, 1080, 1920, 1080);
        }
    }
}