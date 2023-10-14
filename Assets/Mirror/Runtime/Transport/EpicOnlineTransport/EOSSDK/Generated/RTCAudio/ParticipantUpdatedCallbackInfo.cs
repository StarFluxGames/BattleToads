// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTCAudio
{
	/// <summary>
	/// This struct is passed in with a call to <see cref="RTCAudioInterface.AddNotifyParticipantUpdated" /> registered event.
	/// </summary>
	public class ParticipantUpdatedCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// Client-specified data passed into <see cref="RTCAudioInterface.AddNotifyParticipantUpdated" />.
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

		/// <summary>
		/// The participant updated.
		/// </summary>
		public ProductUserId ParticipantId { get; private set; }

		/// <summary>
		/// The participant speaking / non-speaking status.
		/// </summary>
		public bool Speaking { get; private set; }

		/// <summary>
		/// The participant audio status (enabled, disabled).
		/// </summary>
		public RTCAudioStatus AudioStatus { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(ParticipantUpdatedCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				RoomName = other.Value.RoomName;
				ParticipantId = other.Value.ParticipantId;
				Speaking = other.Value.Speaking;
				AudioStatus = other.Value.AudioStatus;
			}
		}

		public void Set(object other)
		{
			Set(other as ParticipantUpdatedCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct ParticipantUpdatedCallbackInfoInternal : ICallbackInfoInternal
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RoomName;
		private System.IntPtr m_ParticipantId;
		private int m_Speaking;
		private RTCAudioStatus m_AudioStatus;

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

		public ProductUserId ParticipantId
		{
			get
			{
				ProductUserId value;
				Helper.TryMarshalGet(m_ParticipantId, out value);
				return value;
			}
		}

		public bool Speaking
		{
			get
			{
				bool value;
				Helper.TryMarshalGet(m_Speaking, out value);
				return value;
			}
		}

		public RTCAudioStatus AudioStatus
		{
			get
			{
				return m_AudioStatus;
			}
		}
	}
}