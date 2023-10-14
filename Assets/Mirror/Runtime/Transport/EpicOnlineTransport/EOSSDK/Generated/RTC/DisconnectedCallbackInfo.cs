// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTC
{
	/// <summary>
	/// This struct is passed in with a call to <see cref="RTCInterface.AddNotifyDisconnected" /> registered event.
	/// </summary>
	public class DisconnectedCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// This returns:
		/// <see cref="Result.Success" /> The room was left cleanly.
		/// <see cref="Result.NoConnection" />: There was a network issue connecting to the server (retryable).
		/// <see cref="Result.UserKicked" />: The user has been kicked by the server (retryable).
		/// <see cref="Result.ServiceFailure" />: A known error occurred during interaction with the server (retryable).
		/// <see cref="Result.UnexpectedError" /> Unexpected error (retryable).
		/// </summary>
		public Result ResultCode { get; private set; }

		/// <summary>
		/// Client-specified data passed into <see cref="RTCInterface.AddNotifyDisconnected" />.
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The Product User ID of the user who initiated this request.
		/// </summary>
		public ProductUserId LocalUserId { get; private set; }

		/// <summary>
		/// The room associated with this event.
		/// </summary>
		public string RoomName { get; private set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(DisconnectedCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				RoomName = other.Value.RoomName;
			}
		}

		public void Set(object other)
		{
			Set(other as DisconnectedCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct DisconnectedCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RoomName;

		public Result ResultCode
		{
			get
			{
				return m_ResultCode;
			}
		}

		public object ClientData
		{
			get
			{
				object value;
				Helper.TryMarshalGet(m_ClientData, out value);
				return value;
			}
		}

		public System.IntPtr ClientDataAddress
		{
			get
			{
				return m_ClientData;
			}
		}

		public ProductUserId LocalUserId
		{
			get
			{
				ProductUserId value;
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
		}

		public string RoomName
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_RoomName, out value);
				return value;
			}
		}
	}
}