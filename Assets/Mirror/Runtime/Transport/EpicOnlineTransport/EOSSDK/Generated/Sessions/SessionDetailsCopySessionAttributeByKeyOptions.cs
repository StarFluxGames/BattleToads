// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionDetails.CopySessionAttributeByKey" /> function.
	/// </summary>
	public class SessionDetailsCopySessionAttributeByKeyOptions
	{
		/// <summary>
		/// The name of the key to get the session attribution for
		/// <seealso cref="SessionModification.AddAttribute" />
		/// </summary>
		public string AttrKey { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SessionDetailsCopySessionAttributeByKeyOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_AttrKey;

		public string AttrKey
		{
			set
			{
				Helper.TryMarshalSet(ref m_AttrKey, value);
			}
		}

		public void Set(SessionDetailsCopySessionAttributeByKeyOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = SessionDetails.SessiondetailsCopysessionattributebykeyApiLatest;
				AttrKey = other.AttrKey;
			}
		}

		public void Set(object other)
		{
			Set(other as SessionDetailsCopySessionAttributeByKeyOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_AttrKey);
		}
	}
}