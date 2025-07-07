using UnityEngine;

namespace VFX_Profiler.Runtime
{
	public class EffectOverdraw
	{
		private Camera _camera;

		private int _rtSizeWidth;

		private int _rtSizeHeight;

		private RenderTexture _rt;

		private PixelEvlaData _pixelEvlaData;

		public EffectOverdraw(Camera camera, int rtSizeWidth, int rtSizeHeight)
		{
		}

		private void UpdateOneData(int pixelTotal, int pixelDrawCount)
		{
		}

		private void SetCamera(Camera camera)
		{
		}

		public void Update()
		{
		}

		public PixelEvlaData GetPixelEvlaData()
		{
			return null;
		}

		private void RecordOverDrawData()
		{
		}

		public void GetCameraOverDrawData(out int pixTotal, out int pixActualDraw)
		{
			pixTotal = default(int);
			pixActualDraw = default(int);
		}

		private void GetOverDrawData(Texture2D texture, out int pixTotal, out int pixActualDraw)
		{
			pixTotal = default(int);
			pixActualDraw = default(int);
		}

		private int DrawPixTimes(float r, float g, float b)
		{
			return 0;
		}

		private bool IsEmptyPix(float r, float g, float b)
		{
			return false;
		}
	}
}
