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

        public CircularProgressBariOS(
            double width,
            double height,
            CGColor trackColor,
            CGColor progressColor,
            double progress)
        {
            MakeCircularPath(width, height, trackColor, progressColor, progress);
        }

        private void MakeCircularPath(
            double width,
            double height,
            CGColor trackColor,
            CGColor progressColor,
            double progress)
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
            _trackLayer.StrokeColor = trackColor;
            _trackLayer.LineWidth = (nfloat)8.0;
            _trackLayer.StrokeEnd = (nfloat)1.0;
            Layer.AddSublayer(_trackLayer);

            _progressLayer.Path = circlePath.CGPath;
            _progressLayer.FillColor = UIColor.Clear.CGColor;
            _progressLayer.StrokeColor = progressColor;
            _progressLayer.LineWidth = (nfloat)8.0;
            _progressLayer.StrokeEnd = (nfloat)progress;
            Layer.AddSublayer(_progressLayer);
        }
    }
}
