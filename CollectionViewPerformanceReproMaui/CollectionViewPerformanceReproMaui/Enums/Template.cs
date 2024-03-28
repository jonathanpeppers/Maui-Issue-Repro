namespace CollectionViewPerformanceReproMaui.Enums
{
	public enum Template
	{
		// Baseline
		Card,

		CardWithShadow,
		CardWithCornerRadius,
		CardWithBindableLayout,
		CardWithTapGesture,
		CardWithIsVisible,
		CardWithGrid,

		// Worst case scenario
		CardWithTheLot,
	}
}
