using System;
using UnityEngine;

namespace Moon.Data
{
	public class ObscuredPrefs
	{
		internal enum DataType : byte
		{
			Unknown = 0,
			Int = 5,
			UInt = 10,
			String = 15,
			Float = 20,
			Double = 25,
			Decimal = 27,
			Long = 30,
			ULong = 32,
			Bool = 35,
			ByteArray = 40,
			Vector2 = 45,
			Vector3 = 50,
			Quaternion = 55,
			Color = 60,
			Rect = 65
		}

		public enum DeviceLockLevel : byte
		{
			None = 0,
			Soft = 1,
			Strict = 2
		}

		private readonly IEncryptedDataClient _encryptedDataClient;

		private const byte VERSION = 2;

		private const string RAW_NOT_FOUND = "{not_found}";

		private const string DATA_SEPARATOR = "|";

		private bool foreignSavesReported;

		private string cryptoKey;

		private string deviceId;

		private uint deviceIdHash;

		public Action onAlterationDetected;

		public bool preserve_dataStorage;

		public Action onPossibleForeignSavesDetected;

		public DeviceLockLevel lockToDevice;

		public bool readForeignSaves;

		public bool emergencyMode;

		private const char DEPRECATED_RAW_SEPARATOR = ':';

		private string deprecatedDeviceId;

		public string CryptoKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string DeviceId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private uint DeviceIdHash => 0u;

		private string DeprecatedDeviceId => null;

		public ObscuredPrefs(IEncryptedDataClient client)
		{
		}

		public void ForceLockToDeviceInit()
		{
		}

		public void SetUInt(string key, uint value)
		{
		}

		public uint GetUInt(string key)
		{
			return 0u;
		}

		public uint GetUInt(string key, uint defaultValue)
		{
			return 0u;
		}

		private string EncryptUIntValue(string key, uint value)
		{
			return null;
		}

		private uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
		{
			return 0u;
		}

		public void SetString(string key, string value)
		{
		}

		public string GetString(string key)
		{
			return null;
		}

		public string GetString(string key, string defaultValue)
		{
			return null;
		}

		internal string EncryptStringValue(string key, string value)
		{
			return null;
		}

		internal string DecryptStringValue(string key, string encryptedInput, string defaultValue)
		{
			return null;
		}

		public void SetDouble(string key, double value)
		{
		}

		public double GetDouble(string key)
		{
			return 0.0;
		}

		public double GetDouble(string key, double defaultValue)
		{
			return 0.0;
		}

		private string EncryptDoubleValue(string key, double value)
		{
			return null;
		}

		private double DecryptDoubleValue(string key, string encryptedInput, double defaultValue)
		{
			return 0.0;
		}

		public void SetDecimal(string key, decimal value)
		{
		}

		public decimal GetDecimal(string key)
		{
			return default(decimal);
		}

		public decimal GetDecimal(string key, decimal defaultValue)
		{
			return default(decimal);
		}

		private string EncryptDecimalValue(string key, decimal value)
		{
			return null;
		}

		private decimal DecryptDecimalValue(string key, string encryptedInput, decimal defaultValue)
		{
			return default(decimal);
		}

		public void SetLong(string key, long value)
		{
		}

		public long GetLong(string key)
		{
			return 0L;
		}

		public long GetLong(string key, long defaultValue)
		{
			return 0L;
		}

		private string EncryptLongValue(string key, long value)
		{
			return null;
		}

		private long DecryptLongValue(string key, string encryptedInput, long defaultValue)
		{
			return 0L;
		}

		public void SetULong(string key, ulong value)
		{
		}

		public ulong GetULong(string key)
		{
			return 0uL;
		}

		public ulong GetULong(string key, ulong defaultValue)
		{
			return 0uL;
		}

		private string EncryptULongValue(string key, ulong value)
		{
			return null;
		}

		private ulong DecryptULongValue(string key, string encryptedInput, ulong defaultValue)
		{
			return 0uL;
		}

		public void SetBool(string key, bool value)
		{
		}

		public bool GetBool(string key)
		{
			return false;
		}

		public bool GetBool(string key, bool defaultValue)
		{
			return false;
		}

		private string EncryptBoolValue(string key, bool value)
		{
			return null;
		}

		private bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
		{
			return false;
		}

		public void SetByteArray(string key, byte[] value)
		{
		}

		public byte[] GetByteArray(string key)
		{
			return null;
		}

		public byte[] GetByteArray(string key, byte defaultValue, int defaultLength)
		{
			return null;
		}

		private string EncryptByteArrayValue(string key, byte[] value)
		{
			return null;
		}

		private byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
		{
			return null;
		}

		private byte[] ConstructByteArray(byte value, int length)
		{
			return null;
		}

		public void SetVector2(string key, Vector2 value)
		{
		}

		public Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		public Vector2 GetVector2(string key, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		private string EncryptVector2Value(string key, Vector2 value)
		{
			return null;
		}

		private Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		public void SetVector3(string key, Vector3 value)
		{
		}

		public Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		public Vector3 GetVector3(string key, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		private string EncryptVector3Value(string key, Vector3 value)
		{
			return null;
		}

		private Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		public void SetQuaternion(string key, Quaternion value)
		{
		}

		public Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		public Quaternion GetQuaternion(string key, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		private string EncryptQuaternionValue(string key, Quaternion value)
		{
			return null;
		}

		private Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		public void SetColor(string key, Color32 value)
		{
		}

		public Color32 GetColor(string key)
		{
			return default(Color32);
		}

		public Color32 GetColor(string key, Color32 defaultValue)
		{
			return default(Color32);
		}

		private string EncryptColorValue(string key, uint value)
		{
			return null;
		}

		public void SetRect(string key, Rect value)
		{
		}

		public Rect GetRect(string key)
		{
			return default(Rect);
		}

		public Rect GetRect(string key, Rect defaultValue)
		{
			return default(Rect);
		}

		private string EncryptRectValue(string key, Rect value)
		{
			return null;
		}

		private Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue)
		{
			return default(Rect);
		}

		public void SetRawValue(string key, string encryptedValue)
		{
		}

		public string GetRawValue(string key)
		{
			return null;
		}

		internal DataType GetRawValueType(string value)
		{
			return default(DataType);
		}

		internal string EncryptKey(string key)
		{
			return null;
		}

		public bool HasKey(string key)
		{
			return false;
		}

		public void DeleteKey(string key)
		{
		}

		private string GetEncryptedPrefsString(string key, string encryptedKey)
		{
			return null;
		}

		private string EncryptData(string key, byte[] cleanBytes, DataType type)
		{
			return null;
		}

		internal byte[] DecryptData(string key, string encryptedInput)
		{
			return null;
		}

		private uint CalculateChecksum(string input)
		{
			return 0u;
		}

		private void SavesTampered()
		{
		}

		private void PossibleForeignSavesDetected()
		{
		}

		private string GetDeviceId()
		{
			return null;
		}

		private byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key)
		{
			return null;
		}

		private string DeprecatedDecryptValue(string value)
		{
			return null;
		}

		private string DeprecatedCalculateChecksum(string input)
		{
			return null;
		}
	}
}
