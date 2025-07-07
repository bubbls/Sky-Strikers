namespace SVGImporter.Utils
{
	public struct SVGLength
	{
		private SVGLengthType _unitType;

		private float _valueInSpecifiedUnits;

		private float _value;

		public float value => 0f;

		public SVGLengthType unitType => default(SVGLengthType);

		public SVGLength(SVGLengthType unitType, float valueInSpecifiedUnits)
		{
			_unitType = default(SVGLengthType);
			_valueInSpecifiedUnits = 0f;
			_value = 0f;
		}

		public SVGLength(float valueInSpecifiedUnits)
		{
			_unitType = default(SVGLengthType);
			_valueInSpecifiedUnits = 0f;
			_value = 0f;
		}

		public SVGLength(string valueText)
		{
			_unitType = default(SVGLengthType);
			_valueInSpecifiedUnits = 0f;
			_value = 0f;
		}

		public void NewValueSpecifiedUnits(float valueInSpecifiedUnits)
		{
		}

		public static float GetPXLength(string valueText)
		{
			return 0f;
		}

		public SVGLength Multiply(SVGLength svglength)
		{
			return default(SVGLength);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
