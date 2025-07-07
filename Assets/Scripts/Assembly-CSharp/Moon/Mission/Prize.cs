using Moon.Shop;

namespace Moon.Mission
{
	public class Prize
	{
		public string Id;

		public string Name;

		public string StackId;

		public int Quantity;

		public Rarity GetPrizeCategory()
		{
			return default(Rarity);
		}
	}
}
