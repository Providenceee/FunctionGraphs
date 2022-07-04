﻿namespace LinearFunctions
{
    internal class Camera
    {
        public double Scale { get; set; }
        public int Height { get { return Size.Height; } }
        public int Width { get { return Size.Width; } }
        public Size Size { get; set; }
        public Point Location { get; set; } // Control container coordinates
        public PointF GridLocation { get; set; } // Grid coordinates
        public Camera(double scale, Size size, Point location)
        {
            Scale = scale;
            Size = size;
            Location = location;
            GridLocation = new PointF(0, 0);
            PointF edgeGridCoordinates = CoordinateConverter.CameraToGrid(this, new Point(Width, Height));
            GridLocation = new PointF(0 - edgeGridCoordinates.X / 2, 0 - edgeGridCoordinates.Y / 2);
        }
    }
}