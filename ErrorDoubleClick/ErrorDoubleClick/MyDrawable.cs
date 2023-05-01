using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorDoubleClick
{
	public class MyDrawable : IDrawable
	{
		public static Point? Selection = null;

		public void Draw(ICanvas canvas, RectF dirtyRect)
		{
			if (Selection != null)
			{
				canvas.StrokeColor = Colors.Red; canvas.FillColor = Colors.Red;
				canvas.DrawCircle(Selection.Value, 5d);
			}
		}
	}
}

