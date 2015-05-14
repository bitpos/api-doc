using System;

namespace BitPOS
{
	/// <summary>
	/// Create and view status of orders
	/// </summary>
	public interface IOrderProvider
	{
		//Add

		//Status
		Int16 GetConfirmations(String bitcoinAddress);
	}
}