using System.Windows;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace InstagramDesktopExam.UserControls
{

    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }
        public int PaddingNum
        {
            get { return (int)GetValue(PaddingNumProperty); }
            set { SetValue(PaddingNumProperty, value); }
        }

        public static readonly DependencyProperty PaddingNumProperty = DependencyProperty.Register("PaddingNum", typeof(int), typeof(Profile), new PropertyMetadata(null));

        public int Size
        {
            get { return (int)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        public static readonly DependencyProperty SizeProperty = DependencyProperty.Register("Size", typeof(int), typeof(Profile), new PropertyMetadata(null));

        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(ImageSource), typeof(Profile), new PropertyMetadata(null));



    }
}
