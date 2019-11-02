using System;
using CoreAnimation;
using CoreGraphics;
using UIKit;

namespace AppDuolingoClone.iOS.Controls
{
    public class CircularProgressBariOS : UIView
    {
        private CAShapeLayer _progressLayer = new CAShapeLayer();
        private CAShapeLayer _trackLayer = new CAShapeLayer();

        public CircularProgressBariOS(double width, double height)
        {
            MakeCircularPath(width, height);
        }

        private void MakeCircularPath(double width, double height)
        {
            BackgroundColor = UIColor.Clear;
            Layer.CornerRadius = (nfloat)(width / 2);

            var circlePath = new UIBezierPath();
            circlePath.AddArc(
                center: new CGPoint(x: width / 2, y: height / 2),
                radius: (nfloat)((width - 1.5) / 2),
                startAngle: (nfloat)(-0.5 * Math.PI),
                endAngle: (nfloat)(1.5 * Math.PI),
                clockWise: true
            );

            _trackLayer.Path = circlePath.CGPath;
            _trackLayer.FillColor = UIColor.Clear.CGColor;
            _trackLayer.StrokeColor = UIColor.Blue.CGColor;
            _trackLayer.LineWidth = (nfloat)5.0;
            _trackLayer.StrokeEnd = (nfloat)1.0;
            Layer.AddSublayer(_trackLayer);

            _progressLayer.Path = circlePath.CGPath;
            _progressLayer.FillColor = UIColor.Clear.CGColor;
            _progressLayer.StrokeColor = UIColor.Red.CGColor;
            _progressLayer.LineWidth = (nfloat)5.0;
            _progressLayer.StrokeEnd = (nfloat)0.2;
            Layer.AddSublayer(_progressLayer);
        }
    }
}
