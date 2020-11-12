﻿using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using PhotoRender.Filteres;
using Image = System.Windows.Controls.Image;

namespace PhotoRender
{
    public partial class AstridSlider
    {
        private static Bitmap _originBitmap; 
        private static Image _originalImg;

        public AstridSlider(Image img, Bitmap bimap)
        {
            _originalImg = img;
            _originBitmap = bimap;
            InitializeComponent();
        }

        private void Bright_ValueChanger(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
            contrastSlider.Value = 0;
            BrightnessContrast.ChangeBrightnessForTick(_originBitmap, _originalImg, brightSlider);
        }

        private void Contrast_ValueChanger(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
            brightSlider.Value = 0;
            BrightnessContrast.ChangeContrastForTick(_originBitmap, _originalImg, contrastSlider);
        }
    }
}