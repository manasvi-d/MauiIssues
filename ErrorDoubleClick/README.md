# Error Double Tap
On Windows, tap gesture event handler for single mouse click get triggered even for a double mouse click on GraphicsView widget. (this does not happen on android)

This project contains a graphicsview on the page configured with single tap and double tap events. on single tap, a circle is drawn. On double tap there is no action. 

On Windows if you double tap, at that point a circle gets drawn. On Android, the circle is not drawn at the point. 