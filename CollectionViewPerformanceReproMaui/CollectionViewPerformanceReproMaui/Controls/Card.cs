using Microsoft.Maui.Controls.Shapes;

namespace CollectionViewPerformanceReproMaui.Controls
{
	public class Card : Border
	{
		public Card() : base()
		{
			this.BackgroundColor = Colors.White;

			this.Padding = 15;
			this.StrokeThickness = 0;
		}

		public static readonly BindableProperty HasShadowProperty = BindableProperty.Create(nameof(HasShadow), typeof(bool), typeof(Label), false, BindingMode.OneTime, propertyChanged: (bindable, oldValue, newValue) =>
		{
			((Card)bindable).Shadow = new Shadow
			{
				Brush = Colors.Black,
				Opacity = 0.5f,
				Offset = new Point(2, 2),
				Radius = 4
			};
		});

		public static readonly BindableProperty HasCornerRadiusProperty = BindableProperty.Create(nameof(HasCornerRadius), typeof(bool), typeof(Label), false, BindingMode.OneTime, propertyChanged: (bindable, oldValue, newValue) =>
		{
			((Card)bindable).StrokeShape = new RoundRectangle
			{
				CornerRadius = new CornerRadius(15)
			};
		});

		public bool HasShadow
		{
			get => (bool)GetValue(HasShadowProperty);
			set => SetValue(HasShadowProperty, value);
		}

		public bool HasCornerRadius
		{
			get => (bool)GetValue(HasCornerRadiusProperty);
			set => SetValue(HasCornerRadiusProperty, value);
		}
	}
}