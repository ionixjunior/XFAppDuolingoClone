using System;
using CoreAnimation;
using CoreGraphics;
using UIKit;

namespace AppDuolingoClone.iOS.Controls
{
    public class HorizontalProgressBariOS : UIView
    {
        private CAShapeLayer _progressLayer = new CAShapeLayer();
        private CAShapeLayer _trackLayer = new CAShapeLayer();
        private double _width;
        private double _height;
        private CGColor _trackColor;
        private CGColor _progressColor;
        private double _progress;

        public HorizontalProgressBariOS(
            double width,
            double height,
            CGColor trackColor,
            CGColor progressColor,
            double progress)
        {
            _width = width;
            _height = height;
            _trackColor = trackColor;
            _progressColor = progressColor;
            _progress = progress;
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            MakeHorizontalPath();
        }

        private void MakeHorizontalPath()
        {
            BackgroundColor = UIColor.Clear;
            Layer.CornerRadius = (nfloat)(_height / 2);
            Layer.MasksToBounds = true;

            var path = new UIBezierPath();

            path.MoveTo(new CGPoint(0, _height / 2));
            path.AddLineTo(new CGPoint(Frame.Width, _height / 2));

            _trackLayer.Path = path.CGPath;
            _trackLayer.FillColor = UIColor.Clear.CGColor;
            _trackLayer.StrokeColor = _trackColor;
            _trackLayer.LineWidth = (nfloat)_height;
            _trackLayer.StrokeEnd = (nfloat)1.0;
            Layer.AddSublayer(_trackLayer);

            _progressLayer.Path = path.CGPath;
            _progressLayer.FillColor = UIColor.Clear.CGColor;
            _progressLayer.StrokeColor = _progressColor;
            _progressLayer.LineWidth = (nfloat)_height;
            _progressLayer.StrokeEnd = (nfloat)_progress;
            _progressLayer.LineCap = CAShapeLayer.CapRound;
            Layer.AddSublayer(_progressLayer);

            path.ClosePath();
        }
    }
}
